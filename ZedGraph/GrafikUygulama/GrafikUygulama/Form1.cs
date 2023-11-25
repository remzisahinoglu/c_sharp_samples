// www.kaizen40.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ZedGraph;


namespace GrafikUygulama
{
    public partial class Form1 : Form
    {
        string Gelen = string.Empty;
        string[] ports = SerialPort.GetPortNames();

        string ArduinoGelen = "";

        private int i = 0;
        
        GraphPane myPane = new GraphPane();                                 // graph oluşturuluyor
        RollingPointPairList listPoints = new RollingPointPairList(40);     // 40 adet bilgi tutuluyor fazlası siliniyor
        LineItem myCurve;                                                   // curve oluşturuluyor


        public Form1()
        {
            InitializeComponent();

            FormClosing += Form1_FormClosing;                                                                                           // form kapatıldığında çalışması için            
            serialPortArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPortArduino_DataReceived);       // barkod serial port kesmesi oluştuğunda
        }

        private void serialPortArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ArduinoGelen = serialPortArduino.ReadLine();                    // string olarak oku

            Invoke(new EventHandler(ArduinoGoster));                        // textbox a yazmak için gönder
        }

        private void ArduinoGoster(object sender, EventArgs e)
        {
            try
            {
                if (chkArduinoDebug.Checked == true)                        // debug tıklı ise datayı ekrana yaz
                {
                    txtArduinoGelen.Text += ArduinoGelen + "\r\n";
                }
            }
            catch (Exception hata)
            {
                if (chkArduinoDebug.Checked == true)
                {
                    txtArduinoGelen.Text += hata;        // hatayı terminale yaz
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortArduino.IsOpen == true)
            {
                serialPortArduino.Close();          // Barkod okuyucu portu açıksa çıkarken kapat
            }

            if (serialPortArduino.IsOpen == true)
            {
                serialPortArduino.Close();         // Arduino portu açıksa çıkarken kapat
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in ports)                              // pc ye takılı olan device ların portlarını ekle
            {
                cmbArduinoPort.Items.Add(port);
            }

            cmbArduinoBaudRate.Items.Add("300");
            cmbArduinoBaudRate.Items.Add("600");
            cmbArduinoBaudRate.Items.Add("1200");
            cmbArduinoBaudRate.Items.Add("2400");
            cmbArduinoBaudRate.Items.Add("4800");
            cmbArduinoBaudRate.Items.Add("9600");
            cmbArduinoBaudRate.Items.Add("19200");
            cmbArduinoBaudRate.Items.Add("57600");
            cmbArduinoBaudRate.Items.Add("115200");

            cmbArduinoBaudRate.SelectedIndex = 5;
           
            myPane = zedGraphControl1.GraphPane;
            myPane.XAxis.Title.Text = "Zedgraph";
            myPane.XAxis.Title.Text = "Zaman(sn)";
            myPane.YAxis.Title.Text = "Basınç(bar)";

            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
            
        }

        private void btnArduinoBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnArduinoBaglan.Text == "Bağlan")   // bağlantıyı kes
                {
                    btnArduinoBaglan.Text = "Bağlantıyı Kes";
                    labelArduinoBaglanti.Text = cmbArduinoPort.Text + "," + cmbArduinoBaudRate.Text + ", Hat Açık";
                    serialPortArduino.PortName = cmbArduinoPort.Text;
                    serialPortArduino.BaudRate = Convert.ToInt32(cmbArduinoBaudRate.Text);
                    serialPortArduino.Open();     // portu aç
                }
                else// bağlan
                {
                    btnArduinoBaglan.Text = "Bağlan";
                    labelArduinoBaglanti.Text = "Hat Kapalı";
                    serialPortArduino.Close();    // portu kapat
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnArduinoTemizle_Click(object sender, EventArgs e)
        {
            txtArduinoGelen.Clear();
        }

        private void btnArduinoGonder_Click(object sender, EventArgs e)
        {
            if (serialPortArduino.IsOpen == true)
            {
                serialPortArduino.Write(txtArduinoGiden.Text);       // textbox ta yaz
            }
            else
            {
                MessageBox.Show("Port kapalıyken data gönderilemez!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // zedgraph a her gelen datayı yükle
                i++;

                double x = i;              
                double y = Convert.ToDouble(ArduinoGelen);      // gelen değere göre interpolasyon yapabilirsiniz

                double limit = 500;    // LİMİT DEGERİ

                LineObj threshHoldLine = new LineObj(Color.Red, myPane.XAxis.Scale.Min, limit, myPane.XAxis.Scale.Max, limit);
                myPane.GraphObjList.Add(threshHoldLine);

                listPoints.Add(x, y);
                myCurve = myPane.AddCurve(null, listPoints, Color.Blue);

                // ekranı scaleini ayarla
                myPane.YAxis.Scale.Min = 0;
                myPane.YAxis.Scale.Max = 10;


                zedGraphControl1.Invalidate();
                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void BtnCiz_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void BtnDur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            listPoints.Clear();
            i = 0;
        }
    }
}
