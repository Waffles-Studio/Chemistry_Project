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
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
            //CAMBIO DEL TEMA
            this.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;

        }
        Element El = new Element();

        //SE LE ENVIA UN NUMERO Y SE MUESTRA UNA FORMA
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();//CERRAR
        }



        //-------------DEPENDIENDO EL BOTON CARGA UNA FORMA Y LE ENVIA UN NUMERO QUE CORRESPONDE A CADA ELEMENTO------------------------
        private void button34_Click(object sender, EventArgs e)
        {
            El.Elemento(1);
            El.ShowDialog();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            El.Elemento(2);
            El.ShowDialog();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            El.Elemento(3);
            El.ShowDialog();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            El.Elemento(4);
            El.ShowDialog();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            El.Elemento(5);
            El.ShowDialog();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            El.Elemento(6);
            El.ShowDialog();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            El.Elemento(7);
            El.ShowDialog();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            El.Elemento(8);
            El.ShowDialog();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            El.Elemento(9);
            El.ShowDialog();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            El.Elemento(10);
            El.ShowDialog();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            El.Elemento(11);
            El.ShowDialog();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            El.Elemento(12);
            El.ShowDialog();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            El.Elemento(13);
            El.ShowDialog();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            El.Elemento(14);
            El.ShowDialog();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            El.Elemento(15);
            El.ShowDialog();
        }
    }
}
