using System;
using System.Windows.Forms;

namespace DetectFault
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
            Application.Run(new Frm_DetectFault());
        }

        #endregion
    }
}