using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;

namespace vision_processing
{
	public partial class FrmCam : Form
	{
		//private VideoCapture _capture = null;
		private Image<Bgr, byte> current;
		private VideoCapture video;

		public FrmCam()
		{
			InitializeComponent();
			
		}

		private async void btnLoadCamera_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = @"C:\Temp";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					video = new VideoCapture(dialog.FileName);
					//Mat mat = new Mat();
					//video.Read(mat);
					//pictureBox1.Image = mat.Bitmap;

					try
					{
						while (true)
						{
							Mat m = new Mat();
							video.Read(m);

							if (!m.IsEmpty)
							{
								pictureBox1.Image = m.Bitmap;
								double fps = video.GetCaptureProperty(CapProp.Fps);
								await Task.Delay((int)(1000/fps));
							}
							else
							{
								break;
							}
								
						}
					}
					catch (Exception ex)
					{

					}

				}
			}
		}

		private void ProcessCamera(object sender, EventArgs e)
		{

		}
	}
}
