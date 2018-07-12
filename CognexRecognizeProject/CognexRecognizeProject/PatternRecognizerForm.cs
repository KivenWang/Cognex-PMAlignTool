using Cognex.VisionPro;
using Cognex.VisionPro.Barcode;
using Cognex.VisionPro.Implementation;
using Cognex.VisionPro.PMAlign;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CognexRecognizeProject
{
    public partial class PatternRecognizer : Form
    {
        /// <summary>
        /// cognex识别工具
        /// </summary>
        private CogPMAlignTool _PMAlignTool { get; set; }
        private Bitmap _inputImageTrain {get;set;}
        private Bitmap _inputImageRecognize { get; set; }
        private CogRectangle _trainRegion { get; set; }
        private CogRectangle _resultRegion { get; set; }

        #region BIRCH文件加密解密key
        private const string KEY64 = @"\[._.]!/";
        private const string IV64 = @"<\(^!~)>";
        private byte[] _byteKEY = System.Text.ASCIIEncoding.ASCII.GetBytes(KEY64);
        private byte[] _byteIV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV64);
        #endregion
        public PatternRecognizer()
        {
            InitializeComponent();
            _PMAlignTool = new CogPMAlignTool();
            this.cogDisplayToolbarV21.Display = this.cogDisplayTrain;
            this.cogDisplayToolbarV22.Display = this.cogDisplayRecognize;
        }

        private void Recognize_Click(object sender, EventArgs e)
        {
            this.cogDisplayRecognize.StaticGraphics.Clear();
            this.txtResult.Text = string.Empty;
            this.txtLocationX.Text = string.Empty;
            this.txtLocationY.Text = string.Empty;
            this.txtConstrast.Text = string.Empty;
            if (!_PMAlignTool .Pattern.Trained)
            {
                TrainCurrentImage();
            }
            try
            {
                _PMAlignTool.RunParams.AcceptThreshold = double.Parse(this.spinAcceptThreshold.Value.ToString());
                //_PMAlignTool.RunParams.ContrastThreshold = 10;
                _PMAlignTool.RunParams.RunAlgorithm = (CogPMAlignRunAlgorithmConstants)Enum.Parse
                    (typeof(CogPMAlignRunAlgorithmConstants), this.cboRunAlgorithm.Text);
                _PMAlignTool.RunParams.RunMode = (CogPMAlignRunModeConstants)Enum.Parse
                    (typeof(CogPMAlignRunModeConstants), this.cboRunMode.Text);
                _PMAlignTool.InputImage = new CogImage8Grey(_inputImageRecognize);
                _PMAlignTool.Run();
                if ((CogToolBase.SfCreateLastRunRecord == (int)CogBarcodeLastRunRecordConstants.ResultsBounds) || (CogToolBase.SfRunStatus == 4))
                {
                    if (_PMAlignTool.Results == null && _PMAlignTool.RunStatus.Exception != null)
                    {
                        return;
                    }

                    var bestResult = from CogPMAlignResult eachResult in _PMAlignTool.Results
                                     orderby (eachResult.GetPose().TranslationX)
                                     orderby eachResult.GetPose().TranslationY
                                     select eachResult;

                    foreach (CogPMAlignResult eachResult in bestResult)
                    {
                        CogTransform2DLinear resultPosition = eachResult.GetPose();

                        this.txtResult.Text += eachResult.Score.ToString("0.00") + ";";
                        this.txtLocationX.Text += resultPosition.TranslationX.ToString("0.00") + ";";
                        this.txtLocationY.Text += resultPosition.TranslationY.ToString("0.00") + ";";
                        this.txtConstrast.Text += eachResult.Contrast.ToString("0.00")+";";
                        CogCompositeShape shape = eachResult.CreateResultGraphics(CogPMAlignResultGraphicConstants.All);
                        ICogGraphic graphic = shape.CopyBase(CogCopyShapeConstants.BasicGraphics);
                        graphic.Color = CogColorConstants.Green;
                        this.cogDisplayRecognize.StaticGraphics.Add(graphic, "ResultRegion");
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("Recognize Failed!  {0}",ex.Message));
            }
        }

        private void btnLoadTrainFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            string dataPath = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dataPath = folderBrowserDialog1.SelectedPath + @"\";
            }
            if (dataPath == "") return;
            _trainRegion = null;
            DirectoryInfo fileFold = new DirectoryInfo(dataPath);
            FileInfo[] files = fileFold.GetFiles();
            for (int i = 0; files != null && i < files.Length; i++)  
            {
                try       
                {

                    if (files[i].Extension == ".bmp") 
                    {
                        var bitmap = Bitmap.FromFile(files[i].FullName) as Bitmap;
                        _inputImageTrain = bitmap;
                        ICogImage displayImage;
                        if (bitmap != null)
                        {
                            displayImage = new CogImage8Grey(bitmap);
                        }
                        else
                        {
                            displayImage = null;
                        }
                        this.cogDisplayTrain.Image = displayImage;
                        this.cogDisplayTrain.AutoFit = true;

                    }
                    else if (files[i].Extension == ".train")
                    {
                        byte[] content = FileDecoding(files[i].FullName);
                        var loadedPattern = BinaryDeserialize(content) as CogPMAlignPattern;
                        _PMAlignTool.Pattern = loadedPattern;

                        ICogTransform2D transform = loadedPattern.TrainImage.GetTransform(".", loadedPattern.TrainRegion.SelectedSpaceName);
                        ICogShape cogShape = loadedPattern.TrainRegion.Map(transform, CogCopyShapeConstants.GeometryOnly);
                        _trainRegion = cogShape.EnclosingRectangle(CogCopyShapeConstants.GeometryOnly);
                        InitialTrainRegion();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }  
        }

        private void btnLoadRecognitionImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var bitmap = Bitmap.FromFile(openFile.FileName) as Bitmap;
                _inputImageRecognize = bitmap;
                ICogImage displayImage;
                if (bitmap != null)
                {
                    displayImage = new CogImage8Grey(bitmap);
                }
                else
                {
                    displayImage = null;
                }

                this.cogDisplayRecognize.Image = displayImage;
                this.cogDisplayRecognize.AutoFit = true;
            }
        }

        private void btnLoadTrainImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var bitmap = Bitmap.FromFile(openFile.FileName) as Bitmap;
                _inputImageTrain = bitmap;
                ICogImage displayImage;
                if (bitmap != null)
                {
                    displayImage = new CogImage8Grey(bitmap);
                }
                else
                {
                    displayImage = null;
                }

                this.cogDisplayTrain.Image = displayImage;
                this.cogDisplayTrain.AutoFit = true;
            }
        }

        private void btnCreateModel_Click(object sender, EventArgs e)
        {
            this._trainRegion = null;
            InitialTrainRegion();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainCurrentImage();
        }
        private bool TrainCurrentImage()
        {
            try
            {
                _PMAlignTool.Pattern.TrainImage = new CogImage8Grey(_inputImageTrain);
                _PMAlignTool.Pattern.TrainAlgorithm = (CogPMAlignTrainAlgorithmConstants)Enum.Parse
                    (typeof(CogPMAlignTrainAlgorithmConstants), this.cboTrainAlgorithm.Text);
                _PMAlignTool.Pattern.TrainMode = (CogPMAlignTrainModeConstants)Enum.Parse
                    (typeof(CogPMAlignTrainModeConstants), this.cboTrainMode.Text);
                _PMAlignTool.Pattern.TrainRegionMode = (CogRegionModeConstants)Enum.Parse
                    (typeof(CogRegionModeConstants), this.cboTrainRegionMode.Text);
                _PMAlignTool.Pattern.TrainRegion = _trainRegion;
                _PMAlignTool.Pattern.IgnorePolarity = this.ckbPolarity.Checked;
                _PMAlignTool.Pattern.Origin.TranslationX = _trainRegion.CenterX;
                _PMAlignTool.Pattern.Origin.TranslationY = _trainRegion.CenterY;
                _PMAlignTool.Pattern.Train();

                var grainColl = _PMAlignTool.Pattern.CreateGraphicsCoarse(CogColorConstants.Yellow);
                this.cogDisplayTrain.StaticGraphics.Clear();
                for (int i = 0; i < grainColl.Count; i++)
                {
                    this.cogDisplayTrain.StaticGraphics.Add(grainColl[i], "");
                }
                var grainColls = _PMAlignTool.Pattern.CreateGraphicsFine(CogColorConstants.Green);
                for (int i = 0; i < grainColls.Count; i++)
                {
                    this.cogDisplayTrain.StaticGraphics.Add(grainColls[i], "");
                }
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("Train Failed! {0}", ex.Message));
                return false;
            }

        }

        private void PatternRecognizer_Shown(object sender, EventArgs e)
        {
            this.cboTrainAlgorithm.SelectedIndex = 1;
            this.cboRunAlgorithm.SelectedIndex = 2;
            this.cboTrainMode.SelectedIndex = 0;
            this.cboTrainRegionMode.SelectedIndex = 0;
            this.cboRunMode.SelectedIndex = 0;
        }

        private void InitialTrainRegion()
        {
            this.cogDisplayTrain.InteractiveGraphics.Clear();
            if (_trainRegion==null)
            {
                _trainRegion = new CogRectangle();
                _trainRegion.SetCenterWidthHeight(this.cogDisplayTrain.Image.Width / 2,
                    this.cogDisplayTrain.Image.Height / 2, this.cogDisplayTrain.Image.Width / 4, this.cogDisplayTrain.Image.Height/4);
            }
            _trainRegion.Interactive = true;
            _trainRegion.GraphicDOFEnable = CogRectangleDOFConstants.All;
            _trainRegion.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
            this.cogDisplayTrain.InteractiveGraphics.Add(_trainRegion, "TrainRegion", false);
        }

        /// <summary>
        /// 由加密的文件中解密出二进制数据
        /// </summary>
        /// <param name="inFile"></param>
        /// <returns></returns>
        private byte[] FileDecoding(string inFile)
        {
            byte[] result = null;
            if (!File.Exists(inFile))
            {
                return result;
            }

            DES des = null;
            try
            {
                using (FileStream fs = new FileStream(inFile, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        byte[] readBuffer = new byte[100];    //This is intermediate storage for the encryption.
                        long readLen = 0;
                        long fileLen = fs.Length;       //This is the total length of the input file.
                        int len;                     //This is the number of bytes to be written at a time.

                        des = new DESCryptoServiceProvider();
                        using (CryptoStream encStream = new CryptoStream(ms, des.CreateDecryptor(_byteKEY, _byteIV), CryptoStreamMode.Write))
                        {
                            //Read from the input file, then encrypt and write to the output file.
                            while (readLen < fileLen)
                            {
                                len = fs.Read(readBuffer, 0, 100);
                                encStream.Write(readBuffer, 0, len);
                                readLen += len;
                            }
                        }
                        result = ms.ToArray();
                    }
                }
                return result;
            }
            finally
            {
                if (des != null)
                {
                    des.Clear();
                }
            }
        }

        public static object BinaryDeserialize(byte[] src)
        {
            object result = null;
            System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(src, 0, src.Length);
                ms.Position = 0;
                result = formatter.Deserialize(ms);
            }
            return result;
        }
    }
}
