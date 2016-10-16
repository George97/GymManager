using System;
using System.Windows.Forms;

namespace GymManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frmLogin = new LoginForm();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Application.Run(new frmGymManager());
        }
    }
}
