using System;
using System.Windows.Forms;

namespace TestProject
{
    /// <summary>
    /// ���α׷�
    /// </summary>
    class Program
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Private

        #region ���α׷� �����ϱ� - Main()

        /// <summary>
        /// ���α׷� �����ϱ�
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCam());
        }

        #endregion
    }
}