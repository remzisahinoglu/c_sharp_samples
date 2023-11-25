namespace AsyncTcpClient
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
            this.TxtGiden = new System.Windows.Forms.TextBox();
            this.TxtGelen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBaglan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIpNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.BtnKes = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSlaveID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TxtGiden
            // 
            this.TxtGiden.Location = new System.Drawing.Point(27, 156);
            this.TxtGiden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtGiden.Name = "TxtGiden";
            this.TxtGiden.Size = new System.Drawing.Size(264, 22);
            this.TxtGiden.TabIndex = 0;
            // 
            // TxtGelen
            // 
            this.TxtGelen.Location = new System.Drawing.Point(27, 207);
            this.TxtGelen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtGelen.Multiline = true;
            this.TxtGelen.Name = "TxtGelen";
            this.TxtGelen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtGelen.Size = new System.Drawing.Size(385, 680);
            this.TxtGelen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giden";
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(300, 150);
            this.BtnGonder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(113, 34);
            this.BtnGonder.TabIndex = 3;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giden";
            // 
            // BtnBaglan
            // 
            this.BtnBaglan.Location = new System.Drawing.Point(300, 16);
            this.BtnBaglan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBaglan.Name = "BtnBaglan";
            this.BtnBaglan.Size = new System.Drawing.Size(113, 34);
            this.BtnBaglan.TabIndex = 5;
            this.BtnBaglan.Text = "Bağlan";
            this.BtnBaglan.UseVisualStyleBackColor = true;
            this.BtnBaglan.Click += new System.EventHandler(this.BtnBaglan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP No";
            // 
            // TxtIpNo
            // 
            this.TxtIpNo.Location = new System.Drawing.Point(27, 42);
            this.TxtIpNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIpNo.Name = "TxtIpNo";
            this.TxtIpNo.Size = new System.Drawing.Size(167, 22);
            this.TxtIpNo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(203, 42);
            this.TxtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(88, 22);
            this.TxtPort.TabIndex = 8;
            this.TxtPort.Text = "502";
            // 
            // BtnKes
            // 
            this.BtnKes.Location = new System.Drawing.Point(300, 58);
            this.BtnKes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnKes.Name = "BtnKes";
            this.BtnKes.Size = new System.Drawing.Size(113, 34);
            this.BtnKes.TabIndex = 10;
            this.BtnKes.Text = "Kes";
            this.BtnKes.UseVisualStyleBackColor = true;
            this.BtnKes.Click += new System.EventHandler(this.BtnKes_Click);
            // 
            // results
            // 
            this.results.FormattingEnabled = true;
            this.results.ItemHeight = 16;
            this.results.Location = new System.Drawing.Point(440, 15);
            this.results.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(196, 388);
            this.results.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Slave ID";
            // 
            // TxtSlaveID
            // 
            this.TxtSlaveID.Location = new System.Drawing.Point(27, 94);
            this.TxtSlaveID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSlaveID.Name = "TxtSlaveID";
            this.TxtSlaveID.Size = new System.Drawing.Size(167, 22);
            this.TxtSlaveID.TabIndex = 12;
            this.TxtSlaveID.Text = "90";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 588);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 902);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSlaveID);
            this.Controls.Add(this.results);
            this.Controls.Add(this.BtnKes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIpNo);
            this.Controls.Add(this.BtnBaglan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtGelen);
            this.Controls.Add(this.TxtGiden);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Async TCP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtGiden;
        private System.Windows.Forms.TextBox TxtGelen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBaglan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIpNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Button BtnKes;
        private System.Windows.Forms.ListBox results;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSlaveID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

