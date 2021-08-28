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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            //EMPIEZA EL TIMER
            Tiempo.Stop();//TERMONA EL TIMER
            this.DialogResult = DialogResult.OK;//MANDA EL VALOR OK PARA QUE EMPIEZE LA FOMRA PRINCIPAL
            this.Close();//CIERRA LA FORMA DE CARGA
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Icono\Load_03.gif");//CARGA EL GIF DE CARGA
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//CAMBIA EL TAMAÑO DEL GIF

            
        }
    }
}
