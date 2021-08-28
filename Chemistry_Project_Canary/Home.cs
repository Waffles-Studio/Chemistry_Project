using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

namespace Chemistry_Project_Canary
{
    public partial class Home : Form
    {


        public Home()
        {
            InitializeComponent();

            //CAMBIAR COLOR A CADA ITEM DE LA FOMRA PRINCIPAL
            this.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            lab_Title.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            groupBox1.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            groupBox1.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label1.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            groupBox2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label6.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label3.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label4.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label5.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            groupBox2.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            button4.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            button4.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            button1.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            button1.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            button2.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            button2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            button3.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            button3.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Team.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            btn_Team.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Themes.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            btn_Themes.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Music.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            btn_Music.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Help.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            btn_Help.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Updates.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            btn_Updates.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Exit.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            btn_Exit.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label8.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label7.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label9.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label12.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label10.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label13.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label11.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label14.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;

            //CAMBIAR IMAGEN DEPENDIENDO EL TEMA
            if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
            {
                button4.Image = Image.FromFile(@"TemaOscuro\baseline_filter_1_white_18dp.png");
                button1.Image = Image.FromFile(@"TemaOscuro\baseline_filter_1_white_18dp.png");
                button2.Image = Image.FromFile(@"TemaOscuro\baseline_filter_1_white_18dp.png");
                button3.Image = Image.FromFile(@"TemaOscuro\baseline_filter_1_white_18dp.png");
                btn_Team.Image = Image.FromFile(@"TemaOscuro\round_group_white_18dp.png");
                btn_Themes.Image = Image.FromFile(@"TemaOscuro\round_palette_white_18dp.png");
                btn_Music.Image = Image.FromFile(@"TemaOscuro\round_library_music_white_18dp.png");
                btn_Help.Image = Image.FromFile(@"TemaOscuro\round_help_white_18dp.png");
                btn_Updates.Image = Image.FromFile(@"TemaOscuro\round_update_white_18dp.png");
                btn_Exit.Image = Image.FromFile(@"TemaOscuro\round_exit_to_app_white_18dp.png");
                txt_Search.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
                txt_Search.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            }
            if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.Black)
            {
                txt_Search.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            }
            else
            {
                
            }
            


        }

        //SE REA EL DATASER Y 'mifiltro' PARA HACER EL FILTRO Y MOSTARR LOS DATOS
        DataSet resultados = new DataSet();
        DataView mifiltro;

        //-----------------------------------------------------
        private void btn_Search_Click(object sender, EventArgs e)
        {

        }


        //BOTON LIMPIAR TEXTBOX 
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
        }

        //Motrar El DATA VIEW
        private void btn_GlobalSearch_Click(object sender, EventArgs e)
        {
            pic_Icon.Visible = false;
            lab_Title.Visible = false;
            dataGridView1.Visible = true;
            groupBox1.Location = new Point(254, 32);
        }


        //MOSTRAR EL FILTRO
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel2.Visible = true;
        }

        //MOSTRAR ORIGINAL
        private void btn_Home_Click(object sender, EventArgs e)
        {
            pic_Icon.Visible = true;
            lab_Title.Visible = true;
            dataGridView1.Visible = false;
            groupBox1.Location = new Point(254, 233);
        }

        //INVOCA LA TABLA DE ELEMENTOS
        private void btn_Table_Click(object sender, EventArgs e)
        {
            Table TB = new Table();
            TB.ShowDialog();
        }

        //-----------------------------------------------------
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            PanelIdioma.BringToFront();
            PanelIdioma.Visible = true;
        }

        //INFORMACION DEL EQUIPO
        private void btn_Team_Click(object sender, EventArgs e)
        {
            Team TM = new Team();
            TM.ShowDialog();
        }

        //SELECCION DEL TEMA
        private void btn_Themes_Click(object sender, EventArgs e)
        {
            Themes TH = new Themes();
            TH.Show();
            this.Close();
            
        }

        //REPRODUCIR MUSICA
        private void btn_Music_Click(object sender, EventArgs e)
        {
            Music MS = new Music();
            MS.ShowDialog();
        }

        //BOTON AYUDA
        private void btn_Help_Click(object sender, EventArgs e)
        {
            Help HP = new Help();
            HP.ShowDialog();
        }

        //MOSTRAR FORM DE ACTUALIZACIONES
        private void btn_Updates_Click(object sender, EventArgs e)
        {
            Updates UP = new Updates();
            UP.ShowDialog();
        }

        //SALIR DEL PROGRAMA
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //PROGRAMACION DEL FILTRO EN EL TEXT BOX
        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            //MOVER ELEMENTOS AL ESCRIBIR EN LA TEXBOX
            pic_Icon.Visible = false;
            lab_Title.Visible = false;
            dataGridView1.Visible = true;
            groupBox1.Location = new Point(254, 32);


            //SE APLICA EL FILTRO DE BUSQUEDA

            string salida_datos = ""; //VARIABLE DE LO QUE SE MOSTRARA
            string[] palabras_busqueda = this.txt_Search.Text.Split(' '); //LA BUSUQEDA SE ENVIA A LA VARIABLE QUE SE IMPRIMIRA


            if (radioButton1.Checked == true)
            {
                foreach (string palabra in palabras_busqueda)
                {
                    if (salida_datos.Length == 0)//SI NO SE ESCRIBE NADA
                    {
                        salida_datos = "(Elemento LIKE '%" + palabra + "%')";

                    }
                    else//ELEMENTOS ENCONTRADOS
                    {
                        salida_datos += " AND (Elemento LIKE '%" + palabra + "%')";
                    }
                }
            }//FILTRO NOMBRE
            if (radioButton2.Checked == true)
            {
                foreach (string palabra in palabras_busqueda)
                {
                    if (salida_datos.Length == 0)//SI NO SE ESCRIBE NADA
                    {
                        salida_datos = "(Simbolo LIKE '%" + palabra + "%')";

                    }
                    else//ELEMENTOS ENCONTRADOS
                    {
                        salida_datos += " AND (OR Simbolo LIKE '%" + palabra + "%')";
                    }
                }
            }//FILTRO SIMBOLO
            if (radioButton3.Checked == true)
            {
                foreach (string palabra in palabras_busqueda)
                {
                    if (salida_datos.Length == 0)//SI NO SE ESCRIBE NADA
                    {
                        salida_datos = "(Numero_Atomico LIKE '%" + palabra + "%')";

                    }
                    else//ELEMENTOS ENCONTRADOS
                    { 
                        salida_datos += " AND (Numero_Atomico LIKE '%" + palabra + "%')";
                    }
                }
            }//FILTRO NUMERO ATOMICO
            if (radioButton4.Checked == true)
            {
                foreach (string palabra in palabras_busqueda)
                {
                    if (salida_datos.Length == 0)//SI NO SE ESCRIBE NADA
                    {
                        salida_datos = "(Elemento LIKE '%" + palabra + "%' OR Simbolo LIKE '%" + palabra + "%' OR Numero_Atomico LIKE '%" + palabra + "%')";

                    }
                    else//ELEMENTOS ENCONTRADOS
                    {
                        salida_datos += " AND (Elemento LIKE '%" + palabra + "%' OR Simbolo LIKE '%" + palabra + "%' OR Numero_Atomico LIKE '%" + palabra + "%')";
                    }
                }
            }//SIN FILTRO

            try
            {
                this.mifiltro.RowFilter = salida_datos; //SE GUARDA LA BUSQUEDA
            }
            catch (Exception)
            {
                MessageBox.Show("Esos caracteres no son validos");
            }
            

        }


        //ENVIAR DATOS A OTRA CLASE PARA CARGAR LA BASE DE DATOS Y ENVIAR LOS FILTROS Y RECIBIRLOS
        private void Home_Load(object sender, EventArgs e)
        {
            //ENVIAR Y RECIVIR DATOS A 'FiltroHijo'
            FiltroHijo FP = new FiltroHijo();
            FP.leer_datos("SELECT * FROM Elementos", ref resultados, "Elementos");//SE LE ENVIA TABLA, DATOS Y FILTRO
            this.mifiltro = ((DataTable)resultados.Tables["Elementos"]).DefaultView;//FILTRA POR COLUMNA
            this.dataGridView1.DataSource = mifiltro;//SE LE PASA A MI FILTRO LO QUE VA A IMPRIMIR

        }


        //OCULTAR FILTRO
        private void btn_Back_Click(object sender, EventArgs e)
        {
            panel2.SendToBack();
            panel2.Visible = false;

        }


        //SELECCION DE LA BASE DE DATOS
        public static string Nomb;  //VARIABLE SELECCION
        public int se;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //COMPARAR EL NOMBRE DE SELECCION Y ENCIAR EL RESULTADO
            Nomb = dataGridView1.Rows[e.RowIndex].Cells["Elemento"].Value.ToString();
            if (Nomb == "Hierro")
            {
                se = 1;
            }
            if (Nomb == "Rutenio")
            {
                se = 2;
            }
            if (Nomb == "Osmio")
            {
                se = 3;
            }
            if (Nomb == "Cobalto")
            {
                se = 4;
            }
            if (Nomb == "Rodio")
            {
                se = 5;
            }
            if (Nomb == "Iridio")
            {
                se = 6;
            }
            if (Nomb == "Niquel")
            {
                se = 7;
            }
            if (Nomb == "Paladio")
            {
                se = 8;
            }
            if (Nomb == "Platino")
            {
                se = 9;
            }
            if (Nomb == "Cobre")
            {
                se = 10;
            }
            if (Nomb == "Plata")
            {
                se = 11;
            }
            if (Nomb == "Oro")
            {
                se = 12;
            }
            if (Nomb == "Cinc")
            {
                se = 13;
            }
            if (Nomb == "Cadmio")
            {
                se = 14;
            }
            if (Nomb == "Mercurio")
            {
                se = 15;
            }

            Element El = new Element();
            El.Elemento(se);
            El.ShowDialog();
        }


        //OCULTAR CONFIGURACION
        private void button6_Click(object sender, EventArgs e)
        {
            PanelIdioma.SendToBack();
            PanelIdioma.Visible = false;
        }


        //---------------------------------------------------------
        private void button5_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
