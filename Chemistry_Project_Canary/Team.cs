using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemistry_Project_Canary
{
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();

            //CAMBIA EL TEMA
            this.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            lab_Title.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;

            label1.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label4.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label3.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label5.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label6.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label9.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label7.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label10.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label11.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label8.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();//CERRAR
        }
    }
}
