/* yazan: www.kaizen40.com
 * tarih: 01.05.2018
 * 
 * açıklama: seri port terminal programı
 */

using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace SerialPort
{
    public partial class Form1 : Form
    {
        string[] ports = System.IO.Ports.SerialPort.GetPortNames();            // port bilgisinin tutulduğu yer
        private string GelenVeri;
        private string[] HallEffectSensor = new string[16];     // hall effect sensorlerin verileri için
        private bool paket_kod;

        public Form1()
        {
            InitializeComponent();

            FormClosing += Form1_FormClosing;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataRecieved);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in ports)                              // pc ye takılı olan device ların portlarını ekle
            {
                CmbPort.Items.Add(port);
            }

            // baudrate leri yükle
            CmbBaudRate.Items.Add("300");
            CmbBaudRate.Items.Add("600");
            CmbBaudRate.Items.Add("1200");
            CmbBaudRate.Items.Add("2400");
            CmbBaudRate.Items.Add("4800");
            CmbBaudRate.Items.Add("9600");
            CmbBaudRate.Items.Add("19200");
            CmbBaudRate.Items.Add("57600");
            CmbBaudRate.Items.Add("115200");

            CmbBaudRate.SelectedIndex = 8;  // 115200
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }

        private void SerialPort1_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //Thread.Sleep(30);   // verinin tamamen gelmesini bekle

                GelenVeri =  serialPort1.ReadExisting();

                for (int i = 0; i < GelenVeri.Length; i++)
                {
                    char c = GelenVeri[i];

                    if (c == '\r')
                    {
                        paket_kod = true;
                    }
                    else
                    {
                        paket_kod = false;
                    }

                    if (paket_kod == true)
                    {

                    }
                }

                Console.WriteLine(GelenVeri);





                
                //Invoke(new EventHandler(Goster));                    // textbox a yazmak için invoke oluştur
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        /*
        private void Goster(object sender, EventArgs e)
        {
            TxtGelen.Text += GelenVeri + "\r\n";// + fdeger.ToString() + "\r\n";
        }
        */

        private void BtnBaglan_Click(object sender, EventArgs e)
        {
            if (BtnBaglan.Text == "Bağlan")    
            {
                BtnBaglan.Text = "Bağlantıyı Kes";
                LabelBaglanti.Text = CmbPort.Text + "," + CmbBaudRate.Text + ", Hat Açık";
                serialPort1.PortName = CmbPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(CmbBaudRate.Text);
                serialPort1.Open();
            }
            else// bağlan
            {
                BtnBaglan.Text = "Bağlan";
                LabelBaglanti.Text = "Hat Kapalı";
                serialPort1.Close();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtGelen.Clear();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                byte[] bytestosend = { 0x01, 0x03, 0x00, 0x04, 0x00, 0x04, 0x05, 0xC8 };

                serialPort1.Write(bytestosend, 0, bytestosend.Length);

            }
            else
            {
                MessageBox.Show("Port kapalıyken data gönderilemez!");
            }
        }
    }
}
