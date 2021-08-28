namespace Chemistry_Project_Canary
{
    partial class Element
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Element));
            this.label2 = new System.Windows.Forms.Label();
            this.lab_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pic_01 = new System.Windows.Forms.PictureBox();
            this.rich_02 = new System.Windows.Forms.RichTextBox();
            this.rich_01 = new System.Windows.Forms.RichTextBox();
            this.pic_02 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_02)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 59;
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.Location = new System.Drawing.Point(22, 9);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(25, 58);
            this.lab_Title.TabIndex = 58;
            this.lab_Title.Text = "\r\n";
            this.lab_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 87);
            this.panel1.TabIndex = 57;
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
            this.btn_Back.Text = "Back";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pic_01
            // 
            this.pic_01.Location = new System.Drawing.Point(18, 109);
            this.pic_01.Name = "pic_01";
            this.pic_01.Size = new System.Drawing.Size(124, 124);
            this.pic_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_01.TabIndex = 60;
            this.pic_01.TabStop = false;
            // 
            // rich_02
            // 
            this.rich_02.BackColor = System.Drawing.SystemColors.Control;
            this.rich_02.Location = new System.Drawing.Point(18, 244);
            this.rich_02.Name = "rich_02";
            this.rich_02.Size = new System.Drawing.Size(328, 124);
            this.rich_02.TabIndex = 61;
            this.rich_02.Text = "[Sample_Text]";
            // 
            // rich_01
            // 
            this.rich_01.BackColor = System.Drawing.SystemColors.Control;
            this.rich_01.Location = new System.Drawing.Point(156, 109);
            this.rich_01.Name = "rich_01";
            this.rich_01.Size = new System.Drawing.Size(328, 124);
            this.rich_01.TabIndex = 63;
            this.rich_01.Text = "[Sample_Text]";
            // 
            // pic_02
            // 
            this.pic_02.Location = new System.Drawing.Point(360, 244);
            this.pic_02.Name = "pic_02";
            this.pic_02.Size = new System.Drawing.Size(124, 124);
            this.pic_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_02.TabIndex = 62;
            this.pic_02.TabStop = false;
            // 
            // Element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.rich_01);
            this.Controls.Add(this.pic_02);
            this.Controls.Add(this.rich_02);
            this.Controls.Add(this.pic_01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_Title);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Element";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elemento";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox pic_01;
        private System.Windows.Forms.RichTextBox rich_02;
        private System.Windows.Forms.RichTextBox rich_01;
        private System.Windows.Forms.PictureBox pic_02;
    }
}