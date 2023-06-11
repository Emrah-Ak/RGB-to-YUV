
namespace RGB_renk_uzayını_YUV___a_Dönüştürme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Resim1 = new System.Windows.Forms.PictureBox();
            this.Resim2 = new System.Windows.Forms.PictureBox();
            this.piksel = new System.Windows.Forms.Button();
            this.Kırmızı = new System.Windows.Forms.Label();
            this.Yeşil = new System.Windows.Forms.Label();
            this.Mavi = new System.Windows.Forms.Label();
            this.Kaydet = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Göster = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Şifrele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Resim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resim2)).BeginInit();
            this.SuspendLayout();
            // 
            // Resim1
            // 
            this.Resim1.Location = new System.Drawing.Point(25, 53);
            this.Resim1.Name = "Resim1";
            this.Resim1.Size = new System.Drawing.Size(161, 182);
            this.Resim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resim1.TabIndex = 0;
            this.Resim1.TabStop = false;
            this.Resim1.Click += new System.EventHandler(this.Resim1_Click);
            // 
            // Resim2
            // 
            this.Resim2.Location = new System.Drawing.Point(252, 53);
            this.Resim2.Name = "Resim2";
            this.Resim2.Size = new System.Drawing.Size(156, 182);
            this.Resim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resim2.TabIndex = 1;
            this.Resim2.TabStop = false;
            // 
            // piksel
            // 
            this.piksel.Location = new System.Drawing.Point(497, 177);
            this.piksel.Name = "piksel";
            this.piksel.Size = new System.Drawing.Size(57, 23);
            this.piksel.TabIndex = 2;
            this.piksel.Text = "Piksel";
            this.piksel.UseVisualStyleBackColor = true;
            this.piksel.Click += new System.EventHandler(this.piksel_Click);
            // 
            // Kırmızı
            // 
            this.Kırmızı.AutoSize = true;
            this.Kırmızı.Location = new System.Drawing.Point(497, 64);
            this.Kırmızı.Name = "Kırmızı";
            this.Kırmızı.Size = new System.Drawing.Size(14, 13);
            this.Kırmızı.TabIndex = 3;
            this.Kırmızı.Text = "R";
            // 
            // Yeşil
            // 
            this.Yeşil.AutoSize = true;
            this.Yeşil.Location = new System.Drawing.Point(497, 94);
            this.Yeşil.Name = "Yeşil";
            this.Yeşil.Size = new System.Drawing.Size(14, 13);
            this.Yeşil.TabIndex = 4;
            this.Yeşil.Text = "G";
            // 
            // Mavi
            // 
            this.Mavi.AutoSize = true;
            this.Mavi.Location = new System.Drawing.Point(498, 129);
            this.Mavi.Name = "Mavi";
            this.Mavi.Size = new System.Drawing.Size(13, 13);
            this.Mavi.TabIndex = 5;
            this.Mavi.Text = "B";
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(498, 210);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(56, 25);
            this.Kaydet.TabIndex = 6;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "gri",
            "renkli",
            "Şifreli"});
            this.comboBox1.Location = new System.Drawing.Point(25, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Göster
            // 
            this.Göster.Location = new System.Drawing.Point(498, 241);
            this.Göster.Name = "Göster";
            this.Göster.Size = new System.Drawing.Size(56, 21);
            this.Göster.TabIndex = 8;
            this.Göster.Text = "Göster";
            this.Göster.UseVisualStyleBackColor = true;
            this.Göster.Click += new System.EventHandler(this.Göster_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 321);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 89);
            this.textBox1.TabIndex = 9;
            // 
            // Şifrele
            // 
            this.Şifrele.Location = new System.Drawing.Point(497, 278);
            this.Şifrele.Name = "Şifrele";
            this.Şifrele.Size = new System.Drawing.Size(57, 21);
            this.Şifrele.TabIndex = 10;
            this.Şifrele.Text = "Şifrele";
            this.Şifrele.UseVisualStyleBackColor = true;
            this.Şifrele.Click += new System.EventHandler(this.Şifrele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 422);
            this.Controls.Add(this.Şifrele);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Göster);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.Mavi);
            this.Controls.Add(this.Yeşil);
            this.Controls.Add(this.Kırmızı);
            this.Controls.Add(this.piksel);
            this.Controls.Add(this.Resim2);
            this.Controls.Add(this.Resim1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Resim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resim2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Resim1;
        private System.Windows.Forms.PictureBox Resim2;
        private System.Windows.Forms.Button piksel;
        private System.Windows.Forms.Label Kırmızı;
        private System.Windows.Forms.Label Yeşil;
        private System.Windows.Forms.Label Mavi;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Göster;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Şifrele;
    }
}

