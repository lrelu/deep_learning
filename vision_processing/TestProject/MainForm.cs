using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace TestProject
{
    /// <summary>
    /// ���� ��
    /// </summary>
    public partial class MainForm : Form
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// ĸó
        /// </summary>
        private Capture capture = null;

        /// <summary>
        /// ĸó ����
        /// </summary>
        private bool isCapturing;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region ������ - MainForm()

        /// <summary>
        /// ������
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

        #region �� �ݴ� ��� ó���ϱ� - Form_FormClosed(sender, e)

        /// <summary>
        /// �� �ݴ� ��� ó���ϱ�
        /// </summary>
        /// <param name="sender">�̺�Ʈ �߻���</param>
        /// <param name="e">�̺�Ʈ ����</param>
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.capture != null)
            {
                this.capture.Dispose();
            }
        }

        #endregion

        #region ĸó �̹��� GRAB ó���ϱ� - capture_ImageGrabbed(sender, e)

        /// <summary>
        /// ĸó �̹��� GRAB ó���ϱ�
        /// </summary>
        /// <param name="sender">�̺�Ʈ �߻���</param>
        /// <param name="e">�̺�Ʈ ����</param>
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

        #region ĸó ��ư Ŭ���� ó���ϱ� - captureButtonClick(sender, e)

        /// <summary>
        /// ĸó ��ư Ŭ���� ó���ϱ�
        /// </summary>
        /// <param name="sender">�̺�Ʈ �߻���</param>
        /// <param name="e">�̺�Ʈ ����</param>
        private void captureButtonClick(object sender, EventArgs e)
        {
            if(this.capture != null)
            {
                if(this.isCapturing)
                {
                    this.captureButton.Text = "ĸó ����";

                    this.capture.Pause();
                }
                else
                {
                    this.captureButton.Text = "ĸó �ߴ�";

                    this.capture.Start();
                }

                this.isCapturing = !this.isCapturing;
            }
        }

        #endregion
        #region ���� ���� ��ư Ŭ���� ó���ϱ� - flipHorizontalButton_Click(sender, e)

        /// <summary>
        /// ���� ���� ��ư Ŭ���� ó���ϱ�
        /// </summary>
        /// <param name="sender">�̺�Ʈ �߻���</param>
        /// <param name="e">�̺�Ʈ ����</param>
        private void flipHorizontalButton_Click(object sender, EventArgs e)
        {
            if(this.capture != null)
            {
                this.capture.FlipHorizontal = !this.capture.FlipHorizontal;
            }
        }

        #endregion
        #region ���� ���� ��ư Ŭ���� ó���ϱ� - flipVerticalButton_Click(sender, e)

        /// <summary>
        /// ���� ���� ��ư Ŭ���� ó���ϱ�
        /// </summary>
        /// <param name="sender">�̺�Ʈ �߻���</param>
        /// <param name="e">�̺�Ʈ ����</param>
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