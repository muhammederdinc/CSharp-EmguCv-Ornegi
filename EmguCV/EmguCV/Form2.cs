using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.Structure;


namespace EmguCV
{
    public partial class Form2 : Form
    {

        Image<Bgr, byte> _inputimage;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;




        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* openFileDialog1.Filter = "Resim Dosyaları| " + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {

                 pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);


                 //_inputimage = new Image<Bgr, byte>(openFileDialog1.FileName);
                 
                 B = _inputimage[0];
                 G = _inputimage[1];
                 R = _inputimage[2];

                 ımageBox1.Image = R;
                 ımageBox2.Image = G;
                 ımageBox3.Image = B;

             }*/


            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "Resim Dosyası |*.jpg| Resim Dosyası|*.jpeg| Resim Dosyası |*.png",
                //file.FilterIndex = 2;
                //file.RestoreDirectory = true;
                //file.CheckFileExists = false;
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Resim Dosyası Seçiniz.."
            };
            //file.Multiselect = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;

                // MessageBox.Show(DosyaYolu);

                _inputimage = new Image<Bgr, byte>(DosyaYolu);
                //ımageBox1.Image = _inputimage;


                B = _inputimage[0];
                G = _inputimage[1];
                R = _inputimage[2];

                ımageBox1.Image = R;
                ımageBox2.Image = G;
                ımageBox3.Image = B;

            }






        }
    }
}


       

