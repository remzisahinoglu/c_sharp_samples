using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int horizotal = 30;
            int vertical = 30;
            Button[] buttonArray = new Button[10];

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Name = i.ToString();
                buttonArray[i].Size = new Size(60, 23);
                buttonArray[i].Location = new Point(horizotal, vertical);
                buttonArray[i].Click += new EventHandler(this.ButtonArray_click);   // click event yükle

                if ((i + 1) % 9 == 0) horizotal = +80;
                else vertical += 30;
                this.Controls.Add(buttonArray[i]);
            }
        }

        // Click eventını çağırmak için
        void ButtonArray_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            MessageBox.Show(btn.Name);
        }
    }
}
