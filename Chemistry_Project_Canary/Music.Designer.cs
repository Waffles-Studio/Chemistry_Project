namespace Chemistry_Project_Canary
{
    partial class Music
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.label2 = new System.Windows.Forms.Label();
            this.lab_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btn_Adjuntar = new System.Windows.Forms.Button();
            this.lab_Song = new System.Windows.Forms.Label();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstcanciones = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mtrackStatus = new XComponent.SliderBar.MACTrackBar();
            this.mtrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nada mejor que una buena canción.\r\n";
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.Location = new System.Drawing.Point(156, -3);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(191, 58);
            this.lab_Title.TabIndex = 50;
            this.lab_Title.Text = "Musica";
            this.lab_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 87);
            this.panel1.TabIndex = 49;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Back.Location = new System.Drawing.Point(202, 9);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(96, 64);
            this.btn_Back.TabIndex = 36;
            this.btn_Back.Text = "Regresar";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.BackColor = System.Drawing.Color.White;
            this.btn_Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Prev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Prev.FlatAppearance.BorderSize = 0;
            this.btn_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prev.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prev.Image")));
            this.btn_Prev.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Prev.Location = new System.Drawing.Point(46, 318);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(96, 64);
            this.btn_Prev.TabIndex = 53;
            this.btn_Prev.Text = "Parar";
            this.btn_Prev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Prev.UseVisualStyleBackColor = false;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlay.Location = new System.Drawing.Point(148, 318);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(119, 64);
            this.btnPlay.TabIndex = 57;
            this.btnPlay.Text = "Reproducir";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btn_Adjuntar
            // 
            this.btn_Adjuntar.BackColor = System.Drawing.Color.White;
            this.btn_Adjuntar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Adjuntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Adjuntar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Adjuntar.FlatAppearance.BorderSize = 0;
            this.btn_Adjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adjuntar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adjuntar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Adjuntar.Image")));
            this.btn_Adjuntar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Adjuntar.Location = new System.Drawing.Point(273, 318);
            this.btn_Adjuntar.Name = "btn_Adjuntar";
            this.btn_Adjuntar.Size = new System.Drawing.Size(193, 64);
            this.btn_Adjuntar.TabIndex = 58;
            this.btn_Adjuntar.Text = "Añadir Canciones";
            this.btn_Adjuntar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Adjuntar.UseVisualStyleBackColor = false;
            this.btn_Adjuntar.Click += new System.EventHandler(this.btn_Adjuntar_Click);
            // 
            // lab_Song
            // 
            this.lab_Song.AutoSize = true;
            this.lab_Song.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Song.Location = new System.Drawing.Point(14, 77);
            this.lab_Song.Name = "lab_Song";
            this.lab_Song.Size = new System.Drawing.Size(0, 28);
            this.lab_Song.TabIndex = 59;
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(504, 397);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(32, 45);
            this.Reproductor.TabIndex = 60;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange_1);
            // 
            // lstcanciones
            // 
            this.lstcanciones.FormattingEnabled = true;
            this.lstcanciones.ItemHeight = 17;
            this.lstcanciones.Location = new System.Drawing.Point(27, 143);
            this.lstcanciones.Name = "lstcanciones";
            this.lstcanciones.Size = new System.Drawing.Size(444, 140);
            this.lstcanciones.TabIndex = 61;
            this.lstcanciones.SelectedIndexChanged += new System.EventHandler(this.lstcanciones_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mtrackStatus
            // 
            this.mtrackStatus.BackColor = System.Drawing.Color.Transparent;
            this.mtrackStatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackStatus.IndentHeight = 6;
            this.mtrackStatus.Location = new System.Drawing.Point(27, 109);
            this.mtrackStatus.Maximum = 10;
            this.mtrackStatus.Minimum = 0;
            this.mtrackStatus.Name = "mtrackStatus";
            this.mtrackStatus.Size = new System.Drawing.Size(444, 28);
            this.mtrackStatus.TabIndex = 62;
            this.mtrackStatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackStatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtrackStatus.TickHeight = 4;
            this.mtrackStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackStatus.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.mtrackStatus.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtrackStatus.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackStatus.TrackLineHeight = 3;
            this.mtrackStatus.TrackLineSelectedColor = System.Drawing.Color.Silver;
            this.mtrackStatus.Value = 0;
            // 
            // mtrackVolumen
            // 
            this.mtrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mtrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackVolumen.ForeColor = System.Drawing.Color.Black;
            this.mtrackVolumen.IndentHeight = 6;
            this.mtrackVolumen.Location = new System.Drawing.Point(53, 289);
            this.mtrackVolumen.Maximum = 100;
            this.mtrackVolumen.Minimum = 0;
            this.mtrackVolumen.Name = "mtrackVolumen";
            this.mtrackVolumen.Size = new System.Drawing.Size(418, 28);
            this.mtrackVolumen.TabIndex = 63;
            this.mtrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TickColor = System.Drawing.Color.Black;
            this.mtrackVolumen.TickHeight = 4;
            this.mtrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TrackerColor = System.Drawing.Color.Black;
            this.mtrackVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtrackVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackVolumen.TrackLineHeight = 3;
            this.mtrackVolumen.TrackLineSelectedColor = System.Drawing.Color.Silver;
            this.mtrackVolumen.Value = 0;
            this.mtrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtrackVolumen_ValueChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtrackVolumen);
            this.Controls.Add(this.mtrackStatus);
            this.Controls.Add(this.lstcanciones);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.lab_Song);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Adjuntar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_Title);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Music";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btn_Adjuntar;
        private System.Windows.Forms.Label lab_Song;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox lstcanciones;
        private System.Windows.Forms.Timer timer1;
        private XComponent.SliderBar.MACTrackBar mtrackStatus;
        private XComponent.SliderBar.MACTrackBar mtrackVolumen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}