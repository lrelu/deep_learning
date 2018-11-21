using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace DetectFault
{
	public partial class FrmCam : Form
	{
		private Capture _capture = null;
		private Capture _video = null;
		private bool _isCanny = false;
		private Image<Bgr, Byte> _frame;
		private Image<Gray, Byte> _output;

		public FrmCam()
		{
			InitializeComponent();

			trkMin.Value = 180;
			trkMax.Value = 120;
			trkArea.Value = 2000;
		}

		private void _capture_ImageGrabbed(object sender, EventArgs e)
		{
			Image<Bgr, Byte> frame_normal = _capture.RetrieveBgrFrame();
			Image<Gray, Byte> frame_grayscale = frame_normal.Convert<Gray, Byte>();
			Image<Gray, Byte> frame_downscale = frame_grayscale.PyrDown();
			Image<Gray, Byte> frame_upsacle = frame_downscale.PyrUp();
			Image<Gray, Byte> frame_canny = frame_upsacle.Canny(trkMin.Value, trkMax.Value);

			if (_isCanny)
				imgbCam.Image = frame_canny;
			else
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

				_capture.FlipHorizontal = !_capture.FlipHorizontal;
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

		private void originalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_isCanny = false;
		}

		private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_isCanny = true;
		}

		private void flipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_capture != null)
				_capture.FlipHorizontal = !_capture.FlipHorizontal;
		}

		private void captureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_capture != null)
			{
				Image<Bgr, Byte> frame = _capture.QueryFrame();

				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox1.Image = frame.Bitmap;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (_capture != null)
			{
				_frame = _capture.QueryFrame();
				
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox1.Image = _frame.Bitmap;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_output = _frame.Convert<Gray, Byte>();

			pictureBox1.Image = _output.Bitmap;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			_output = _output.PyrDown();

			pictureBox1.Image = _output.Bitmap;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			_output = _output.PyrUp();

			pictureBox1.Image = _output.Bitmap;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			_output = _output.Canny(trkMin.Value, trkMax.Value);

			pictureBox1.Image = _output.Bitmap;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Image<Gray, Byte> grayscaleImage = _output;

			double cannyThreshold = 180.0;
			double circleAccumulatorThreshold = 120;

			CircleF[][] circleArray = grayscaleImage.HoughCircles
			(
				new Gray(cannyThreshold),
				new Gray(circleAccumulatorThreshold),
				2.0,  // 원 중심 검출에 사용되는 누산기 해상도
				20.0, // 최소 거리
				5,    // 최소 반경
				0     // 최대 반경
			);

			Image<Bgr, Byte> temp = _output.Convert<Bgr, Byte>();

			foreach (CircleF circle in circleArray[0])
			{
				temp.Draw(circle, new Bgr(Color.Red), 3);
			}

			this.pictureBox1.Image = temp.Bitmap;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = @"C:\Temp\Images";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					pictureBox2.Image = Image.FromFile(dialog.FileName);
				}
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			// 이미지에서 라인 빼오기
			Image<Bgr, Byte> temp = new Image<Bgr, byte>(new Bitmap(this.pictureBox2.Image));

			// 이미지 프로세싱 (업 다운 샘플링으로 영상의 잡음 제거)
			Image<Gray, Byte> tempGray = temp.Convert<Gray, Byte>().PyrDown().PyrUp();

			// 캐니 엣지 후 허프 알고리즘으로 라인 검출
			Image<Gray, Byte> tempCanny = tempGray.Canny(trkMin.Value, trkMax.Value);

			LineSegment2D[][] lineArray = tempCanny.HoughLinesBinary
				(
					1,              // 거리 해상도 (픽셀 관련 단위)
					Math.PI / 45.0, // 라디안으로 측정되는 각도 해상도
					20,             // 한계점
					30,             // 최소 선 너비
					10              // 선간 간격
				);

			// 선 출력
			foreach (LineSegment2D line in lineArray[0])
			{
				temp.Draw(line, new Bgr(Color.Green), 2);
			}

			this.pictureBox2.Image = temp.Bitmap;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			// 이미지에서 라인 빼오기
			Image<Bgr, Byte> temp = new Image<Bgr, byte>(new Bitmap(this.pictureBox2.Image));

			// 이미지 프로세싱 (업 다운 샘플링으로 영상의 잡음 제거)
			Image<Gray, Byte> tempGray = temp.Convert<Gray, Byte>().PyrDown().PyrUp();

			// 캐니 엣지
			Image<Gray, Byte> tempCanny = tempGray.Canny(trkMin.Value, trkMax.Value);

			// 사격형 추출
			List<MCvBox2D> rectangles = new List<MCvBox2D>();

			// 해당 영역의 이미지를 추출하기 위해서 임시 Rectangle 객체 생성
			Rectangle r = new Rectangle();

			// 메모리 객체를 생성
			using (MemStorage storage = new MemStorage())
			{
				// 캐니엣지된 이미지에서 윤곽선 포인트를 추출함
				Contour<Point> contours = tempCanny.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
																													Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_CCOMP,
																													storage);

				// 윤곽선 가져있는 객체에서 검색
				for (; contours != null; contours = contours.HNext)
				{
					// 현재 윤곽선을 가지고 옴
					Contour<Point> contour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);
					
					// 영역이 일정 크기 이상을 가지고 옴
					if (contour.Area > trkArea.Value)
					{
						// 포인트 점이 4개일 경우 (사각형이란 의미)
						if (contour.Total == 4)
						{
							// 윤곽의 각도를 분석
							bool isRectecgle = true;

							Point[] points = contour.ToArray();
							LineSegment2D[] vertices = PointCollection.PolyLine(points, true);

							for (int i = 0; i < vertices.Length; i++)
							{
								double angle = Math.Abs(vertices[(i + 1) % vertices.Length].GetExteriorAngleDegree(vertices[i]));

								// 하나의 각도가 80도보다 작거나 100도를 넘으면 사각형으로 보지 않고 바로 그만둠
								if (angle < 80 || angle > 100)
								{
									isRectecgle = false;
									break;
								}
							}

							if (isRectecgle) {
								rectangles.Add(contour.GetMinAreaRect());
								r.Location = points[0];
								r.Size = rectangles[0].size.ToSize();
							}
						}
					}
				}
			}

			MessageBox.Show("Rectecgle: " + rectangles.Count.ToString());

			// 사각형 그리기
			foreach (MCvBox2D rectacgle in rectangles)
			{
				temp.Draw(rectacgle, new Bgr(Color.Blue), 3);
				Bitmap bitmap = new Bitmap((int)rectacgle.size.Width, (int)rectacgle.size.Height);
				using (Graphics g = Graphics.FromImage(bitmap))
				{
					//g.DrawImage(temp.Bitmap, r.Location.X, r.Location.Y, r, GraphicsUnit.Pixel); 
					//g.DrawImage()
				}

				pictureBox3.Image = bitmap;
			}

			pictureBox2.Image = temp.Bitmap;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.pictureBox2.Image = (Image)this.pictureBox1.Image.Clone();  
		}
	}
}