using System;
using System.Windows.Forms;

namespace ClickBarChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Chart1.Series["Series1"].Points.AddXY("Elma", 3);
            Chart1.Series["Series1"].Points.AddXY("Armut", 5);
            Chart1.Series["Series1"].Points.AddXY("Muz", 4);
            Chart1.Series["Series1"].Points.AddXY("Karpuz", 1);
        }

        private void Chart1_MouseClick(object sender, MouseEventArgs e)
        {
            // hittest metodu ile grafikteki tıklanan koordinatları yakala
            var result = Chart1.HitTest(e.X, e.Y);

            // bu koordinatlara karşılık gelen noktaların x labellerini bul
            string s = Chart1.Series[0].Points[result.PointIndex].AxisLabel.ToString();

            // bu koordinatlara karşılık gelen noktaların x ve y datalarını bul
            var i = Chart1.Series[0].Points[result.PointIndex];

            // ekranda göster
            MessageBox.Show(s + "\r\n" + i);
        }
    }
}