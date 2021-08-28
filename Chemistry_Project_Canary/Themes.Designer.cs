namespace Chemistry_Project_Canary
{
    partial class Themes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themes));
            this.label2 = new System.Windows.Forms.Label();
            this.lab_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Light = new System.Windows.Forms.Button();
            this.btn_Dark = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Dale tu estilo.";
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.Location = new System.Drawing.Point(185, 9);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(174, 58);
            this.lab_Title.TabIndex = 47;
            this.lab_Title.Text = "Temas";
            this.lab_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 87);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btn_Back.Location = new System.Drawing.Point(227, 9);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(96, 64);
            this.btn_Back.TabIndex = 36;
            this.btn_Back.Text = "Regresar";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Light
            // 
            this.btn_Light.BackColor = System.Drawing.Color.White;
            this.btn_Light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Light.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Light.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Light.FlatAppearance.BorderSize = 0;
            this.btn_Light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Light.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Light.Image = ((System.Drawing.Image)(resources.GetObject("btn_Light.Image")));
            this.btn_Light.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Light.Location = new System.Drawing.Point(75, 282);
            this.btn_Light.Name = "btn_Light";
            this.btn_Light.Size = new System.Drawing.Size(125, 68);
            this.btn_Light.TabIndex = 49;
            this.btn_Light.Text = "Tema Claro";
            this.btn_Light.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Light.UseVisualStyleBackColor = false;
            this.btn_Light.Click += new System.EventHandler(this.btn_Light_Click);
            // 
            // btn_Dark
            // 
            this.btn_Dark.BackColor = System.Drawing.Color.White;
            this.btn_Dark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Dark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dark.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Dark.FlatAppearance.BorderSize = 0;
            this.btn_Dark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dark.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dark.Image")));
            this.btn_Dark.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Dark.Location = new System.Drawing.Point(350, 282);
            this.btn_Dark.Name = "btn_Dark";
            this.btn_Dark.Size = new System.Drawing.Size(125, 68);
            this.btn_Dark.TabIndex = 50;
            this.btn_Dark.Text = "Tema Oscuro";
            this.btn_Dark.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Dark.UseVisualStyleBackColor = false;
            this.btn_Dark.Click += new System.EventHandler(this.btn_Dark_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(12, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 145);
            this.button3.TabIndex = 53;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(279, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(261, 145);
            this.button4.TabIndex = 54;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Themes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 473);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Dark);
            this.Controls.Add(this.btn_Light);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_Title);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Themes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Themes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Light;
        private System.Windows.Forms.Button btn_Dark;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}