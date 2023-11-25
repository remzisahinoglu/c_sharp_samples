namespace ModbusTCPMultiPLC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxTIPAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPortNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOkunanVeri = new System.Windows.Forms.TextBox();
            this.BtnOkuBaslat = new System.Windows.Forms.Button();
            this.BtnOkuDur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TimerOku = new System.Windows.Forms.Timer(this.components);
            this.TxtPortNo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxTIPAdress2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOkunanVeri2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxTIPAdress
            // 
            this.TxTIPAdress.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxTIPAdress.Location = new System.Drawing.Point(230, 37);
            this.TxTIPAdress.Name = "TxTIPAdress";
            this.TxTIPAdress.Size = new System.Drawing.Size(169, 30);
            this.TxTIPAdress.TabIndex = 4;
            this.TxTIPAdress.Text = "192.168.0.14";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "PLC IP Adresi:";
            // 
            // TxtPortNo
            // 
            this.TxtPortNo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPortNo.Location = new System.Drawing.Point(482, 37);
            this.TxtPortNo.Name = "TxtPortNo";
            this.TxtPortNo.Size = new System.Drawing.Size(69, 30);
            this.TxtPortNo.TabIndex = 6;
            this.TxtPortNo.Text = "502";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(419, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port:";
            // 
            // TxtOkunanVeri
            // 
            this.TxtOkunanVeri.Location = new System.Drawing.Point(83, 160);
            this.TxtOkunanVeri.Multiline = true;
            this.TxtOkunanVeri.Name = "TxtOkunanVeri";
            this.TxtOkunanVeri.Size = new System.Drawing.Size(206, 253);
            this.TxtOkunanVeri.TabIndex = 7;
            // 
            // BtnOkuBaslat
            // 
            this.BtnOkuBaslat.Location = new System.Drawing.Point(596, 160);
            this.BtnOkuBaslat.Name = "BtnOkuBaslat";
            this.BtnOkuBaslat.Size = new System.Drawing.Size(123, 51);
            this.BtnOkuBaslat.TabIndex = 8;
            this.BtnOkuBaslat.Text = "Okumayı Başlat";
            this.BtnOkuBaslat.UseVisualStyleBackColor = true;
            this.BtnOkuBaslat.Click += new System.EventHandler(this.BtnOkuBaslat_Click);
            // 
            // BtnOkuDur
            // 
            this.BtnOkuDur.Location = new System.Drawing.Point(596, 217);
            this.BtnOkuDur.Name = "BtnOkuDur";
            this.BtnOkuDur.Size = new System.Drawing.Size(123, 51);
            this.BtnOkuDur.TabIndex = 9;
            this.BtnOkuDur.Text = "Okumayı Durdur";
            this.BtnOkuDur.UseVisualStyleBackColor = true;
            this.BtnOkuDur.Click += new System.EventHandler(this.BtnOkuDur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Okunan Veri";
            // 
            // TimerOku
            // 
            this.TimerOku.Tick += new System.EventHandler(this.TimerOku_Tick);
            // 
            // TxtPortNo2
            // 
            this.TxtPortNo2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPortNo2.Location = new System.Drawing.Point(482, 73);
            this.TxtPortNo2.Name = "TxtPortNo2";
            this.TxtPortNo2.Size = new System.Drawing.Size(69, 30);
            this.TxtPortNo2.TabIndex = 14;
            this.TxtPortNo2.Text = "502";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(419, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Port:";
            // 
            // TxTIPAdress2
            // 
            this.TxTIPAdress2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxTIPAdress2.Location = new System.Drawing.Point(230, 73);
            this.TxTIPAdress2.Name = "TxTIPAdress2";
            this.TxTIPAdress2.Size = new System.Drawing.Size(169, 30);
            this.TxTIPAdress2.TabIndex = 12;
            this.TxTIPAdress2.Text = "192.168.0.15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(78, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "PLC IP Adresi:";
            // 
            // TxtOkunanVeri2
            // 
            this.TxtOkunanVeri2.Location = new System.Drawing.Point(360, 160);
            this.TxtOkunanVeri2.Multiline = true;
            this.TxtOkunanVeri2.Name = "TxtOkunanVeri2";
            this.TxtOkunanVeri2.Size = new System.Drawing.Size(206, 253);
            this.TxtOkunanVeri2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(355, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Okunan Veri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtOkunanVeri2);
            this.Controls.Add(this.TxtPortNo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxTIPAdress2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnOkuDur);
            this.Controls.Add(this.BtnOkuBaslat);
            this.Controls.Add(this.TxtOkunanVeri);
            this.Controls.Add(this.TxtPortNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxTIPAdress);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "ModbusTCP - Multi PLC Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxTIPAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPortNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOkunanVeri;
        private System.Windows.Forms.Button BtnOkuBaslat;
        private System.Windows.Forms.Button BtnOkuDur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TimerOku;
        private System.Windows.Forms.TextBox TxtPortNo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxTIPAdress2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtOkunanVeri2;
        private System.Windows.Forms.Label label6;
    }
}

