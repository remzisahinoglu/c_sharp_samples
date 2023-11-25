// www.kaizen40.com

using System;
using System.Windows.Forms;

namespace pictureboxdragdrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.DragEnter += PictureBox1_DragEnter;
            pictureBox1.DragDrop += PictureBox1_DragDrop;
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);     // resmin uzantısını al

            for (int i = 0; i < s.Length; i++)
            {
                pictureBox1.ImageLocation = s[i];                       // picturebox'a yükle
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;     // resmimizi pictureboxa göre boyutlandır
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;                               // picturebox nesnesinin sürükle bırak özelliğini aktifleştir.
        }

        private void BtnResimSil_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = null;                           // resmi sil
        }
    }
}
