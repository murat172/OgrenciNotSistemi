namespace OgrenciNotSistemi
{
    partial class FrmGirisSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisSayfası));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgretmenSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskOgretmenNumara = new System.Windows.Forms.MaskedTextBox();
            this.btnOgretmenGiris = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOgrenciGiriş = new System.Windows.Forms.Button();
            this.txtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskOgrenciNumara = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sisteme Giriş Sayfası";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOgretmenSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskOgretmenNumara);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnOgretmenGiris);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 276);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // txtOgretmenSifre
            // 
            this.txtOgretmenSifre.Location = new System.Drawing.Point(362, 132);
            this.txtOgretmenSifre.Name = "txtOgretmenSifre";
            this.txtOgretmenSifre.Size = new System.Drawing.Size(238, 32);
            this.txtOgretmenSifre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numara:";
            // 
            // mskOgretmenNumara
            // 
            this.mskOgretmenNumara.Location = new System.Drawing.Point(361, 82);
            this.mskOgretmenNumara.Mask = "00000";
            this.mskOgretmenNumara.Name = "mskOgretmenNumara";
            this.mskOgretmenNumara.Size = new System.Drawing.Size(240, 32);
            this.mskOgretmenNumara.TabIndex = 4;
            this.mskOgretmenNumara.ValidatingType = typeof(int);
            // 
            // btnOgretmenGiris
            // 
            this.btnOgretmenGiris.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenGiris.Location = new System.Drawing.Point(413, 178);
            this.btnOgretmenGiris.Name = "btnOgretmenGiris";
            this.btnOgretmenGiris.Size = new System.Drawing.Size(134, 42);
            this.btnOgretmenGiris.TabIndex = 3;
            this.btnOgretmenGiris.Text = "Öğretmen Girişi";
            this.btnOgretmenGiris.UseVisualStyleBackColor = true;
            this.btnOgretmenGiris.Click += new System.EventHandler(this.btnOgretmenGiris_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnOgrenciGiriş);
            this.groupBox2.Controls.Add(this.txtOgrenciSifre);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mskOgrenciNumara);
            this.groupBox2.Location = new System.Drawing.Point(12, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 277);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre:";
            // 
            // btnOgrenciGiriş
            // 
            this.btnOgrenciGiriş.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciGiriş.Location = new System.Drawing.Point(413, 176);
            this.btnOgrenciGiriş.Name = "btnOgrenciGiriş";
            this.btnOgrenciGiriş.Size = new System.Drawing.Size(134, 42);
            this.btnOgrenciGiriş.TabIndex = 4;
            this.btnOgrenciGiriş.Text = "Öğrenci Girişi";
            this.btnOgrenciGiriş.UseVisualStyleBackColor = true;
            this.btnOgrenciGiriş.Click += new System.EventHandler(this.btnOgrenciGiriş_Click);
            // 
            // txtOgrenciSifre
            // 
            this.txtOgrenciSifre.Location = new System.Drawing.Point(361, 127);
            this.txtOgrenciSifre.Name = "txtOgrenciSifre";
            this.txtOgrenciSifre.Size = new System.Drawing.Size(238, 32);
            this.txtOgrenciSifre.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(241, 217);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numara:";
            // 
            // mskOgrenciNumara
            // 
            this.mskOgrenciNumara.Location = new System.Drawing.Point(360, 74);
            this.mskOgrenciNumara.Mask = "00000";
            this.mskOgrenciNumara.Name = "mskOgrenciNumara";
            this.mskOgrenciNumara.Size = new System.Drawing.Size(240, 32);
            this.mskOgrenciNumara.TabIndex = 8;
            this.mskOgrenciNumara.ValidatingType = typeof(int);
            // 
            // FrmGirisSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(668, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGirisSayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sisteme Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgretmenSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskOgretmenNumara;
        private System.Windows.Forms.Button btnOgretmenGiris;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOgrenciGiriş;
        private System.Windows.Forms.TextBox txtOgrenciSifre;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskOgrenciNumara;
    }
}

