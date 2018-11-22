namespace DetectFault
{
	partial class Frm_DetectFault
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuVision = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuVisionOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuVisionPause = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuStartImageprocessing = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuVisionClose = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMore = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCapture = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLoadImage = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuBinarization = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuGetContour = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOCR = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuGetLanes = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDeepLearning = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuImageProcessing = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCnn = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.splMain = new System.Windows.Forms.SplitContainer();
			this.tblMain = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.imgbCannyEdge = new Emgu.CV.UI.ImageBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.imgbIDownUpSampling = new Emgu.CV.UI.ImageBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.imgbCam = new Emgu.CV.UI.ImageBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.imgbGrayscale = new Emgu.CV.UI.ImageBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lblAlarm = new System.Windows.Forms.Label();
			this.rtxtResult = new System.Windows.Forms.RichTextBox();
			this.imgbResult = new Emgu.CV.UI.ImageBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.trkArea = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.trkThreshLinking = new System.Windows.Forms.TrackBar();
			this.trkThresh = new System.Windows.Forms.TrackBar();
			this.mnuBinarywithGray = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMain.SuspendLayout();
			this.pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
			this.splMain.Panel1.SuspendLayout();
			this.splMain.Panel2.SuspendLayout();
			this.splMain.SuspendLayout();
			this.tblMain.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgbCannyEdge)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgbIDownUpSampling)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgbCam)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgbGrayscale)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgbResult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkArea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkThreshLinking)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkThresh)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuVision,
            this.mnuMore,
            this.mnuDeepLearning});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(1262, 28);
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.toolStripMenuItem1,
            this.mnuClose});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(51, 24);
			this.mnuFile.Text = "파일";
			// 
			// mnuSave
			// 
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.Size = new System.Drawing.Size(114, 26);
			this.mnuSave.Text = "저장";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 6);
			// 
			// mnuClose
			// 
			this.mnuClose.Name = "mnuClose";
			this.mnuClose.Size = new System.Drawing.Size(114, 26);
			this.mnuClose.Text = "닫기";
			this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
			// 
			// mnuVision
			// 
			this.mnuVision.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVisionOpen,
            this.mnuVisionPause,
            this.mnuStartImageprocessing,
            this.toolStripMenuItem2,
            this.mnuVisionClose});
			this.mnuVision.Name = "mnuVision";
			this.mnuVision.Size = new System.Drawing.Size(51, 24);
			this.mnuVision.Text = "영상";
			// 
			// mnuVisionOpen
			// 
			this.mnuVisionOpen.Name = "mnuVisionOpen";
			this.mnuVisionOpen.Size = new System.Drawing.Size(114, 26);
			this.mnuVisionOpen.Text = "열기";
			this.mnuVisionOpen.Click += new System.EventHandler(this.mnuVisionOpen_Click);
			// 
			// mnuVisionPause
			// 
			this.mnuVisionPause.Enabled = false;
			this.mnuVisionPause.Name = "mnuVisionPause";
			this.mnuVisionPause.Size = new System.Drawing.Size(114, 26);
			this.mnuVisionPause.Text = "멈춤";
			// 
			// mnuStartImageprocessing
			// 
			this.mnuStartImageprocessing.Enabled = false;
			this.mnuStartImageprocessing.Name = "mnuStartImageprocessing";
			this.mnuStartImageprocessing.Size = new System.Drawing.Size(114, 26);
			this.mnuStartImageprocessing.Text = "분석";
			this.mnuStartImageprocessing.Click += new System.EventHandler(this.mnuStartImageprocessing_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 6);
			// 
			// mnuVisionClose
			// 
			this.mnuVisionClose.Enabled = false;
			this.mnuVisionClose.Name = "mnuVisionClose";
			this.mnuVisionClose.Size = new System.Drawing.Size(114, 26);
			this.mnuVisionClose.Text = "닫기";
			// 
			// mnuMore
			// 
			this.mnuMore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapture,
            this.mnuLoadImage,
            this.toolStripMenuItem3,
            this.mnuBinarization,
            this.mnuBinarywithGray,
            this.mnuGetContour,
            this.mnuOCR,
            this.mnuGetLanes});
			this.mnuMore.Name = "mnuMore";
			this.mnuMore.Size = new System.Drawing.Size(81, 24);
			this.mnuMore.Text = "추가분석";
			// 
			// mnuCapture
			// 
			this.mnuCapture.Name = "mnuCapture";
			this.mnuCapture.Size = new System.Drawing.Size(216, 26);
			this.mnuCapture.Text = "캡쳐";
			this.mnuCapture.Click += new System.EventHandler(this.mnuCapture_Click);
			// 
			// mnuLoadImage
			// 
			this.mnuLoadImage.Name = "mnuLoadImage";
			this.mnuLoadImage.Size = new System.Drawing.Size(216, 26);
			this.mnuLoadImage.Text = "이미지불러오기";
			this.mnuLoadImage.Click += new System.EventHandler(this.mnuLoadImage_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(213, 6);
			// 
			// mnuBinarization
			// 
			this.mnuBinarization.Enabled = false;
			this.mnuBinarization.Name = "mnuBinarization";
			this.mnuBinarization.Size = new System.Drawing.Size(216, 26);
			this.mnuBinarization.Text = "이진화";
			this.mnuBinarization.Click += new System.EventHandler(this.mnuBinarization_Click);
			// 
			// mnuGetContour
			// 
			this.mnuGetContour.Enabled = false;
			this.mnuGetContour.Name = "mnuGetContour";
			this.mnuGetContour.Size = new System.Drawing.Size(216, 26);
			this.mnuGetContour.Text = "형태검출";
			this.mnuGetContour.Click += new System.EventHandler(this.mnuGetContour_Click);
			// 
			// mnuOCR
			// 
			this.mnuOCR.Enabled = false;
			this.mnuOCR.Name = "mnuOCR";
			this.mnuOCR.Size = new System.Drawing.Size(216, 26);
			this.mnuOCR.Text = "OCR";
			this.mnuOCR.Click += new System.EventHandler(this.mnuOCR_Click);
			// 
			// mnuGetLanes
			// 
			this.mnuGetLanes.Enabled = false;
			this.mnuGetLanes.Name = "mnuGetLanes";
			this.mnuGetLanes.Size = new System.Drawing.Size(216, 26);
			this.mnuGetLanes.Text = "차선검출";
			// 
			// mnuDeepLearning
			// 
			this.mnuDeepLearning.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImageProcessing,
            this.mnuCnn});
			this.mnuDeepLearning.Name = "mnuDeepLearning";
			this.mnuDeepLearning.Size = new System.Drawing.Size(51, 24);
			this.mnuDeepLearning.Text = "모드";
			// 
			// mnuImageProcessing
			// 
			this.mnuImageProcessing.Checked = true;
			this.mnuImageProcessing.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuImageProcessing.Name = "mnuImageProcessing";
			this.mnuImageProcessing.Size = new System.Drawing.Size(194, 26);
			this.mnuImageProcessing.Text = "이미지 프로세싱";
			this.mnuImageProcessing.Click += new System.EventHandler(this.mnuImageProcessing_Click);
			// 
			// mnuCnn
			// 
			this.mnuCnn.Name = "mnuCnn";
			this.mnuCnn.Size = new System.Drawing.Size(194, 26);
			this.mnuCnn.Text = "딥러닝 - CNN";
			this.mnuCnn.Click += new System.EventHandler(this.mnuCnn_Click);
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.splMain);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 28);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(1262, 614);
			this.pnlMain.TabIndex = 1;
			// 
			// splMain
			// 
			this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splMain.Location = new System.Drawing.Point(0, 0);
			this.splMain.Name = "splMain";
			this.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splMain.Panel1
			// 
			this.splMain.Panel1.Controls.Add(this.tblMain);
			// 
			// splMain.Panel2
			// 
			this.splMain.Panel2.Controls.Add(this.groupBox5);
			this.splMain.Panel2.Controls.Add(this.label3);
			this.splMain.Panel2.Controls.Add(this.trkArea);
			this.splMain.Panel2.Controls.Add(this.label2);
			this.splMain.Panel2.Controls.Add(this.label1);
			this.splMain.Panel2.Controls.Add(this.trkThreshLinking);
			this.splMain.Panel2.Controls.Add(this.trkThresh);
			this.splMain.Size = new System.Drawing.Size(1262, 614);
			this.splMain.SplitterDistance = 286;
			this.splMain.TabIndex = 0;
			// 
			// tblMain
			// 
			this.tblMain.ColumnCount = 4;
			this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tblMain.Controls.Add(this.groupBox4, 3, 0);
			this.tblMain.Controls.Add(this.groupBox3, 2, 0);
			this.tblMain.Controls.Add(this.groupBox2, 0, 0);
			this.tblMain.Controls.Add(this.groupBox1, 1, 0);
			this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblMain.Location = new System.Drawing.Point(0, 0);
			this.tblMain.Name = "tblMain";
			this.tblMain.RowCount = 1;
			this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblMain.Size = new System.Drawing.Size(1262, 286);
			this.tblMain.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.imgbCannyEdge);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(948, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(311, 280);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Canny Edge";
			// 
			// imgbCannyEdge
			// 
			this.imgbCannyEdge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgbCannyEdge.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imgbCannyEdge.Location = new System.Drawing.Point(3, 21);
			this.imgbCannyEdge.Margin = new System.Windows.Forms.Padding(0);
			this.imgbCannyEdge.Name = "imgbCannyEdge";
			this.imgbCannyEdge.Size = new System.Drawing.Size(305, 256);
			this.imgbCannyEdge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgbCannyEdge.TabIndex = 4;
			this.imgbCannyEdge.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.imgbIDownUpSampling);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(633, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(309, 280);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Down Up Sampling";
			// 
			// imgbIDownUpSampling
			// 
			this.imgbIDownUpSampling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgbIDownUpSampling.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imgbIDownUpSampling.Location = new System.Drawing.Point(3, 21);
			this.imgbIDownUpSampling.Margin = new System.Windows.Forms.Padding(0);
			this.imgbIDownUpSampling.Name = "imgbIDownUpSampling";
			this.imgbIDownUpSampling.Size = new System.Drawing.Size(303, 256);
			this.imgbIDownUpSampling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgbIDownUpSampling.TabIndex = 4;
			this.imgbIDownUpSampling.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.imgbCam);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(309, 280);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Original";
			// 
			// imgbCam
			// 
			this.imgbCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgbCam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imgbCam.Location = new System.Drawing.Point(3, 21);
			this.imgbCam.Margin = new System.Windows.Forms.Padding(0);
			this.imgbCam.Name = "imgbCam";
			this.imgbCam.Size = new System.Drawing.Size(303, 256);
			this.imgbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgbCam.TabIndex = 4;
			this.imgbCam.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.imgbGrayscale);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(318, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(309, 280);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Grayscale";
			// 
			// imgbGrayscale
			// 
			this.imgbGrayscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgbGrayscale.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imgbGrayscale.Location = new System.Drawing.Point(3, 21);
			this.imgbGrayscale.Margin = new System.Windows.Forms.Padding(0);
			this.imgbGrayscale.Name = "imgbGrayscale";
			this.imgbGrayscale.Size = new System.Drawing.Size(303, 256);
			this.imgbGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgbGrayscale.TabIndex = 4;
			this.imgbGrayscale.TabStop = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lblAlarm);
			this.groupBox5.Controls.Add(this.rtxtResult);
			this.groupBox5.Controls.Add(this.imgbResult);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Location = new System.Drawing.Point(377, 21);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(879, 285);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "영상 분석 결과";
			// 
			// lblAlarm
			// 
			this.lblAlarm.AutoSize = true;
			this.lblAlarm.Font = new System.Drawing.Font("나눔고딕", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblAlarm.ForeColor = System.Drawing.Color.Red;
			this.lblAlarm.Location = new System.Drawing.Point(568, 222);
			this.lblAlarm.Name = "lblAlarm";
			this.lblAlarm.Size = new System.Drawing.Size(307, 55);
			this.lblAlarm.TabIndex = 2;
			this.lblAlarm.Text = "동그라미 검출";
			this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rtxtResult
			// 
			this.rtxtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtxtResult.Location = new System.Drawing.Point(310, 21);
			this.rtxtResult.Name = "rtxtResult";
			this.rtxtResult.Size = new System.Drawing.Size(252, 256);
			this.rtxtResult.TabIndex = 6;
			this.rtxtResult.Text = "";
			// 
			// imgbResult
			// 
			this.imgbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgbResult.Location = new System.Drawing.Point(3, 21);
			this.imgbResult.Margin = new System.Windows.Forms.Padding(0);
			this.imgbResult.Name = "imgbResult";
			this.imgbResult.Size = new System.Drawing.Size(303, 256);
			this.imgbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgbResult.TabIndex = 5;
			this.imgbResult.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.Location = new System.Drawing.Point(648, 109);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(19, 20);
			this.label9.TabIndex = 5;
			this.label9.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(648, 73);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(19, 20);
			this.label8.TabIndex = 5;
			this.label8.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(583, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Lot X: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(648, 37);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(19, 20);
			this.label7.TabIndex = 5;
			this.label7.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(583, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Lot ㅁ: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(583, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Lot O: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(12, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(235, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Rectangle Area Size Standard";
			// 
			// trkArea
			// 
			this.trkArea.Location = new System.Drawing.Point(6, 250);
			this.trkArea.Maximum = 3000;
			this.trkArea.Name = "trkArea";
			this.trkArea.Size = new System.Drawing.Size(359, 56);
			this.trkArea.SmallChange = 100;
			this.trkArea.TabIndex = 6;
			this.trkArea.TickFrequency = 100;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(12, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Canny Edge Thresh Linking";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Canny Edge Thresh";
			// 
			// trkThreshLinking
			// 
			this.trkThreshLinking.Location = new System.Drawing.Point(12, 154);
			this.trkThreshLinking.Maximum = 300;
			this.trkThreshLinking.Name = "trkThreshLinking";
			this.trkThreshLinking.Size = new System.Drawing.Size(359, 56);
			this.trkThreshLinking.SmallChange = 10;
			this.trkThreshLinking.TabIndex = 2;
			this.trkThreshLinking.TickFrequency = 10;
			// 
			// trkThresh
			// 
			this.trkThresh.Location = new System.Drawing.Point(12, 58);
			this.trkThresh.Maximum = 300;
			this.trkThresh.Name = "trkThresh";
			this.trkThresh.Size = new System.Drawing.Size(359, 56);
			this.trkThresh.SmallChange = 10;
			this.trkThresh.TabIndex = 3;
			this.trkThresh.TickFrequency = 10;
			// 
			// mnuBinarywithGray
			// 
			this.mnuBinarywithGray.Enabled = false;
			this.mnuBinarywithGray.Name = "mnuBinarywithGray";
			this.mnuBinarywithGray.Size = new System.Drawing.Size(216, 26);
			this.mnuBinarywithGray.Text = "이진화 + GrayScale";
			this.mnuBinarywithGray.Click += new System.EventHandler(this.mnuBinarywithGray_Click);
			// 
			// Frm_DetectFault
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1262, 642);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.mnuMain);
			this.MainMenuStrip = this.mnuMain;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_DetectFault";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "영상처리기반 Serial Tag 자동 분류 시스템";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_DetectFault_FormClosed);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.pnlMain.ResumeLayout(false);
			this.splMain.Panel1.ResumeLayout(false);
			this.splMain.Panel2.ResumeLayout(false);
			this.splMain.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
			this.splMain.ResumeLayout(false);
			this.tblMain.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgbCannyEdge)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgbIDownUpSampling)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgbCam)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgbGrayscale)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgbResult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkArea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkThreshLinking)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkThresh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.SplitContainer splMain;
		private System.Windows.Forms.TableLayoutPanel tblMain;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private Emgu.CV.UI.ImageBox imgbCannyEdge;
		private Emgu.CV.UI.ImageBox imgbIDownUpSampling;
		private Emgu.CV.UI.ImageBox imgbCam;
		private Emgu.CV.UI.ImageBox imgbGrayscale;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trkThreshLinking;
		private System.Windows.Forms.TrackBar trkThresh;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuClose;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trkArea;
		private System.Windows.Forms.ToolStripMenuItem mnuVision;
		private System.Windows.Forms.ToolStripMenuItem mnuVisionOpen;
		private System.Windows.Forms.ToolStripMenuItem mnuVisionPause;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mnuVisionClose;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RichTextBox rtxtResult;
		private Emgu.CV.UI.ImageBox imgbResult;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripMenuItem mnuDeepLearning;
		private System.Windows.Forms.ToolStripMenuItem mnuCnn;
		private System.Windows.Forms.ToolStripMenuItem mnuMore;
		private System.Windows.Forms.ToolStripMenuItem mnuOCR;
		private System.Windows.Forms.ToolStripMenuItem mnuCapture;
		private System.Windows.Forms.ToolStripMenuItem mnuGetLanes;
		private System.Windows.Forms.ToolStripMenuItem mnuImageProcessing;
		private System.Windows.Forms.ToolStripMenuItem mnuStartImageprocessing;
		private System.Windows.Forms.Label lblAlarm;
		private System.Windows.Forms.ToolStripMenuItem mnuLoadImage;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mnuGetContour;
		private System.Windows.Forms.ToolStripMenuItem mnuBinarization;
		private System.Windows.Forms.ToolStripMenuItem mnuBinarywithGray;
	}
}