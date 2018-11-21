using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace DetectFault
{
	public partial class Frm_DetectFault : Form
	{
		private Capture _cam = null;
		private Image<Bgr, Byte> _frame;

		private Timer _imageProcessor;

		public Frm_DetectFault()
		{
			// 디자이너 초기화
			InitializeComponent();

			// 자체 초기화
			Init();
		}

		private void Init()
		{
			// 타이머 생성
			_imageProcessor = new Timer();
			_imageProcessor.Interval = 1000;
			_imageProcessor.Tick += ImageProcessing;

			// 설정값 초기화
			trkThresh.Value = 180;
			trkThreshLinking.Value = 120;
			trkArea.Value = 300;
		}

		/// <summary>
		/// 1초마다 캠에서 나오는 이미지를 읽어서 분석함
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ImageProcessing(object sender, EventArgs e)
		{
			// 텍스트 추출하려고 했지만, 속도가 받추어지지 않아서 우선 기능 제거
			// 차후에 처리해야함: 영상 이미지는 뒤집어서 읽기 때문에 영문자가 틀린 부분을 보정해줘야함
			//rtxtResult.Text = OCR.GetTextfromImage(_frame.Bitmap);

			// 사각형 추출
			List<MCvBox2D> rectangles = ImageProcessor.GetRectangles(_frame, trkThresh.Value, trkThreshLinking.Value, trkArea.Value);

			// 사각형 그리기
			foreach (MCvBox2D rectangle in rectangles)
			{
				_frame.Draw(rectangle, new Bgr(Color.Blue), 3);
				Bitmap bitmap = new Bitmap((int)rectangle.size.Width, (int)rectangle.size.Height);
				using (Graphics g = Graphics.FromImage(bitmap))
				{
					
				}
			}

			// 원 추출
			CircleF[][] circles = ImageProcessor.GetCircles(_frame, trkThresh.Value, 180, 5);

			foreach (CircleF circle in circles[0])
			{
				_frame.Draw(circle, new Bgr(Color.Red), 3);
			}

			// 이미지 결과창에 노출
			imgbResult.Image = _frame;
		}

		/// <summary>
		/// 폼 닫을때 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Frm_DetectFault_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (_cam != null)
				_cam.Dispose();
		}

		private void Cam_ImageGrabbed(object sender, EventArgs e)
		{
			// 원본 프레임을 가져옴
			_frame = _cam.RetrieveBgrFrame();
			// 4도 변환
			Image<Gray, Byte> frame_grayscale = _frame.Convert<Gray, Byte>();
			// Down Up Sampling을 통해 잡음 제거
			Image<Gray, Byte> frame_downupSampling = frame_grayscale.PyrDown().PyrUp();
			// Canny Edge 
			Image<Gray, Byte> frame_canny = frame_downupSampling.Canny(trkThresh.Value, trkThreshLinking.Value);

			// 영상을 이미지 박스에 출력
			imgbCam.Image = _frame;
			imgbGrayscale.Image = frame_grayscale;
			imgbIDownUpSampling.Image = frame_downupSampling;
			imgbCannyEdge.Image = frame_canny;
		}

		private void mnuVisionOpen_Click(object sender, EventArgs e)
		{
			if (_cam == null)
			{
				// 캠 생성
				_cam = new Capture();
				//이미지 가져오는 함수 연결
				_cam.ImageGrabbed += Cam_ImageGrabbed;

				_cam.FlipHorizontal = !_cam.FlipHorizontal;
			}

			// 영상 시작 (Cam_ImageGrabbed 함수 비동기 시작)
			_cam.Start();

			// 영상 분석 시작
			_imageProcessor.Enabled = true;
		}

		private void mnuClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
