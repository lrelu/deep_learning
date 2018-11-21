namespace DetectFault
{
	partial class FrmCam
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.camToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.imgbCam = new Emgu.CV.UI.ImageBox();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trkMin = new System.Windows.Forms.TrackBar();
			this.trkMax = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.trkArea = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgbCam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trkArea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.videoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1504, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// camToolStripMenuItem
			// 
			this.camToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripMenuItem2,
            this.captureToolStripMenuItem});
			this.camToolStripMenuItem.Name = "camToolStripMenuItem";
			this.camToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
			this.camToolStripMenuItem.Text = "Cam";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// pauseToolStripMenuItem
			// 
			this.pauseToolStripMenuItem.Enabled = false;
			this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
			this.pauseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.pauseToolStripMenuItem.Text = "Pause";
			this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// stopToolStripMenuItem
			// 
			this.stopToolStripMenuItem.Enabled = false;
			this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			this.stopToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.stopToolStripMenuItem.Text = "Stop";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.startToolStripMenuItem1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem1
			// 
			this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
			this.openToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
			this.openToolStripMenuItem1.Text = "Open";
			this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
			// 
			// startToolStripMenuItem1
			// 
			this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
			this.startToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
			this.startToolStripMenuItem1.Text = "Start";
			// 
			// videoToolStripMenuItem
			// 
			this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalToolStripMenuItem,
            this.cannyToolStripMenuItem,
            this.flipToolStripMenuItem});
			this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
			this.videoToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
			this.videoToolStripMenuItem.Text = "Video";
			// 
			// originalToolStripMenuItem
			// 
			this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
			this.originalToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.originalToolStripMenuItem.Text = "Original";
			this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
			// 
			// cannyToolStripMenuItem
			// 
			this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
			this.cannyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.cannyToolStripMenuItem.Text = "Canny";
			this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
			// 
			// flipToolStripMenuItem
			// 
			this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
			this.flipToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.flipToolStripMenuItem.Text = "Flip";
			this.flipToolStripMenuItem.Click += new System.EventHandler(this.flipToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 28);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.imgbCam);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox4);
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox3);
			this.splitContainer1.Panel2.Controls.Add(this.button15);
			this.splitContainer1.Panel2.Controls.Add(this.button14);
			this.splitContainer1.Panel2.Controls.Add(this.button12);
			this.splitContainer1.Panel2.Controls.Add(this.button11);
			this.splitContainer1.Panel2.Controls.Add(this.button10);
			this.splitContainer1.Panel2.Controls.Add(this.button13);
			this.splitContainer1.Panel2.Controls.Add(this.button9);
			this.splitContainer1.Panel2.Controls.Add(this.button8);
			this.splitContainer1.Panel2.Controls.Add(this.button7);
			this.splitContainer1.Panel2.Controls.Add(this.button6);
			this.splitContainer1.Panel2.Controls.Add(this.button4);
			this.splitContainer1.Panel2.Controls.Add(this.button3);
			this.splitContainer1.Panel2.Controls.Add(this.button5);
			this.splitContainer1.Panel2.Controls.Add(this.button2);
			this.splitContainer1.Panel2.Controls.Add(this.button1);
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.trkMax);
			this.splitContainer1.Panel2.Controls.Add(this.trkArea);
			this.splitContainer1.Panel2.Controls.Add(this.trkMin);
			this.splitContainer1.Size = new System.Drawing.Size(1504, 578);
			this.splitContainer1.SplitterDistance = 503;
			this.splitContainer1.TabIndex = 1;
			// 
			// imgbCam
			// 
			this.imgbCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgbCam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imgbCam.Location = new System.Drawing.Point(0, 0);
			this.imgbCam.Margin = new System.Windows.Forms.Padding(0);
			this.imgbCam.Name = "imgbCam";
			this.imgbCam.Size = new System.Drawing.Size(503, 578);
			this.imgbCam.TabIndex = 3;
			this.imgbCam.TabStop = false;
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
			// 
			// captureToolStripMenuItem
			// 
			this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
			this.captureToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.captureToolStripMenuItem.Text = "Capture";
			this.captureToolStripMenuItem.Click += new System.EventHandler(this.captureToolStripMenuItem_Click);
			// 
			// trkMin
			// 
			this.trkMin.Location = new System.Drawing.Point(12, 41);
			this.trkMin.Maximum = 300;
			this.trkMin.Name = "trkMin";
			this.trkMin.Size = new System.Drawing.Size(351, 56);
			this.trkMin.SmallChange = 10;
			this.trkMin.TabIndex = 0;
			this.trkMin.TickFrequency = 10;
			// 
			// trkMax
			// 
			this.trkMax.Location = new System.Drawing.Point(12, 116);
			this.trkMax.Maximum = 300;
			this.trkMax.Name = "trkMax";
			this.trkMax.Size = new System.Drawing.Size(351, 56);
			this.trkMax.SmallChange = 10;
			this.trkMax.TabIndex = 0;
			this.trkMax.TickFrequency = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Canny Edge Min";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Canny Edge Max";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 317);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(351, 242);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 179);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 56);
			this.button1.TabIndex = 3;
			this.button1.Text = "Capture";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(133, 178);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 56);
			this.button2.TabIndex = 3;
			this.button2.Text = "GrayScale";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(15, 241);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 56);
			this.button3.TabIndex = 3;
			this.button3.Text = "Up Sampling";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(133, 240);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 56);
			this.button4.TabIndex = 3;
			this.button4.Text = "Canny Edge";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(251, 179);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 56);
			this.button5.TabIndex = 3;
			this.button5.Text = "Down Sampling";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(398, 179);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(112, 56);
			this.button6.TabIndex = 3;
			this.button6.Text = "get Circle";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(398, 116);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(112, 56);
			this.button7.TabIndex = 3;
			this.button7.Text = "Sample Image";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(398, 317);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(351, 242);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(519, 116);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(112, 56);
			this.button8.TabIndex = 3;
			this.button8.Text = "Get Rectecgle";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(637, 116);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(112, 56);
			this.button9.TabIndex = 3;
			this.button9.Text = "Get Line";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(519, 178);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(112, 56);
			this.button11.TabIndex = 3;
			this.button11.Text = "Sample Image";
			this.button11.UseVisualStyleBackColor = true;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(637, 178);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(112, 56);
			this.button12.TabIndex = 3;
			this.button12.Text = "Sample Image";
			this.button12.UseVisualStyleBackColor = true;
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(398, 240);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(112, 56);
			this.button13.TabIndex = 3;
			this.button13.Text = "Sample Image";
			this.button13.UseVisualStyleBackColor = true;
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(519, 240);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(112, 56);
			this.button14.TabIndex = 3;
			this.button14.Text = "Sample Image";
			this.button14.UseVisualStyleBackColor = true;
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(637, 240);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(112, 56);
			this.button15.TabIndex = 3;
			this.button15.Text = "Sample Image";
			this.button15.UseVisualStyleBackColor = true;
			// 
			// trkArea
			// 
			this.trkArea.Location = new System.Drawing.Point(398, 41);
			this.trkArea.Maximum = 3000;
			this.trkArea.Name = "trkArea";
			this.trkArea.Size = new System.Drawing.Size(351, 56);
			this.trkArea.SmallChange = 10;
			this.trkArea.TabIndex = 0;
			this.trkArea.TickFrequency = 100;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(398, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(203, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Rectecgle Area Size Standard";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(251, 241);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(112, 56);
			this.button10.TabIndex = 3;
			this.button10.Text = "Copy Image";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(765, 175);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(220, 189);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(765, 370);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(220, 189);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// FrmCam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1504, 606);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmCam";
			this.Text = "FrmCam";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCam_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgbCam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trkArea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem camToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Emgu.CV.UI.ImageBox imgbCam;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trkMax;
		private System.Windows.Forms.TrackBar trkMin;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trkArea;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}