using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailAtmaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("xxx");

                mail.From = new MailAddress(TxtGonderen.Text);
                mail.To.Add(TxtAlici.Text);
                mail.Subject = TxtKonu.Text;
                mail.Body = TxtKonu.Text;

                SmtpServer.Port = 25;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString() + "\r\n" + err.StackTrace);
            }
        }
    }
}
