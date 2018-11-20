using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Raw
{
	public partial class FrmRaw : Form
	{
		private byte[,] _inImage;		private byte[,] _outImage;
		private int _width;		private int _height;

		public FrmRaw()
		{
			InitializeComponent();
		}

		private void FrmRaw_Load(object sender, EventArgs e)
		{
			// 이미지 불러오기
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = @"C:\Temp\Pet_RAW";
				dialog.Filter = "Raw Image|*.raw;";

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					// 가로세로 계산
					_width = _height = (int)Math.Sqrt((double)(new FileInfo(dialog.FileName)).Length);
					_inImage = new byte[_height, _width];

					// 이미지를 읽어서 배열에 저장
					using (BinaryReader br = new BinaryReader(new FileStream(dialog.FileName, FileMode.Open)))
					{
						for (int i = 0; i < _height; i++)
							for (int k = 0; k < _width; k++)
								_inImage[k, i] = br.ReadByte();
					}

					// 화면에 출력
					_outImage = (byte[,])_inImage.Clone();
					Display(_width, _height);
				}
			}
		}

		private void Display(int height, int width)
		{
			// byte[,] -> picturebox
			Bitmap bitmap = new Bitmap(height, width);
			for (int i = 0; i < height; i++)
				for (int k = 0; k < width; k++)
					bitmap.SetPixel(i, k, Color.FromArgb(_outImage[i, k], _outImage[i, k], _outImage[i, k]));

			picRaw.Image = bitmap;
			this.Size = new Size(width + 10, height + 55);
		}

		private void mnuExpend_Click(object sender, EventArgs e)
		{
			// 확대 (원본 이미지에서 확대)
			int outH = _height * 2;
			int outW = _width * 2;
			_outImage = new byte[outH, outW];

			// Backwarding으로 아웃에서 원본의 화소(n/2)를 읽어옴
			for (int i = 0; i < outH; i++)
				for (int k = 0; k < outW; k++)
					_outImage[i, k] = _inImage[i / 2, k / 2];

			Display(outH, outW);
		}

		private void mnuBinarization_Click(object sender, EventArgs e)
		{
			// 이진화 (원본 이미지에서 123화소를 기준으로 이진화)
			for (int i = 0; i < _height; i++)
				for (int k = 0; k < _width; k++)
					_outImage[i, k] = (int)_inImage[i, k] > 122 ? (byte)255 : (byte)0;

			Display(_height, _width);
		}
	}
}
