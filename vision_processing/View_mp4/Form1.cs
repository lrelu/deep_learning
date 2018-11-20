using System;
using System.Windows.Forms;
using AForge.Video.FFMPEG;

namespace View_mp4
{
	public partial class Form1 : Form
	{
		VideoFileSource _source;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = @"C:\Temp";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					_source = new VideoFileSource(dialog.FileName);
					videoSourcePlayer1.VideoSource = _source;
					videoSourcePlayer1.Start();
				}
			}
		}
	}
}
