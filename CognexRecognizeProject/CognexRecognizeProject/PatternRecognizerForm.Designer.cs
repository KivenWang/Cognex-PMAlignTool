namespace CognexRecognizeProject
{
    partial class PatternRecognizer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternRecognizer));
            this.btnRecognition = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cogDisplayToolbarV22 = new Cognex.VisionPro.CogDisplayToolbarV2();
            this.cogDisplayRecognize = new Cognex.VisionPro.Display.CogDisplay();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadRecognitionImage = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cogDisplayToolbarV21 = new Cognex.VisionPro.CogDisplayToolbarV2();
            this.cogDisplayTrain = new Cognex.VisionPro.Display.CogDisplay();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadTrainImage = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateModel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrain = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadTrainFiles = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cboRunMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtLocationY = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtLocationX = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.spinAcceptThreshold = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboRunAlgorithm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboTrainRegionMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboTrainMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboTrainAlgorithm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtConstrast = new DevExpress.XtraEditors.TextEdit();
            this.ckbPolarity = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtResult = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplayRecognize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplayTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRunMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAcceptThreshold.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRunAlgorithm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainRegionMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainAlgorithm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConstrast.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbPolarity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecognition
            // 
            this.btnRecognition.Location = new System.Drawing.Point(406, 5);
            this.btnRecognition.Name = "btnRecognition";
            this.btnRecognition.Size = new System.Drawing.Size(149, 46);
            this.btnRecognition.TabIndex = 0;
            this.btnRecognition.Text = "Recognize";
            this.btnRecognition.Click += new System.EventHandler(this.Recognize_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1665, 854);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cogDisplayToolbarV22, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cogDisplayRecognize, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panelControl2, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(835, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(827, 719);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // cogDisplayToolbarV22
            // 
            this.cogDisplayToolbarV22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayToolbarV22.Location = new System.Drawing.Point(4, 4);
            this.cogDisplayToolbarV22.Margin = new System.Windows.Forms.Padding(4);
            this.cogDisplayToolbarV22.Name = "cogDisplayToolbarV22";
            this.cogDisplayToolbarV22.Size = new System.Drawing.Size(819, 34);
            this.cogDisplayToolbarV22.TabIndex = 4;
            // 
            // cogDisplayRecognize
            // 
            this.cogDisplayRecognize.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplayRecognize.ColorMapLowerRoiLimit = 0D;
            this.cogDisplayRecognize.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplayRecognize.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplayRecognize.ColorMapUpperRoiLimit = 1D;
            this.cogDisplayRecognize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayRecognize.DoubleTapZoomCycleLength = 2;
            this.cogDisplayRecognize.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplayRecognize.Location = new System.Drawing.Point(0, 42);
            this.cogDisplayRecognize.Margin = new System.Windows.Forms.Padding(0);
            this.cogDisplayRecognize.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplayRecognize.MouseWheelSensitivity = 1D;
            this.cogDisplayRecognize.Name = "cogDisplayRecognize";
            this.cogDisplayRecognize.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplayRecognize.OcxState")));
            this.cogDisplayRecognize.Size = new System.Drawing.Size(827, 617);
            this.cogDisplayRecognize.TabIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnLoadRecognitionImage);
            this.panelControl2.Controls.Add(this.btnRecognition);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(3, 662);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(821, 54);
            this.panelControl2.TabIndex = 6;
            // 
            // btnLoadRecognitionImage
            // 
            this.btnLoadRecognitionImage.Location = new System.Drawing.Point(248, 5);
            this.btnLoadRecognitionImage.Name = "btnLoadRecognitionImage";
            this.btnLoadRecognitionImage.Size = new System.Drawing.Size(149, 46);
            this.btnLoadRecognitionImage.TabIndex = 6;
            this.btnLoadRecognitionImage.Text = "Load";
            this.btnLoadRecognitionImage.Click += new System.EventHandler(this.btnLoadRecognitionImage_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cogDisplayToolbarV21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cogDisplayTrain, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelControl1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(826, 719);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cogDisplayToolbarV21
            // 
            this.cogDisplayToolbarV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayToolbarV21.Location = new System.Drawing.Point(4, 4);
            this.cogDisplayToolbarV21.Margin = new System.Windows.Forms.Padding(4);
            this.cogDisplayToolbarV21.Name = "cogDisplayToolbarV21";
            this.cogDisplayToolbarV21.Size = new System.Drawing.Size(818, 34);
            this.cogDisplayToolbarV21.TabIndex = 4;
            // 
            // cogDisplayTrain
            // 
            this.cogDisplayTrain.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplayTrain.ColorMapLowerRoiLimit = 0D;
            this.cogDisplayTrain.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplayTrain.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplayTrain.ColorMapUpperRoiLimit = 1D;
            this.cogDisplayTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayTrain.DoubleTapZoomCycleLength = 2;
            this.cogDisplayTrain.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplayTrain.Location = new System.Drawing.Point(0, 42);
            this.cogDisplayTrain.Margin = new System.Windows.Forms.Padding(0);
            this.cogDisplayTrain.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplayTrain.MouseWheelSensitivity = 1D;
            this.cogDisplayTrain.Name = "cogDisplayTrain";
            this.cogDisplayTrain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplayTrain.OcxState")));
            this.cogDisplayTrain.Size = new System.Drawing.Size(826, 617);
            this.cogDisplayTrain.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnLoadTrainImage);
            this.panelControl1.Controls.Add(this.btnCreateModel);
            this.panelControl1.Controls.Add(this.btnTrain);
            this.panelControl1.Controls.Add(this.btnLoadTrainFiles);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 662);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(820, 54);
            this.panelControl1.TabIndex = 6;
            // 
            // btnLoadTrainImage
            // 
            this.btnLoadTrainImage.Location = new System.Drawing.Point(251, 5);
            this.btnLoadTrainImage.Name = "btnLoadTrainImage";
            this.btnLoadTrainImage.Size = new System.Drawing.Size(150, 46);
            this.btnLoadTrainImage.TabIndex = 9;
            this.btnLoadTrainImage.Text = "LoadImage";
            this.btnLoadTrainImage.Click += new System.EventHandler(this.btnLoadTrainImage_Click);
            // 
            // btnCreateModel
            // 
            this.btnCreateModel.Location = new System.Drawing.Point(407, 5);
            this.btnCreateModel.Name = "btnCreateModel";
            this.btnCreateModel.Size = new System.Drawing.Size(150, 46);
            this.btnCreateModel.TabIndex = 8;
            this.btnCreateModel.Text = "InitTrainRegion";
            this.btnCreateModel.Click += new System.EventHandler(this.btnCreateModel_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(563, 5);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(150, 46);
            this.btnTrain.TabIndex = 7;
            this.btnTrain.Text = "Train";
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnLoadTrainFiles
            // 
            this.btnLoadTrainFiles.Location = new System.Drawing.Point(95, 4);
            this.btnLoadTrainFiles.Name = "btnLoadTrainFiles";
            this.btnLoadTrainFiles.Size = new System.Drawing.Size(150, 46);
            this.btnLoadTrainFiles.TabIndex = 6;
            this.btnLoadTrainFiles.Text = "LoadTrainFiles";
            this.btnLoadTrainFiles.Click += new System.EventHandler(this.btnLoadTrainFiles_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tableLayoutPanel1.SetColumnSpan(this.panelControl3, 2);
            this.panelControl3.Controls.Add(this.labelControl10);
            this.panelControl3.Controls.Add(this.cboRunMode);
            this.panelControl3.Controls.Add(this.txtLocationY);
            this.panelControl3.Controls.Add(this.labelControl8);
            this.panelControl3.Controls.Add(this.txtLocationX);
            this.panelControl3.Controls.Add(this.labelControl9);
            this.panelControl3.Controls.Add(this.spinAcceptThreshold);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.cboRunAlgorithm);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.cboTrainRegionMode);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.cboTrainMode);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.cboTrainAlgorithm);
            this.panelControl3.Controls.Add(this.txtConstrast);
            this.panelControl3.Controls.Add(this.ckbPolarity);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.txtResult);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(3, 728);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1659, 123);
            this.panelControl3.TabIndex = 3;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(832, 92);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(86, 22);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Run Mode:";
            // 
            // cboRunMode
            // 
            this.cboRunMode.Location = new System.Drawing.Point(957, 89);
            this.cboRunMode.Name = "cboRunMode";
            this.cboRunMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRunMode.Properties.Items.AddRange(new object[] {
            "SearchImage",
            "RefineStartPose"});
            this.cboRunMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRunMode.Size = new System.Drawing.Size(134, 28);
            this.cboRunMode.TabIndex = 25;
            // 
            // txtLocationY
            // 
            this.txtLocationY.Location = new System.Drawing.Point(1500, 69);
            this.txtLocationY.Name = "txtLocationY";
            this.txtLocationY.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtLocationY.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocationY.Properties.AutoHeight = false;
            this.txtLocationY.Size = new System.Drawing.Size(160, 35);
            this.txtLocationY.TabIndex = 23;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(1413, 75);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(82, 22);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "LocationY:";
            // 
            // txtLocationX
            // 
            this.txtLocationX.Location = new System.Drawing.Point(1239, 69);
            this.txtLocationX.Name = "txtLocationX";
            this.txtLocationX.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtLocationX.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocationX.Properties.AutoHeight = false;
            this.txtLocationX.Size = new System.Drawing.Size(160, 35);
            this.txtLocationX.TabIndex = 21;
            // 
            // labelControl9
            // 
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(1157, 63);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(86, 46);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "LocationX:";
            // 
            // spinAcceptThreshold
            // 
            this.spinAcceptThreshold.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.spinAcceptThreshold.Location = new System.Drawing.Point(978, 16);
            this.spinAcceptThreshold.Name = "spinAcceptThreshold";
            this.spinAcceptThreshold.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAcceptThreshold.Properties.MaxValue = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.spinAcceptThreshold.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.spinAcceptThreshold.Size = new System.Drawing.Size(100, 28);
            this.spinAcceptThreshold.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(832, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(119, 22);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Run Algorithm:";
            // 
            // cboRunAlgorithm
            // 
            this.cboRunAlgorithm.Location = new System.Drawing.Point(957, 56);
            this.cboRunAlgorithm.Name = "cboRunAlgorithm";
            this.cboRunAlgorithm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRunAlgorithm.Properties.Items.AddRange(new object[] {
            "PatMax",
            "PatQuick",
            "BestTrained",
            "PatFlex",
            "PatMaxPerspective"});
            this.cboRunAlgorithm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRunAlgorithm.Size = new System.Drawing.Size(134, 28);
            this.cboRunAlgorithm.TabIndex = 18;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(318, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(109, 22);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Region Mode:";
            // 
            // cboTrainRegionMode
            // 
            this.cboTrainRegionMode.Location = new System.Drawing.Point(433, 16);
            this.cboTrainRegionMode.Name = "cboTrainRegionMode";
            this.cboTrainRegionMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTrainRegionMode.Properties.Items.AddRange(new object[] {
            "PixelAlignedBoundingBoxAdjustMask",
            "PixelAlignedBoundingBox",
            "AffineTransform"});
            this.cboTrainRegionMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTrainRegionMode.Size = new System.Drawing.Size(144, 28);
            this.cboTrainRegionMode.TabIndex = 16;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 56);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 22);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Train Mode:";
            // 
            // cboTrainMode
            // 
            this.cboTrainMode.Location = new System.Drawing.Point(127, 53);
            this.cboTrainMode.Name = "cboTrainMode";
            this.cboTrainMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTrainMode.Properties.Items.AddRange(new object[] {
            "Image",
            "ShapeModelsWithImage",
            "ShapeModelsWithTransform"});
            this.cboTrainMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTrainMode.Size = new System.Drawing.Size(158, 28);
            this.cboTrainMode.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 22);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Algorithm:";
            // 
            // cboTrainAlgorithm
            // 
            this.cboTrainAlgorithm.Location = new System.Drawing.Point(127, 16);
            this.cboTrainAlgorithm.Name = "cboTrainAlgorithm";
            this.cboTrainAlgorithm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTrainAlgorithm.Properties.Items.AddRange(new object[] {
            "PatMax",
            "PatQuick",
            "PatMaxAndPatQuick",
            "PatFlex",
            "PatMaxHighSensitivity",
            "PatMaxPerspective"});
            this.cboTrainAlgorithm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTrainAlgorithm.Size = new System.Drawing.Size(158, 28);
            this.cboTrainAlgorithm.TabIndex = 12;
            // 
            // txtConstrast
            // 
            this.txtConstrast.Location = new System.Drawing.Point(1500, 15);
            this.txtConstrast.Name = "txtConstrast";
            this.txtConstrast.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtConstrast.Properties.Appearance.Options.UseBackColor = true;
            this.txtConstrast.Properties.AutoHeight = false;
            this.txtConstrast.Size = new System.Drawing.Size(160, 35);
            this.txtConstrast.TabIndex = 9;
            // 
            // ckbPolarity
            // 
            this.ckbPolarity.AutoSizeInLayoutControl = true;
            this.ckbPolarity.Location = new System.Drawing.Point(24, 88);
            this.ckbPolarity.Name = "ckbPolarity";
            this.ckbPolarity.Properties.Caption = "Ignore Polarity";
            this.ckbPolarity.Size = new System.Drawing.Size(158, 26);
            this.ckbPolarity.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(1414, 21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 22);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Contrast:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(832, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 56);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "AcceptThreshold ：";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(1237, 15);
            this.txtResult.Name = "txtResult";
            this.txtResult.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtResult.Properties.Appearance.Options.UseBackColor = true;
            this.txtResult.Properties.AutoHeight = false;
            this.txtResult.Size = new System.Drawing.Size(160, 35);
            this.txtResult.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(1171, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 46);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Score :";
            // 
            // PatternRecognizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 854);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PatternRecognizer";
            this.Text = "PatternRecognizer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.PatternRecognizer_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplayRecognize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplayTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRunMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocationX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAcceptThreshold.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRunAlgorithm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainRegionMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrainAlgorithm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConstrast.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbPolarity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRecognition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Cognex.VisionPro.CogDisplayToolbarV2 cogDisplayToolbarV21;
        private Cognex.VisionPro.Display.CogDisplay cogDisplayTrain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Cognex.VisionPro.CogDisplayToolbarV2 cogDisplayToolbarV22;
        private Cognex.VisionPro.Display.CogDisplay cogDisplayRecognize;
        private DevExpress.XtraEditors.SimpleButton btnLoadTrainFiles;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadRecognitionImage;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtResult;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTrain;
        private DevExpress.XtraEditors.SimpleButton btnCreateModel;
        private DevExpress.XtraEditors.TextEdit txtConstrast;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit ckbPolarity;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboTrainMode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cboTrainAlgorithm;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cboTrainRegionMode;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cboRunAlgorithm;
        private DevExpress.XtraEditors.SpinEdit spinAcceptThreshold;
        private DevExpress.XtraEditors.SimpleButton btnLoadTrainImage;
        private DevExpress.XtraEditors.TextEdit txtLocationY;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtLocationX;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit cboRunMode;
    }
}

