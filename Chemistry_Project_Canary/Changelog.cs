using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chemistry_Project_Canary
{
    public partial class Changelog : Form
    {

        public Changelog()
        {
            InitializeComponent();
            //CAMBIAR TEMA
            this.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            lab_Title.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            listBox1.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            listBox1.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
            {
                btn_Okay.Image = Image.FromFile(@"TemaOscuro\round_thumb_up_white_18dp.png");
                btn_Okay.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
                btn_Okay.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            }
            else
            {
            }
        }

        private void btn_Okay_Click(object sender, EventArgs e)
        {
            //CERRAR APLICACION
            this.Close();
        }
    }
}
