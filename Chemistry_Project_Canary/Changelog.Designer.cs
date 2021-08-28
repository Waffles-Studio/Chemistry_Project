namespace Chemistry_Project_Canary
{
    partial class Changelog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changelog));
            this.label2 = new System.Windows.Forms.Label();
            this.lab_Title = new System.Windows.Forms.Label();
            this.btn_Okay = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "¿Qué hay de nuevo?\r\n";
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.Location = new System.Drawing.Point(35, 9);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(310, 42);
            this.lab_Title.TabIndex = 49;
            this.lab_Title.Text = "Lista de Cambios";
            this.lab_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Okay
            // 
            this.btn_Okay.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Okay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Okay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Okay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Okay.FlatAppearance.BorderSize = 0;
            this.btn_Okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Okay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Okay.Image = ((System.Drawing.Image)(resources.GetObject("btn_Okay.Image")));
            this.btn_Okay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Okay.Location = new System.Drawing.Point(143, 265);
            this.btn_Okay.Name = "btn_Okay";
            this.btn_Okay.Size = new System.Drawing.Size(96, 64);
            this.btn_Okay.TabIndex = 51;
            this.btn_Okay.Text = "Entendido";
            this.btn_Okay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Okay.UseVisualStyleBackColor = false;
            this.btn_Okay.Click += new System.EventHandler(this.btn_Okay_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "------------------ Version 3.3.0 -----------------------",
            "<!> Primera versión Estable!",
            "<+> Añadido Reproductor de Música funcional.",
            "<+> Añadido Filtro de Búsqueda funcional.",
            "<+> Ligero rediseño de Interfaz.",
            "<+> Selector de Temas añadidos!",
            "",
            "------------------ Version 3.2.0 -----------------------",
            "<+> Pagina de Filtros Añadida",
            "<+> Página de elementos añadida!",
            "<~> Bugs Corregidos",
            "",
            "------------------ Version 3.1.0 -----------------------",
            "<+> Pestaña de Temas añadida!",
            "<+> Interfaz de Reproductor de musica añadido!",
            "",
            "------------------ Version 3.0.0 -----------------------",
            "<+> Ventana de Cambios añadida!",
            "<+> Boton de Inicio añadido!",
            "<+> Iconos Actualizados!",
            "<+> Pestaña de Equipo actualizada!",
            "<~> Rediseño de colores!",
            "<~> Accesibilidades mejoradas",
            "<~> Bugs Arreglados"});
            this.listBox1.Location = new System.Drawing.Point(49, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(285, 157);
            this.listBox1.TabIndex = 52;
            // 
            // Changelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 341);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Okay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_Title);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Changelog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changelog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Button btn_Okay;
        private System.Windows.Forms.ListBox listBox1;
    }
}