using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using EasyModbus;

namespace TCP_Haberlerşme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //Client tanımlama
                ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
                //                
                //Bağlan
                tcpclient.Connect();  
                //
                //okuma
                //
                int a = Convert.ToInt32(textBox2.Text);
                int b = Convert.ToInt32(textBox3.Text);
                int c = Convert.ToInt32(textBox4.Text);
                int d = 2 * Convert.ToInt32(textBox5.Text);
                int ee = Convert.ToInt32(textBox6.Text);
                int ff = Convert.ToInt32(textBox14.Text);
                //
                //okuma
                //
                bool[] mb = tcpclient.ReadCoils(0 + a, 1);
                bool[] ip = tcpclient.ReadDiscreteInputs(0 + ee,1);
                bool[] qp = tcpclient.ReadCoils(2000 + ff, 1);                
                int[] mw = tcpclient.ReadHoldingRegisters(0 + b, 1);
                int[] mi = tcpclient.ReadHoldingRegisters(1000 + c, 2);
                int[] mf = tcpclient.ReadHoldingRegisters(4000 + d, 2);
                //
                double mii = ModbusClient.ConvertRegistersToDouble(mi);
                //
                float mff = ModbusClient.ConvertRegistersToFloat(mf);

                
                
               
                //   
                //labela yazma
                //
                label7.Text = Convert.ToString(mb[0]);
                label8.Text = Convert.ToString(mw[0]);
                label12.Text = Convert.ToString(mii);
                label13.Text = Convert.ToString(mff);
                label18.Text = Convert.ToString(ip[0]);
                label21.Text = Convert.ToString(qp[0]);
                
            }
            //
            //hata yakalama
            catch (Exception)
            { timer1.Stop(); MessageBox.Show("Hata"); }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //okuma offset girdileri lock
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox14.Enabled = false;

            //yazma değerleri unlock
            comboBox1.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;

            //yazma butonları unlock
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;

            //yazma offsetleri unlock
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;            
            
            //timer on
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //okuma offset girdileri unlock
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox14.Enabled = true;

            //yazma değerleri lock
            comboBox1.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;

            //yazma butonları lock
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

            //yazma offsetleri lock
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            
            //timer off
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //mb yazma butonu
            ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
            tcpclient.Connect(); 
            bool bitvalue = false;
            //
            if (comboBox1.Text == "True") bitvalue = true;
            if (comboBox1.Text == "False") bitvalue = false;
            //
            int aa = Convert.ToInt32(textBox10.Text);

            tcpclient.WriteSingleCoil(0 + aa, bitvalue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //mw yazma butonu
            ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
            tcpclient.Connect(); 
            int bb = Convert.ToInt32(textBox11.Text);

            tcpclient.WriteSingleRegister(0 + bb, Convert.ToInt32(textBox7.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //mi yazma butonu
            ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
            tcpclient.Connect(); 
            int cc = 2 * Convert.ToInt32(textBox12.Text);

            int[] mideger = ModbusClient.ConvertDoubleToTwoRegisters(Convert.ToInt32(textBox8.Text));

            tcpclient.WriteSingleRegister(1000 + cc, mideger[0]);
            tcpclient.WriteSingleRegister(1001 + cc, mideger[1]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //mf yazma butonu
            ModbusClient tcpclient = new ModbusClient(Convert.ToString(textBox1.Text), 502);
            tcpclient.Connect(); 
            int dd = 2 * Convert.ToInt32(textBox13.Text);

            float mff = float.Parse(textBox9.Text);

            int[] mfdeger = ModbusClient.ConvertFloatToTwoRegisters(mff);
            
            tcpclient.WriteSingleRegister(4000 + dd, mfdeger[0]);
            tcpclient.WriteSingleRegister(4001 + dd, mfdeger[1]);
        }
             
       
    }     
       
       
}

