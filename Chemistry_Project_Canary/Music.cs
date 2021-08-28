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
    public partial class Music : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

        public Music()
        {
            InitializeComponent();

            //CAMBIAR TEMA
            this.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            lab_Title.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            label2.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS; ;
            lab_Song.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS; 

            btn_Prev.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting; ;
            btnPlay.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;
            btn_Adjuntar.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting;

            btn_Prev.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btnPlay.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            btn_Adjuntar.ForeColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS;
            pictureBox1.BackColor = Chemistry_Project_Canary.Properties.Settings.Default.MyColorSetting; 

            if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
            {
                pictureBox1.Image = Image.FromFile(@"TemaOscuro\round_volume_up_white_18dp.png");
                btn_Prev.Image = Image.FromFile(@"TemaOscuro\StopB.png");
                btnPlay.Image = Image.FromFile(@"TemaOscuro\round_play_circle_filled_white_18dp.png");
                btn_Adjuntar.Image = Image.FromFile(@"TemaOscuro\round_queue_music_white_18dp.png");
            }


        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();//PARAR REPRODUCTOR AL SALIR
            this.Close();
        }

        private void btn_Adjuntar_Click(object sender, EventArgs e)
        {
            //TE DA A SELECCIONAR LAS CANCIONES DE TU LIBRERIA
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;//PERMITE SELECCIONAR VARIOS ARCHIVOS

            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;//NOMBRE DEL ARCHIVO
                rutasArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;//RUTA DEL ARCHIVO
                foreach (var ArchivoMP3 in ArchivosMP3)//AÑADIRLOS A LA LISTA DE CANCIONES
                {
                    lstcanciones.Items.Add(ArchivoMP3);
                }

                Reproductor.URL = rutasArchivosMP3[0].ToString();//EL REPRODUTOR TOMA LA CANCIONES
                lstcanciones.SelectedIndex = 0;//SELECCION DE LA CANCION
                if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.Black)
                {
                    btnPlay.Image = Image.FromFile(@"TemaOscuro\round_pause_circle_filled_white_18dp.png");//CAMBIA LA IMAGEN AL AGREGAR CANCNIONES

                }
                if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
                {
                    btnPlay.Image = Image.FromFile(@"TemaOscuro\round_pause_circle_filled_white_18dp.png");//CAMBIA LA IMAGEN AL AGREGAR CANCNIONES

                }
                else
                {
                    btnPlay.Image = Image.FromFile(@"TemaBlanco\round_pause_circle_filled_black_18dp.png");//CAMBIA LA IMAGEN AL AGREGAR CANCNIONES
                }


            }
        }

        private void lstcanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Reproductor.URL = rutasArchivosMP3[lstcanciones.SelectedIndex];//CANCNION ELEGIDA DEL REPRODUVTOR
                lab_Song.Text = ArchivosMP3[lstcanciones.SelectedIndex];//EL LABEL PONDRA EL NOMBRE DE LA CANCION
            }
            catch (Exception)
            {
                MessageBox.Show("Limite de canciones exedido", "Eliminar mas canciones");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //CASOS AL DAR CLICK EN LOS BOTONEES DE PAUSA Y PLAY
            switch (Play)
            {
                case true:
                    {
                        Reproductor.Ctlcontrols.pause();//CONTROL DEL REPRODUCTOR

                        //CAMBIAR IMAGEN DE REPRODUCTOR Y SE PUSO IF PARA EL TEMA
                        if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.Black)
                        {
                            btnPlay.Image = Image.FromFile(@"TemaOscuro\round_play_circle_filled_white_18dp.png");
                        }
                        if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
                        {
                            btnPlay.Image = Image.FromFile(@"TemaOscuro\round_play_circle_filled_white_18dp.png");
                        }
                        else
                        {
                            btnPlay.Image = Image.FromFile(@"TemaBlanco\round_play_circle_filled_black_18dp.png");
                        }
                        Play = false;//ESTADO DEL REPRODUCTOR
                    }
                    break;

                case false:
                    {
                        Reproductor.Ctlcontrols.play();//CONTROL DEL REPRODUCTOR

                        //CAMBIAR IMAGEN
                        if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.Black)
                        {
                            btnPlay.Image = Image.FromFile(@"TemaOscuro\round_pause_circle_filled_white_18dp.png");
                        }
                        if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
                        {
                            btnPlay.Image = Image.FromFile(@"TemaOscuro\round_pause_circle_filled_white_18dp.png");
                        }
                        else
                        {
                            btnPlay.Image = Image.FromFile(@"TemaBlanco\round_pause_circle_filled_black_18dp.png");
                        }
                        Play = true;//ESTADO DEL REPRODUCTOR
                    }
                    break;
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();//PARAR EL REPRODUCTOR

            //CAMBIAR IMAGEN DE BOTON A PAUSA
            if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.Black)
            {
                btnPlay.Image = Image.FromFile(@"TemaOscuro\round_play_circle_filled_white_18dp.png");
            }
            if (Chemistry_Project_Canary.Properties.Settings.Default.MyColorFS == Color.White)
            {
                btnPlay.Image = Image.FromFile(@"TemaOscuro\round_play_circle_filled_white_18dp.png");
            }
            else
            {
                btnPlay.Image = Image.FromFile(@"TemaBlanco\round_play_circle_filled_black_18dp.png");
            }
            Play = false;//ESTADO DEL REPRODUCTOR
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();//TE MANDA A UNA REFERENCIA
            mtrackStatus.Value = (int)Reproductor.Ctlcontrols.currentPosition;//SINCRONIZAR POSICION DEL ESTATUS
            mtrackVolumen.Value = Reproductor.settings.volume; //SINCRONIZAR POSICION DEL VOLUMEN
        }

        public void ActualizarDatosTrack()
        {
            //CONDICIONES PARA PAUSAR, REPDORUCIR O DETENER REPRODUCTOR
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Control del tiempo maximo del mp3 actual
                mtrackStatus.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;//SINCORNIZA LA CANCION CON EL STATUS
                timer1.Start();//INICIALIZA EL TIMER
            }
            else
            {
                if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    timer1.Stop();//DETIENE EL TIMER
                }
                else
                {
                    if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
                    {
                        timer1.Stop();//DETIENE EL TIMER
                        mtrackStatus.Value = 0;//REINICIA EL ESTATUS DE LA CANCION
                    }
                }
            }
        }



        private void mtrackVolumen_ValueChanged_1(object sender, decimal value)
        {
            Reproductor.settings.volume = mtrackVolumen.Value;//IGUALAR EL REPRODUCTOR 
        }

        private void Reproductor_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();//TE MANDA A LA REFERENCIA
        }
    }
}
