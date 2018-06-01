namespace EmguCV
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ımageBox3 = new Emgu.CV.UI.ImageBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageBox4 = new Emgu.CV.UI.ImageBox();
            this.button3 = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageBox1 = new Emgu.CV.UI.ImageBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resim Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageBox3
            // 
            this.ımageBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ımageBox3.Location = new System.Drawing.Point(322, 66);
            this.ımageBox3.Name = "ımageBox3";
            this.ımageBox3.Size = new System.Drawing.Size(300, 202);
            this.ımageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ımageBox3.TabIndex = 2;
            this.ımageBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Histogram";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageBox4
            // 
            this.ımageBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ımageBox4.Location = new System.Drawing.Point(16, 66);
            this.ımageBox4.Name = "ımageBox4";
            this.ımageBox4.Size = new System.Drawing.Size(300, 202);
            this.ımageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ımageBox4.TabIndex = 5;
            this.ımageBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Gri Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.histogramBox1.Location = new System.Drawing.Point(16, 274);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(300, 255);
            this.histogramBox1.TabIndex = 4;
            // 
            // histogramBox3
            // 
            this.histogramBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.histogramBox3.Location = new System.Drawing.Point(322, 274);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(300, 255);
            this.histogramBox3.TabIndex = 7;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageBox1
            // 
            this.ımageBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ımageBox1.Location = new System.Drawing.Point(628, 66);
            this.ımageBox1.Name = "ımageBox1";
            this.ımageBox1.Size = new System.Drawing.Size(300, 202);
            this.ımageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ımageBox1.TabIndex = 2;
            this.ımageBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Binary";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rgb Resmi :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gri Resim :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Binary Resim :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rgb Histogram :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gri Histogram :";
            // 
            // histogramBox2
            // 
            this.histogramBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.histogramBox2.Location = new System.Drawing.Point(628, 274);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(300, 255);
            this.histogramBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Binary Histogram :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 567);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ımageBox4);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ımageBox1);
            this.Controls.Add(this.ımageBox3);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Görüntü İşleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox ımageBox3;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox ımageBox4;
        private System.Windows.Forms.Button button3;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox3;
        private System.Windows.Forms.ImageList ımageList1;
        private Emgu.CV.UI.ImageBox ımageBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private System.Windows.Forms.Label label6;
    }
}

