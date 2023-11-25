using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace AsyncTcpClient
{
    public partial class Form1 : Form
    {
        private Socket client;
        private byte[] data = new byte[1024];
        private int size = 1024;
        private string GelenVeri;
        private string durum;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBaglan_Click(object sender, EventArgs e)
        {
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(TxtIpNo.Text), Convert.ToInt32(TxtPort.Text));
            newsock.BeginConnect(iep, new AsyncCallback(Connected), newsock);
        }

        private void Connected(IAsyncResult ar)
        {
            client = (Socket)ar.AsyncState;
            try
            {
                client.EndConnect(ar);
                //Invoke(new EventHandler(BaglantiDurumu));     // buda ikinci yol    

                if (TxtGelen.InvokeRequired)            // thread çakışması olduğu için başka bir fonksiyonda çalıştırmak gerekiyor.
                {
                    TxtGelen.Invoke(new MethodInvoker(delegate { TxtGelen.Text = "Connected to: " + client.RemoteEndPoint.ToString() + "\r\n"; }));
                }

                client.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), client);
            }
            catch (SocketException)
            {
                TxtGelen.Text = "Error connecting";
            }
        }

        /*
        private void BaglantiDurumu(object sender, EventArgs e)
        {
            TxtGelen.Text = "Connected to: " + client.RemoteEndPoint.ToString();
        }
        */

        private void ReceiveData(IAsyncResult ar)
        {
            try
            {           
                Socket remote = (Socket)ar.AsyncState;
                int recv = remote.EndReceive(ar);
                string stringData = Encoding.ASCII.GetString(data, 0, recv);
                //results.Items.Add(stringData);


                GelenVeri = BitConverter.ToString(data,0,recv); //.Replace("-", "");

                /*
                if (GelenVeri.Substring(18, 30) == "08-03-00-05-00-01")
                {
                    durum = "ok";
                }
                else
                {
                    durum = "";
                }
                */

                if (TxtGelen.InvokeRequired)            // thread çakışması olduğu için başka bir fonksiyonda çalıştırmak gerekiyor.
                {
                    TxtGelen.Invoke(new MethodInvoker(delegate
                    {

                        TxtGelen.Text += GelenVeri + "  " + durum + "\r\n";

                    }));
                }
                
                // tekrar okumayı başlat
                remote.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), remote);
            }
            catch (Exception)
            {
                client.Close();     // kapanırken hata çıktığı için burada kapatılıyor
            }
        }

        private void BtnKes_Click(object sender, EventArgs e)
        {
            client.Close();
            client.Dispose();
            TxtGiden.Text = "Disconnected";
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                //byte[] message = Encoding.ASCII.GetBytes(TxtGiden.Text);

                byte[] message = { 0x07, 0xB6, 0x00, 0x00, 0x00, 0x06, Convert.ToByte(TxtSlaveID.Text), 0x03, 0x00, 0x05, 0x00, 0x01};

                client.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(SendData), client);
            }
            catch (Exception hata)
            {
                TxtGelen.Text = hata.ToString();
            }
        }

        private void SendData(IAsyncResult ar)
        {
            try
            { 
                Socket remote = (Socket)ar.AsyncState;
                int sent = remote.EndSend(ar);
                remote.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), remote);
            }
            catch (Exception hata)
            {
                TxtGelen.Text = hata.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtGelen.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TxtSlaveID.Text = (Convert.ToInt32(TxtSlaveID.Text) + 1).ToString();

            if (Convert.ToInt32(TxtSlaveID.Text) == 100)
            {
                TxtSlaveID.Text = "90";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //timer1.Enabled = true;
        }
    }
}
