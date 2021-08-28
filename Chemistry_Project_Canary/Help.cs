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
    public partial class Help : Form
    {
        int a=0;
        public Help()
        {
            InitializeComponent();

            //CAMBIAR TEMA
            this.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            lab_Title.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label1.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
            {
                //CAMBIAR IMAGENES
                btn_Next.Image = Image.FromFile(@"TemaOscuro\round_arrow_forward_ios_white_18dp.png");
                btn_Next.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            }
            pictureBox1.Image = Image.FromFile(@"Tutorial\001.png");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //CERRAR APLICAION
            this.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //CAMBIAR IMAGEN CON LOS BOTONES SIGUIENTE Y ATRAS
            a++;//AUEMNTA EL NUMERO QUE ES EL DE LA IMAGEN
            if (a == 0)
            {
                pictureBox1.Image = Image.FromFile(@"Tutorial\001.png");//CAMBIAR IMAGEN
                label1.Text = "1. Ingrese el nombre del elemento en \nla barra de búsqueda.";//CAMBIAR LABEL
            }
            if (a==1)
            {
                pictureBox1.Image = Image.FromFile(@"Tutorial\002.png");
                label1.Text = "2. Puede seleccionar el tipo de filtro \nen el botón de filtro.";
            }
            if (a==2)
            {
                pictureBox1.Image = Image.FromFile(@"Tutorial\003.png");
                label1.Text = "3. Para reproducir música en necesario \nañadirla detu biblioteca.";
            }
            if (a==3)
            {
                pictureBox1.Image = Image.FromFile(@"Tutorial\004.png");
                label1.Text = "4. Para utilizar la tabla basta con darle \nclick al elemnto que seleccione.";
            }
            if (a > 3)
            {
                //NO DEJA QUE AUMENTE A MAS DE 3
                a = 3;
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            //CAMBIAR IMAGEN CON LOS BOTONES SIGUIENTE Y ATRAS
            a--;//SIMINUYE EL NUMERO QUE ES EL DE LA IMAGEN
            if (a == 0)
            {
                pictureBox1.Image = Image.FromFile(@"Tutorial\001.png");
                label1.Text = "1. Ingrese el nombre del elemento en \nla barra de búsqueda.";
            }
            if (a == 1)
            {
                pictureBox1.Image = Image.FromFile(@"Tutorial\002.png");
                label1.Text = "2. Puede seleccionar el tipo de filtro \nen el botón de filtro.";
            }
            if (a == 2)
            {
                pictureBox1.Image = Image.FromFile(@"Tutorial\003.png");
                label1.Text = "3. Para reproducir música en necesario \nañadirla detu biblioteca.";
            }
            if (a == 3)
            {
                pictureBox1.Image = Image.FromFile(@"Tutorial\004.png");
                label1.Text = "4. Para utilizar la tabla basta con darle \nclick al elemnto que seleccione.";
            }
            if (a < 0 )
            {
                //NO DEJA QUE DISMINUYA A MENOS DE 0
                a = 0;
            }
        }
    }
}
