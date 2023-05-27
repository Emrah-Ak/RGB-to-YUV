﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace RGB_renk_uzayını_YUV___a_Dönüştürme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resim1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyasecici = new OpenFileDialog();
            dosyasecici.Filter = "jpeg dosyası|*.jpeg; *.jpg|*.Bmp dosyası|*.bmp";
            if (dosyasecici.ShowDialog() == DialogResult.OK)
            {
                Resim1.ImageLocation = dosyasecici.FileName;

            }

        }

        private void piksel_Click(object sender, EventArgs e)
        {
            if (Resim1.Image == null) return;
            Bitmap goruntu = (Bitmap)Resim1.Image;
            Color ilkpiksel = goruntu.GetPixel(0, 0);
            int genişlik = goruntu.Width;
            int yükseklik = goruntu.Height;
            Bitmap yenigoruntu = new Bitmap(genişlik, yükseklik);
            for (int sutun = 0; sutun < genişlik; sutun++)
            {
                for (int satır = 0; satır < yükseklik; satır++)
                {
                    Color piksel = goruntu.GetPixel(sutun, satır);

                    double Y = (0.257 * piksel.R) + (0.504 * piksel.G) + (0.098 * piksel.B) / 16;
                    double U = (-0.148 * piksel.R) + (-0.291 * piksel.G) + (0.439 * piksel.B) + 128;
                    double V = (0.439 * piksel.R) + (-0.368 * piksel.G) + (-0.071 * piksel.B) + 128;

                    Color hedefpiksel = Color.FromArgb(piksel.A, (int)Y, (int)Y, (int)Y);


                    yenigoruntu.SetPixel(sutun, satır, hedefpiksel);
                }
            }

            Resim2.Image = yenigoruntu;

            Kırmızı.Text = "R" + ilkpiksel.R.ToString();
            Yeşil.Text = "G" + ilkpiksel.G.ToString();
            Mavi.Text = "B" + ilkpiksel.B.ToString();

        }

        private void Kaydet_Click(object sender, EventArgs e)

        {
            SaveFileDialog sft = new SaveFileDialog();
            sft.Filter = "jpeg dosyası | *.jpeg; *.jpg | *.Bmp dosyası | *.bmp";
            if (DialogResult.OK == sft.ShowDialog())
            {
                this.Resim2.Image.Save(sft.FileName, ImageFormat.Jpeg);
            }
        }
    


        }
    }
