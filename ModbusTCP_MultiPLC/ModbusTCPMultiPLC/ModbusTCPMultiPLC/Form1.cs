using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace ModbusTCPMultiPLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOkuBaslat_Click(object sender, EventArgs e)
        {
            TimerOku.Interval = 500;
            TimerOku.Enabled = true;
            
        }

        private void BtnOkuDur_Click(object sender, EventArgs e)
        {
            TimerOku.Enabled = false;
        }

        private void TimerOku_Tick(object sender, EventArgs e)
        {
            try
            {
                // sınıfı oluştur
                ModbusClient TcpClient = new ModbusClient(Convert.ToString(TxTIPAdress.Text), Convert.ToInt16(TxtPortNo.Text));
                ModbusClient TcpClient2 = new ModbusClient(Convert.ToString(TxTIPAdress2.Text), Convert.ToInt16(TxtPortNo2.Text));

                // bağlan
                TcpClient.Connect();
                TcpClient2.Connect();

                // plc inputlarını oku
                bool[] digital_input = TcpClient.ReadDiscreteInputs(0, 17);
                bool[] digital_input2 = TcpClient2.ReadDiscreteInputs(0, 7);

                

                TxtOkunanVeri.Clear();
                TxtOkunanVeri2.Clear();

                TxtOkunanVeri.Text += "okunan input adedi: " + digital_input.Length.ToString() + "\r\n";
                TxtOkunanVeri2.Text += "okunan input adedi: " + digital_input2.Length.ToString() + "\r\n";

                for (int i = 0; i < 17; i++)
                {
                    TxtOkunanVeri.Text += i + ": " + digital_input[i].ToString() + "\r\n";

                    if (i < 7)
                    {
                        TxtOkunanVeri2.Text += i + ": " + digital_input2[i].ToString() + "\r\n";
                    }
                }
            }
            catch (Exception err)
            {
                TxtOkunanVeri.Text += err.ToString() + "\r\n";
            }
        }


    }
}
