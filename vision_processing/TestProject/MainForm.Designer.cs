namespace TestProject
{
    partial class MainForm
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
            this.flipVerticalButton = new System.Windows.Forms.Button();
            this.flipHorizontalButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.captureImageLabel = new System.Windows.Forms.Label();
            this.GrayscaleSmoothingImageBox = new Emgu.CV.UI.ImageBox();
            this.grayscaleSmoothingImageLabel = new System.Windows.Forms.Label();
            this.grayscaleImageBox = new Emgu.CV.UI.ImageBox();
            this.grayscaleImageLabel = new System.Windows.Forms.Label();
            this.cannyImageBox = new Emgu.CV.UI.ImageBox();
            this.cannyEdgeImageLabel = new System.Windows.Forms.Label();
            this.rootTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.controlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayscaleSmoothingImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyImageBox)).BeginInit();
            this.rootTableLayoutPanel.SuspendLayout();
            this.controlTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flipVerticalButton
            // 
            this.flipVerticalButton.Location = new System.Drawing.Point(220, 0);
            this.flipVerticalButton.Margin = new System.Windows.Forms.Padding(0);
            this.flipVerticalButton.Name = "flipVerticalButton";
            this.flipVerticalButton.Size = new System.Drawing.Size(100, 30);
            this.flipVerticalButton.TabIndex = 2;
            this.flipVerticalButton.Text = "수직 반전";
            this.flipVerticalButton.UseVisualStyleBackColor = true;
            // 
            // flipHorizontalButton
            // 
            this.flipHorizontalButton.Location = new System.Drawing.Point(110, 0);
            this.flipHorizontalButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flipHorizontalButton.Name = "flipHorizontalButton";
            this.flipHorizontalButton.Size = new System.Drawing.Size(100, 30);
            this.flipHorizontalButton.TabIndex = 1;
            this.flipHorizontalButton.Text = "수평 반전";
            this.flipHorizontalButton.UseVisualStyleBackColor = true;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(0, 0);
            this.captureButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(100, 30);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "캡처 시작";
            this.captureButton.UseVisualStyleBackColor = true;
            // 
            // captureImageBox
            // 
            this.captureImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captureImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureImageBox.Location = new System.Drawing.Point(0, 65);
            this.captureImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(384, 228);
            this.captureImageBox.TabIndex = 1;
            this.captureImageBox.TabStop = false;
            // 
            // captureImageLabel
            // 
            this.captureImageLabel.Location = new System.Drawing.Point(0, 40);
            this.captureImageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.captureImageLabel.Name = "captureImageLabel";
            this.captureImageLabel.Size = new System.Drawing.Size(200, 25);
            this.captureImageLabel.TabIndex = 0;
            this.captureImageLabel.Text = "캡처 이미지";
            this.captureImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrayscaleSmoothingImageBox
            // 
            this.GrayscaleSmoothingImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrayscaleSmoothingImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrayscaleSmoothingImageBox.Location = new System.Drawing.Point(0, 323);
            this.GrayscaleSmoothingImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.GrayscaleSmoothingImageBox.Name = "GrayscaleSmoothingImageBox";
            this.GrayscaleSmoothingImageBox.Size = new System.Drawing.Size(384, 228);
            this.GrayscaleSmoothingImageBox.TabIndex = 1;
            this.GrayscaleSmoothingImageBox.TabStop = false;
            // 
            // grayscaleSmoothingImageLabel
            // 
            this.grayscaleSmoothingImageLabel.Location = new System.Drawing.Point(0, 298);
            this.grayscaleSmoothingImageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.grayscaleSmoothingImageLabel.Name = "grayscaleSmoothingImageLabel";
            this.grayscaleSmoothingImageLabel.Size = new System.Drawing.Size(200, 25);
            this.grayscaleSmoothingImageLabel.TabIndex = 0;
            this.grayscaleSmoothingImageLabel.Text = "회색조 스무딩 이미지";
            this.grayscaleSmoothingImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grayscaleImageBox
            // 
            this.grayscaleImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grayscaleImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayscaleImageBox.Location = new System.Drawing.Point(389, 65);
            this.grayscaleImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.grayscaleImageBox.Name = "grayscaleImageBox";
            this.grayscaleImageBox.Size = new System.Drawing.Size(385, 228);
            this.grayscaleImageBox.TabIndex = 1;
            this.grayscaleImageBox.TabStop = false;
            // 
            // grayscaleImageLabel
            // 
            this.grayscaleImageLabel.Location = new System.Drawing.Point(389, 40);
            this.grayscaleImageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.grayscaleImageLabel.Name = "grayscaleImageLabel";
            this.grayscaleImageLabel.Size = new System.Drawing.Size(200, 25);
            this.grayscaleImageLabel.TabIndex = 1;
            this.grayscaleImageLabel.Text = "회색조 이미지";
            this.grayscaleImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cannyImageBox
            // 
            this.cannyImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cannyImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cannyImageBox.Location = new System.Drawing.Point(389, 323);
            this.cannyImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.cannyImageBox.Name = "cannyImageBox";
            this.cannyImageBox.Size = new System.Drawing.Size(385, 228);
            this.cannyImageBox.TabIndex = 1;
            this.cannyImageBox.TabStop = false;
            // 
            // cannyEdgeImageLabel
            // 
            this.cannyEdgeImageLabel.Location = new System.Drawing.Point(389, 298);
            this.cannyEdgeImageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cannyEdgeImageLabel.Name = "cannyEdgeImageLabel";
            this.cannyEdgeImageLabel.Size = new System.Drawing.Size(200, 25);
            this.cannyEdgeImageLabel.TabIndex = 0;
            this.cannyEdgeImageLabel.Text = "캐니 엣지 추출 이미지";
            this.cannyEdgeImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rootTableLayoutPanel
            // 
            this.rootTableLayoutPanel.ColumnCount = 3;
            this.rootTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.rootTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootTableLayoutPanel.Controls.Add(this.cannyImageBox, 2, 5);
            this.rootTableLayoutPanel.Controls.Add(this.cannyEdgeImageLabel, 2, 4);
            this.rootTableLayoutPanel.Controls.Add(this.GrayscaleSmoothingImageBox, 0, 5);
            this.rootTableLayoutPanel.Controls.Add(this.grayscaleSmoothingImageLabel, 0, 4);
            this.rootTableLayoutPanel.Controls.Add(this.grayscaleImageBox, 2, 2);
            this.rootTableLayoutPanel.Controls.Add(this.captureImageBox, 0, 2);
            this.rootTableLayoutPanel.Controls.Add(this.controlTableLayoutPanel, 0, 0);
            this.rootTableLayoutPanel.Controls.Add(this.captureImageLabel, 0, 1);
            this.rootTableLayoutPanel.Controls.Add(this.grayscaleImageLabel, 2, 1);
            this.rootTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTableLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.rootTableLayoutPanel.Name = "rootTableLayoutPanel";
            this.rootTableLayoutPanel.RowCount = 6;
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootTableLayoutPanel.Size = new System.Drawing.Size(774, 551);
            this.rootTableLayoutPanel.TabIndex = 1;
            // 
            // controlTableLayoutPanel
            // 
            this.controlTableLayoutPanel.ColumnCount = 4;
            this.rootTableLayoutPanel.SetColumnSpan(this.controlTableLayoutPanel, 3);
            this.controlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.controlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlTableLayoutPanel.Controls.Add(this.flipVerticalButton, 2, 0);
            this.controlTableLayoutPanel.Controls.Add(this.captureButton, 0, 0);
            this.controlTableLayoutPanel.Controls.Add(this.flipHorizontalButton, 1, 0);
            this.controlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.controlTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.controlTableLayoutPanel.Name = "controlTableLayoutPanel";
            this.controlTableLayoutPanel.RowCount = 1;
            this.controlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.controlTableLayoutPanel.Size = new System.Drawing.Size(774, 40);
            this.controlTableLayoutPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rootTableLayoutPanel);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 12F);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "카메라 캡처하기";
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayscaleSmoothingImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyImageBox)).EndInit();
            this.rootTableLayoutPanel.ResumeLayout(false);
            this.controlTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Label captureImageLabel;
        private System.Windows.Forms.Label grayscaleImageLabel;
        private System.Windows.Forms.Button flipHorizontalButton;
        private System.Windows.Forms.Button flipVerticalButton;
        private System.Windows.Forms.Label grayscaleSmoothingImageLabel;
        private System.Windows.Forms.Label cannyEdgeImageLabel;
        private Emgu.CV.UI.ImageBox captureImageBox;
        private Emgu.CV.UI.ImageBox grayscaleImageBox;
        private Emgu.CV.UI.ImageBox GrayscaleSmoothingImageBox;
        private Emgu.CV.UI.ImageBox cannyImageBox;
        private System.Windows.Forms.TableLayoutPanel rootTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel controlTableLayoutPanel;
    }
}

