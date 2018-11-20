namespace Raw
{
	partial class FrmRaw
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.영상처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExpend = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuBinarization = new System.Windows.Forms.ToolStripMenuItem();
			this.picRaw = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRaw)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.영상처리ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(402, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 영상처리ToolStripMenuItem
			// 
			this.영상처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExpend,
            this.mnuBinarization});
			this.영상처리ToolStripMenuItem.Name = "영상처리ToolStripMenuItem";
			this.영상처리ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.영상처리ToolStripMenuItem.Text = "영상처리";
			// 
			// mnuExpend
			// 
			this.mnuExpend.Name = "mnuExpend";
			this.mnuExpend.Size = new System.Drawing.Size(216, 26);
			this.mnuExpend.Text = "확대";
			this.mnuExpend.Click += new System.EventHandler(this.mnuExpend_Click);
			// 
			// mnuBinarization
			// 
			this.mnuBinarization.Name = "mnuBinarization";
			this.mnuBinarization.Size = new System.Drawing.Size(216, 26);
			this.mnuBinarization.Text = "이진화";
			this.mnuBinarization.Click += new System.EventHandler(this.mnuBinarization_Click);
			// 
			// picRaw
			// 
			this.picRaw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picRaw.Location = new System.Drawing.Point(0, 28);
			this.picRaw.Name = "picRaw";
			this.picRaw.Size = new System.Drawing.Size(402, 480);
			this.picRaw.TabIndex = 1;
			this.picRaw.TabStop = false;
			// 
			// FrmRaw
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 508);
			this.Controls.Add(this.picRaw);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmRaw";
			this.Text = "FrmRaw";
			this.Load += new System.EventHandler(this.FrmRaw_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRaw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 영상처리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuExpend;
		private System.Windows.Forms.ToolStripMenuItem mnuBinarization;
		private System.Windows.Forms.PictureBox picRaw;
	}
}