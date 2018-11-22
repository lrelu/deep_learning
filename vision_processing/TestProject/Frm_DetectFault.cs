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
		private Image<Bgr, Byte> _file;

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

			lblAlarm.Text = string.Empty;
		}

		/// <summary>
		/// 1초마다 캠에서 나오는 이미지를 읽어서 분석함
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ImageProcessing(object sender, EventArgs e)
		{
			// 영상 분석이 체크되어 있어야만 분석 시작
			if (mnuStartImageprocessing.Checked == false)
				return;

			// 결과 초기화
			lblAlarm.Text = string.Empty;
			_imageProcessor.Interval = 1000;

			// 텍스트 추출하려고 했지만, 속도가 받추어지지 않아서 우선 기능 제거
			// 차후에 처리해야함: 영상 이미지는 뒤집어서 읽기 때문에 영문자가 틀린 부분을 보정해줘야함
			//rtxtResult.Text = OCR.GetTextfromImage(_frame.Bitmap);

			// 사각형 추출
			List<MCvBox2D> rectangles = ImageProcessor.GetRectangles(_frame, trkThresh.Value, trkThreshLinking.Value, trkArea.Value);

			// 사각형 그리기
			foreach (MCvBox2D rectangle in rectangles)
				_frame.Draw(rectangle, new Bgr(Color.Blue), 3);

			// 원 추출
			CircleF[][] circles = ImageProcessor.GetCircles(_frame, trkThresh.Value, 180, 5);

			foreach (CircleF circle in circles[0])
				_frame.Draw(circle, new Bgr(Color.Red), 3);

			if (circles[0].Length > 0)
			{
				lblAlarm.Text = "동그라미 검출";
				_imageProcessor.Interval = 3000;
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

			// 버튼 활성화
			mnuVisionPause.Enabled = true;
			mnuVisionClose.Enabled = true;
			mnuStartImageprocessing.Enabled = true;
			mnuVisionOpen.Enabled = false;
		}

		private void mnuLoadImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = @"C:\Temp\Images";

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					_file = new Image<Bgr, Byte>(new Bitmap(dialog.FileName));
					imgbResult.Image = _file;

					// 버튼 활성화
					mnuGetContour.Enabled = true;
					mnuGetLanes.Enabled = true;
					mnuOCR.Enabled = true;
					mnuBinarization.Enabled = true;
					mnuBinarywithGray.Enabled = true;
				}
			}
		}

		private void mnuGetContour_Click(object sender, EventArgs e)
		{
			// 원본사진을 유지하기 위해서 저장
			Image<Bgr, Byte> image = _file.Clone();

			// 사각형 추출
			List<MCvBox2D> rectangles = ImageProcessor.GetRectangles(image, trkThresh.Value, trkThreshLinking.Value, trkArea.Value);

			// 사각형 그리기
			foreach (MCvBox2D rectangle in rectangles)
				image.Draw(rectangle, new Bgr(Color.Blue), 3);

			// 결과 출력
			imgbResult.Image = image;
		}

		private void mnuOCR_Click(object sender, EventArgs e)
		{
			// 텍스트 추출
			Cursor.Current = Cursors.WaitCursor;
			rtxtResult.Text = OCR.GetTextfromImage(_file.Bitmap);
			Cursor.Current = Cursors.Default;
		}

		private void mnuImageProcessing_Click(object sender, EventArgs e)
		{
			// 메뉴 스트립 처리
			if (mnuImageProcessing.Checked)
				return;

			mnuImageProcessing.Checked = !mnuImageProcessing.Checked;
			mnuCnn.Checked = !mnuCnn.Checked;
		}

		private void mnuCnn_Click(object sender, EventArgs e)
		{
			// 메뉴 스트립 처리
			if (mnuCnn.Checked)
				return;

			mnuCnn.Checked = !mnuCnn.Checked;
			mnuImageProcessing.Checked = !mnuImageProcessing.Checked;
		}

		private void mnuBinarization_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			// 배운 내용을 복습하기 위한 Raw데이터를 하나씩 꺼내어 이진화
			Bitmap inImage = (Bitmap)_file.Bitmap.Clone();

			// 이진화 진행
			inImage = ImageProcessor.Binarization(inImage, trkThresh.Value);

			// 해당 이미지 출력
			imgbResult.Image = new Image<Bgr, Byte>(inImage);
			Cursor.Current = Cursors.Default;
		}
  
		private void mnuClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mnuCapture_Click(object sender, EventArgs e)
		{
			// 영상 캡쳐
			imgbResult.Image = _frame;

			// 버튼 활성화
			mnuGetContour.Enabled = true;
			mnuGetLanes.Enabled = true;
			mnuOCR.Enabled = true;
			mnuBinarization.Enabled = true;
			mnuBinarywithGray.Enabled = true;
		}

		private void mnuStartImageprocessing_Click(object sender, EventArgs e)
		{
			mnuStartImageprocessing.Checked = !mnuStartImageprocessing.Checked;
		}

		private void mnuBinarywithGray_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			// 배운 내용을 복습하기 위한 Raw데이터를 하나씩 꺼내어 이진화
			Bitmap inImage = (Bitmap)_file.Bitmap.Clone();

			// 칼라사진을 바로 이진화 하니까 원하지 않은 결과를 가지고 오기 때문에 그레이 스케일로 변경하였다가, 이진화 진행함
			double[] threshs = { 0.2989, 0.5870, 0.1140 };
			inImage = ImageProcessor.Graysacle(inImage, threshs);

			// 이진화 진행
			inImage = ImageProcessor.Binarization(inImage, trkThresh.Value);

			// 해당 이미지 출력
			imgbResult.Image = new Image<Bgr, Byte>(inImage);
			Cursor.Current = Cursors.Default;
		}
	}
}
