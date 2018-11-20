using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace TestProject
{
	public partial class FrmCam : Form
	{
		private Capture _capture = null;
		private Capture _video = null;

		public FrmCam()
		{
			InitializeComponent();
		}

		private void _capture_ImageGrabbed(object sender, EventArgs e)
		{
			Image<Bgr, Byte> frame_normal = _capture.RetrieveBgrFrame();
			Image<Gray, Byte> frame_grayscale = frame_normal.Convert<Gray, Byte>();
			Image<Gray, Byte> frame_downscale = frame_grayscale.Convert<Gray, Byte>();
			Image<Gray, Byte> frame_upscale = frame_grayscale.Convert<Gray, Byte>();

			imgbCam.Image = frame_normal;
		}

		private void FrmCam_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (_capture != null)
				_capture.Dispose();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_capture == null)
			{
				_capture = new Capture();
				_capture.ImageGrabbed += _capture_ImageGrabbed;
			}

			_capture.Start();
			openToolStripMenuItem.Enabled = !openToolStripMenuItem.Enabled;
			pauseToolStripMenuItem.Enabled = !pauseToolStripMenuItem.Enabled;
		}

		private void openToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (_video == null)
			{
				using (OpenFileDialog dialog = new OpenFileDialog())
				{
					dialog.InitialDirectory = @"C:\Temp";
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						_video = new Capture(dialog.FileName);
						_video.ImageGrabbed += _video_ImageGrabbed;
					}
				}
			}

			_video.Start();
		}

		private void _video_ImageGrabbed(object sender, EventArgs e)
		{
			Image<Bgr, Byte> frame = _video.RetrieveBgrFrame();
			
			imgbCam.Image = frame;
		}

		private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_capture.Pause();
			openToolStripMenuItem.Enabled = !openToolStripMenuItem.Enabled;
			pauseToolStripMenuItem.Enabled = !pauseToolStripMenuItem.Enabled;
		}
	}
}
