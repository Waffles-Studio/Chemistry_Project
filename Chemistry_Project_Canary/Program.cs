using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemistry_Project_Canary
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Home main = new Home();
            Splash sp = new Splash();
            if (sp.ShowDialog() == DialogResult.OK)
            {
                main.Show();
                Application.Run();
            }
        }
    }
}
