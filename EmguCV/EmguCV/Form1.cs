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
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _inputimage;
        Image<Gray, byte> gri;
        Image<Gray, byte> Binary;
        OpenFileDialog file;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Formun boyutunu değiştirmeyi engellemek için kullanılır.
        }

        private void button1_Click(object sender, EventArgs e)
        {


            file = new OpenFileDialog

            {
                Filter = "Resim Dosyası |*.jpg| Resim Dosyası|*.jpeg| Resim Dosyası |*.png",
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
                
                ımageBox4.Image = _inputimage;

            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            if (_inputimage == null)
            {
                MessageBox.Show("Resim Yükleme İşlemi Gerçekleşmeden Gri İmage Dönüşümü Yapılamaz...", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gri = _inputimage.Convert<Gray, byte>();
            ımageBox3.Image = gri;
         
            }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_inputimage == null)
            {
                MessageBox.Show("Resim Yükleme İşlemi Gerçekleşmeden Binary Dönüşümü Yapılamaz...","Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Binary = new Image<Gray, byte>(gri.Width, gri.Height, new Gray(0));

            CvInvoke.Threshold(gri, Binary, 50, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            ımageBox1.Image = Binary;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_inputimage == null || gri == null || Binary == null)
            {
                MessageBox.Show("Resim Yükleme İşlemi Gerçekleşmeden Histogram İşlemi Yapılamaz...\nGri Image & Binary Image döşümü yapılmadan histogram grafiği çizilemez..", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            histogramBox1.ClearHistogram();
            histogramBox2.ClearHistogram();
            histogramBox3.ClearHistogram();

            histogramBox1.GenerateHistograms(_inputimage, 256);
            histogramBox2.GenerateHistograms(Binary, 256);
            histogramBox3.GenerateHistograms(gri, 256);

            histogramBox1.Refresh();
            histogramBox2.Refresh();
            histogramBox3.Refresh();


        }
    }
    }

