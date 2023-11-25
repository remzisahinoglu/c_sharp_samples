// www.kaizen40.com

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ImportExcelToDatagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            //file.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";  
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Excel Dosyası Seçiniz..";
            file.ShowDialog();

            //string DosyaYolu = file.FileName;
            //string DosyaAdi = file.SafeFileName;
            TxtAdres.Text = file.FileName;
        }

        private void BtnOku_Click(object sender, EventArgs e)
        {
            string constr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + TxtAdres.Text + "; Extended Properties =\"Excel 8.0; HDR = Yes;\";";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + TxtSayfa.Text + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            advancedDataGridView1.DataSource = data;
            bindingSource1.DataSource = data;

            con.Close();
        }

        private void advancedDataGridView1_SortStringChanged_1(object sender, EventArgs e)
        {
            bindingSource1.Sort = advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged_1(object sender, EventArgs e)
        {
            bindingSource1.Filter = advancedDataGridView1.FilterString;
        }
    }
}