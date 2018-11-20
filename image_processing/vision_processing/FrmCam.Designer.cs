namespace vision_processing
{
	partial class FrmCam
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.imgbCamera = new Emgu.CV.UI.ImageBox();
			this.imgbGrayscale = new Emgu.CV.UI.ImageBox();
			this.imgbRemovingNoise = new Emgu.CV.UI.ImageBox();
			this.imgbCannyEdge = new Emgu.CV.UI.ImageBox();
			this.btnLoadCamera = new System.Windows.Forms.Button();
			this.btnToGrayscale = new System.Windows.Forms.Button();
			this.btnRemoving = new System.Windows.Forms.Button();
			this.btnCannyEdge = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imgbCamera)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgbGrayscale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgbRemovingNoise)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgbCannyEdge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// imgbCamera
			// 
			this.imgbCamera.Location = new System.Drawing.Point(12, 113);
			this.imgbCamera.Name = "imgbCamera";
			this.imgbCamera.Size = new System.Drawing.Size(364, 274);
			this.imgbCamera.TabIndex = 2;
			this.imgbCamera.TabStop = false;
			// 
			// imgbGrayscale
			// 
			this.imgbGrayscale.Location = new System.Drawing.Point(382, 113);
			this.imgbGrayscale.Name = "imgbGrayscale";
			this.imgbGrayscale.Size = new System.Drawing.Size(364, 274);
			this.imgbGrayscale.TabIndex = 2;
			this.imgbGrayscale.TabStop = false;
			// 
			// imgbRemovingNoise
			// 
			this.imgbRemovingNoise.Location = new System.Drawing.Point(752, 113);
			this.imgbRemovingNoise.Name = "imgbRemovingNoise";
			this.imgbRemovingNoise.Size = new System.Drawing.Size(364, 274);
			this.imgbRemovingNoise.TabIndex = 2;
			this.imgbRemovingNoise.TabStop = false;
			// 
			// imgbCannyEdge
			// 
			this.imgbCannyEdge.Location = new System.Drawing.Point(1122, 113);
			this.imgbCannyEdge.Name = "imgbCannyEdge";
			this.imgbCannyEdge.Size = new System.Drawing.Size(364, 274);
			this.imgbCannyEdge.TabIndex = 2;
			this.imgbCannyEdge.TabStop = false;
			// 
			// btnLoadCamera
			// 
			this.btnLoadCamera.Location = new System.Drawing.Point(12, 12);
			this.btnLoadCamera.Name = "btnLoadCamera";
			this.btnLoadCamera.Size = new System.Drawing.Size(364, 95);
			this.btnLoadCamera.TabIndex = 3;
			this.btnLoadCamera.Text = "Load Camera";
			this.btnLoadCamera.UseVisualStyleBackColor = true;
			this.btnLoadCamera.Click += new System.EventHandler(this.btnLoadCamera_Click);
			// 
			// btnToGrayscale
			// 
			this.btnToGrayscale.Location = new System.Drawing.Point(382, 12);
			this.btnToGrayscale.Name = "btnToGrayscale";
			this.btnToGrayscale.Size = new System.Drawing.Size(364, 95);
			this.btnToGrayscale.TabIndex = 3;
			this.btnToGrayscale.Text = "To Grayscale";
			this.btnToGrayscale.UseVisualStyleBackColor = true;
			// 
			// btnRemoving
			// 
			this.btnRemoving.Location = new System.Drawing.Point(752, 12);
			this.btnRemoving.Name = "btnRemoving";
			this.btnRemoving.Size = new System.Drawing.Size(364, 95);
			this.btnRemoving.TabIndex = 3;
			this.btnRemoving.Text = "Removing Noise";
			this.btnRemoving.UseVisualStyleBackColor = true;
			// 
			// btnCannyEdge
			// 
			this.btnCannyEdge.Location = new System.Drawing.Point(1121, 12);
			this.btnCannyEdge.Name = "btnCannyEdge";
			this.btnCannyEdge.Size = new System.Drawing.Size(364, 95);
			this.btnCannyEdge.TabIndex = 3;
			this.btnCannyEdge.Text = "To Canny Edge";
			this.btnCannyEdge.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 393);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(364, 316);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// FrmCam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1497, 721);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCannyEdge);
			this.Controls.Add(this.btnRemoving);
			this.Controls.Add(this.btnToGrayscale);
			this.Controls.Add(this.btnLoadCamera);
			this.Controls.Add(this.imgbCannyEdge);
			this.Controls.Add(this.imgbRemovingNoise);
			this.Controls.Add(this.imgbGrayscale);
			this.Controls.Add(this.imgbCamera);
			this.Name = "FrmCam";
			this.Text = "Vision Processing with Emgu";
			((System.ComponentModel.ISupportInitialize)(this.imgbCamera)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgbGrayscale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgbRemovingNoise)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgbCannyEdge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Emgu.CV.UI.ImageBox imgbCamera;
		private Emgu.CV.UI.ImageBox imgbGrayscale;
		private Emgu.CV.UI.ImageBox imgbRemovingNoise;
		private Emgu.CV.UI.ImageBox imgbCannyEdge;
		private System.Windows.Forms.Button btnLoadCamera;
		private System.Windows.Forms.Button btnToGrayscale;
		private System.Windows.Forms.Button btnRemoving;
		private System.Windows.Forms.Button btnCannyEdge;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

