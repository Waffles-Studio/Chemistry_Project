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
    public partial class Updates : Form
    {

        public Updates()
        {
            InitializeComponent();
            //CABIAR TEMA
            this.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            lab_Title.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label3.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label4.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label5.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            textBox1.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            textBox2.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            textBox3.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            textBox1.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            textBox2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            textBox3.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Check.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Check.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            btn_Change.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            btn_Change.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label1.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            textBox4.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            textBox4.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            panel2.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;

            if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
            {
                btn_Check.Image = Image.FromFile(@"TemaOscuro\round_find_replace_white_18dp.png");
                btn_Change.Image = Image.FromFile(@"TemaOscuro\round_playlist_add_white_18dp.png");
            }
        }

        int a=0;

        //REGRESAR
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            a = 1; //EL TIMER INICIARA CUANDO "a" SEA IGUAL A 1
        }

        //MOSTRAR CAMBIOS
        private void btn_Change_Click(object sender, EventArgs e)
        {
            Changelog CL = new Changelog();
            CL.ShowDialog();
        }

        //TIMER PARA BARRA DE ACTUALIZACIONES
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a==1)
            {
                progressBar1.Increment(1); //LA BARRA AVANZARA DE 1 EN UNO
                //CONDICION DE QUE ARA CADA X TIEMPO

                //------------------DEPENDIENDO EL PROGRESO DE LA BARRA MOSTRARA UN MENSAJE-----------
                if (progressBar1.Value == 1)
                {
                    panel2.Visible = true;
                    panel2.BringToFront();
                    textBox4.Text = "Validando Informacion";
                }
                if (progressBar1.Value == 40)
                {
                    textBox4.Text = "Conectando al Servidor";
                }
                if (progressBar1.Value == 70)
                {
                    textBox4.Text = "Comprobando Actualizaciones";
                }

                if (progressBar1.Value == 99)
                {
                    
                    panel2.SendToBack();
                    panel2.Visible = false;
                }
                //MOSTRAR MESSAGEBOX QUE INDIQUE QUE NO HAY ACTUALIZACION
                if (progressBar1.Value == 100)
                {
                    this.timer1.Stop();
                    MessageBox.Show("El programa se encuentra en la ultima version disponible :)", "Sistema actualizado");
                }
                
            }
            

        }
    }
}
