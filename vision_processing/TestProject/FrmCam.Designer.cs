namespace TestProject
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
			this.imgbCam = new Emgu.CV.UI.ImageBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgbCam)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camToolStripMenuItem,
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(644, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// camToolStripMenuItem
			// 
			this.camToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem});
			this.camToolStripMenuItem.Name = "camToolStripMenuItem";
			this.camToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
			this.camToolStripMenuItem.Text = "Cam";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// pauseToolStripMenuItem
			// 
			this.pauseToolStripMenuItem.Enabled = false;
			this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
			this.pauseToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
			this.pauseToolStripMenuItem.Text = "Pause";
			this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// stopToolStripMenuItem
			// 
			this.stopToolStripMenuItem.Enabled = false;
			this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			this.stopToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
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
			this.openToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
			this.openToolStripMenuItem1.Text = "Open";
			this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
			// 
			// startToolStripMenuItem1
			// 
			this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
			this.startToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
			this.startToolStripMenuItem1.Text = "Start";
			// 
			// imgbCam
			// 
			this.imgbCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgbCam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imgbCam.Location = new System.Drawing.Point(0, 28);
			this.imgbCam.Margin = new System.Windows.Forms.Padding(0);
			this.imgbCam.Name = "imgbCam";
			this.imgbCam.Size = new System.Drawing.Size(644, 571);
			this.imgbCam.TabIndex = 2;
			this.imgbCam.TabStop = false;
			// 
			// FrmCam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 599);
			this.Controls.Add(this.imgbCam);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmCam";
			this.Text = "FrmCam";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCam_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgbCam)).EndInit();
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
		private Emgu.CV.UI.ImageBox imgbCam;
	}
}