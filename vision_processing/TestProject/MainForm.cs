using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace TestProject
{
    /// <summary>
    /// 메인 폼
    /// </summary>
    public partial class MainForm : Form
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 캡처
        /// </summary>
        private Capture capture = null;

        /// <summary>
        /// 캡처 여부
        /// </summary>
        private bool isCapturing;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - MainForm()

        /// <summary>
        /// 생성자
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            try
            {
                this.capture = new Capture();

                this.capture.ImageGrabbed += capture_ImageGrabbed;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            FormClosed                      += Form_FormClosed;
            this.captureButton.Click        += captureButtonClick;
            this.flipHorizontalButton.Click += flipHorizontalButton_Click;
            this.flipVerticalButton.Click   += flipVerticalButton_Click;
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Private
        //////////////////////////////////////////////////////////////////////////////// Event

        #region 폼 닫는 경우 처리하기 - Form_FormClosed(sender, e)

        /// <summary>
        /// 폼 닫는 경우 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.capture != null)
            {
                this.capture.Dispose();
            }
        }

        #endregion

        #region 캡처 이미지 GRAB 처리하기 - capture_ImageGrabbed(sender, e)

        /// <summary>
        /// 캡처 이미지 GRAB 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void capture_ImageGrabbed(object sender, EventArgs e)
        {
            Image<Bgr, Byte> captureImage = this.capture.RetrieveBgrFrame();

            Image<Gray, Byte> grayscaleImage           = captureImage.Convert<Gray, Byte>();
            Image<Gray, Byte> downSampleGrayscaleImage = grayscaleImage.PyrDown();
            Image<Gray, Byte> upSampleGrayscaleImage   = downSampleGrayscaleImage.PyrUp();
            Image<Gray, Byte> cannyImage               = upSampleGrayscaleImage.Canny(100, 60);

            this.captureImageBox.Image            = captureImage;
            this.grayscaleImageBox.Image          = grayscaleImage;
            this.GrayscaleSmoothingImageBox.Image = upSampleGrayscaleImage;
            this.cannyImageBox.Image              = cannyImage;
        }

        #endregion

        #region 캡처 버튼 클릭시 처리하기 - captureButtonClick(sender, e)

        /// <summary>
        /// 캡처 버튼 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void captureButtonClick(object sender, EventArgs e)
        {
            if(this.capture != null)
            {
                if(this.isCapturing)
                {
                    this.captureButton.Text = "캡처 시작";

                    this.capture.Pause();
                }
                else
                {
                    this.captureButton.Text = "캡처 중단";

                    this.capture.Start();
                }

                this.isCapturing = !this.isCapturing;
            }
        }

        #endregion
        #region 수평 반전 버튼 클릭시 처리하기 - flipHorizontalButton_Click(sender, e)

        /// <summary>
        /// 수평 반전 버튼 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void flipHorizontalButton_Click(object sender, EventArgs e)
        {
            if(this.capture != null)
            {
                this.capture.FlipHorizontal = !this.capture.FlipHorizontal;
            }
        }

        #endregion
        #region 수직 반전 버튼 클릭시 처리하기 - flipVerticalButton_Click(sender, e)

        /// <summary>
        /// 수직 반전 버튼 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void flipVerticalButton_Click(object sender, EventArgs e)
        {
            if(this.capture != null)
            {
                this.capture.FlipVertical = !this.capture.FlipVertical;
            }
        }

        #endregion
    }
}