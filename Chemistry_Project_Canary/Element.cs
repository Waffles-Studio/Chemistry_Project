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
    public partial class Element : Form
    {
        public Element()
        {
            InitializeComponent();
            //CAMBIAR DE TEMA
            this.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            rich_01.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            rich_01.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            rich_02.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            rich_02.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            lab_Title.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Elemento(int a)
        {
            //MOSTRAR TEXTO E IMAGEN DEL ELEMENTO
            if (a == 1)
            {
                //CAMBIAR IMAGEN
                pic_01.Image = Image.FromFile(@"ImgElementos\Hierro.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Hierro2.jpg");

                //CARGAR TEXTOS DE ELEMNTOS Y SE MOSTARARN
                FileStream fs = new FileStream(@"DocElementos\Hierro.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Hierro2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();
                //CAMBIAR TEXTOS DE LABEL
                lab_Title.Text = "HIERRO";
                label2.Text = "[Fe------- NA.-26]";

            }
            if (a == 2)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Rutenio.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Rutenio.jpg");

                FileStream fs = new FileStream(@"DocElementos\Rutenio.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Rutenio2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "RUTENIO";
                label2.Text = "[Ru------- NA.-44]";

            }
            if (a == 3)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Osmio.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Osmio2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Osmio.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Osmio2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "OSMIO";
                label2.Text = "[Os------- NA.-76]";

            }
            if (a == 4)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Cobalto.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Cobalto2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Cobalto.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Cobalto2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "COBALTO";
                label2.Text = "[Co------- NA.-27]";

            }
            if (a == 5)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Rodio.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Rodio2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Rodio.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Rodio2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "RODIO";
                label2.Text = "[Rh------- NA.-45]";

            }
            if (a == 6)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Iridio.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Iridio2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Iridio.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Iridio2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "IRIDIO";
                label2.Text = "[Ir------- NA.-77]";

            }
            if (a == 7)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Niquel.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Niquel2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Niquel.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Niquel2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "NIQUEL";
                label2.Text = "[Ni------- NA.-28]";

            }
            if (a == 8)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Paladio.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Paladio2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Paladio.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Paladio2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "PALADIO";
                label2.Text = "[Pd------- NA.-46]";

            }
            if (a == 9)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Platino.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Platino2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Platino.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Platino2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "PLATINO";
                label2.Text = "[Pt------- NA.-78]";

            }
            if (a == 10)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Cobre.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Cobre2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Cobre.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Cobre2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "COBRE";
                label2.Text = "[Cu------- NA.-29]";

            }
            if (a == 11)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Plata.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Plata2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Plata.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Plata2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "PLATA";
                label2.Text = "[Ag------- NA.-47]";

            }
            if (a == 12)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Oro.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Oro2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Oro.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Oro2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "ORO";
                label2.Text = "[Au------- NA.-79]";

            }
            if (a == 13)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Cinc.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Cinc2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Zinc.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Zinc2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "ZINC";
                label2.Text = "[Zn------- NA.-30]";

            }
            if (a == 14)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Cadmio.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Cadmio2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Cadmio1.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Cadmio2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "CADMIO";
                label2.Text = "[Cd------- NA.-48]";

            }
            if (a == 15)
            {
                pic_01.Image = Image.FromFile(@"ImgElementos\Mercurio.jpg");
                pic_02.Image = Image.FromFile(@"ImgElementos\Mercurio2.jpg");

                FileStream fs = new FileStream(@"DocElementos\Mercurio.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                rich_01.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
                FileStream fs2 = new FileStream(@"DocElementos\Mercurio2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                rich_02.Text = sr2.ReadToEnd();
                fs2.Close();
                sr2.Close();

                lab_Title.Text = "MERCURIO";
                label2.Text = "[Hg------- NA.-80]";

            }
        }

    }
}
