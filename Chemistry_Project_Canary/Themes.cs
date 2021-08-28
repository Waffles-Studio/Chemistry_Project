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
    public partial class Themes : Form
    {
        public Themes()
        {
            InitializeComponent();

            //TEMA
            this.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            lab_Title.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Light.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting; ;
            btn_Light.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Dark.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting; ;
            btn_Dark.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
            {
                btn_Light.Image = Image.FromFile(@"TemaOscuro\round_wb_incandescent_white_18dp.png");
                btn_Dark.Image = Image.FromFile(@"TemaOscuro\round_brightness_4_white_18dp.png");            }


        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //REGRESAR FORMA
            Home fm = new Home();
            this.Close();
            fm.Show();
        }

        private void btn_Light_Click(object sender, EventArgs e)
        {
            Home fm = new Home();
            Chemistry_Project_Canary.Properties.Settings.Default["MyColorSetting"] = Color.White;//La propiedad 'MyColorSetting' cambia a blanco
            Chemistry_Project_Canary.Properties.Settings.Default["MyColorFS"] = Color.Black;//La propiedad 'MyColorFs' cambia a color negro
            Chemistry_Project_Canary.Properties.Settings.Default.Save();//Guarda las propiedades
            btn_Back_Click(sender, e);//Regresar a la forma principal
            
        }

        private void btn_Dark_Click(object sender, EventArgs e)
        {
            Home fm = new Home();
            Chemistry_Project_Canary.Properties.Settings.Default["MyColorSetting"] = Color.Black;//La propiedad 'MyColorSetting' cambia a negro
            Chemistry_Project_Canary.Properties.Settings.Default["MyColorFS"] = Color.White; //La propiedad 'MyColorFs' cambia a color blanco
            Chemistry_Project_Canary.Properties.Settings.Default.Save();//Guarda las propiedades
            btn_Back_Click(sender, e);//Regresar a la forma principal
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
