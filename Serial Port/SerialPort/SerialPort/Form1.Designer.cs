namespace SerialPort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.LabelBaglanti = new System.Windows.Forms.Label();
            this.TxtGelen = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.ChkDebug = new System.Windows.Forms.CheckBox();
            this.TxtGiden = new System.Windows.Forms.TextBox();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.BtnBaglan = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.CmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.CmbPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.LabelBaglanti);
            this.groupBox7.Controls.Add(this.TxtGelen);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label42);
            this.groupBox7.Controls.Add(this.ChkDebug);
            this.groupBox7.Controls.Add(this.TxtGiden);
            this.groupBox7.Controls.Add(this.BtnTemizle);
            this.groupBox7.Controls.Add(this.BtnGonder);
            this.groupBox7.Controls.Add(this.BtnBaglan);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.CmbBaudRate);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.CmbPort);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(404, 462);
            this.groupBox7.TabIndex = 66;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Debimetre Terminal";
            // 
            // LabelBaglanti
            // 
            this.LabelBaglanti.AutoSize = true;
            this.LabelBaglanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelBaglanti.Location = new System.Drawing.Point(136, 78);
            this.LabelBaglanti.Name = "LabelBaglanti";
            this.LabelBaglanti.Size = new System.Drawing.Size(56, 13);
            this.LabelBaglanti.TabIndex = 37;
            this.LabelBaglanti.Text = "Hat Kapalı";
            // 
            // TxtGelen
            // 
            this.TxtGelen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGelen.Location = new System.Drawing.Point(6, 113);
            this.TxtGelen.Multiline = true;
            this.TxtGelen.Name = "TxtGelen";
            this.TxtGelen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtGelen.Size = new System.Drawing.Size(393, 298);
            this.TxtGelen.TabIndex = 22;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 98);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(61, 13);
            this.label37.TabIndex = 23;
            this.label37.Text = "Gelen Data";
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(2, 418);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(84, 13);
            this.label42.TabIndex = 24;
            this.label42.Text = "Gönderilen Data";
            // 
            // ChkDebug
            // 
            this.ChkDebug.AutoSize = true;
            this.ChkDebug.Location = new System.Drawing.Point(62, 77);
            this.ChkDebug.Name = "ChkDebug";
            this.ChkDebug.Size = new System.Drawing.Size(56, 17);
            this.ChkDebug.TabIndex = 33;
            this.ChkDebug.Text = "debug";
            this.ChkDebug.UseVisualStyleBackColor = true;
            // 
            // TxtGiden
            // 
            this.TxtGiden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGiden.Location = new System.Drawing.Point(5, 435);
            this.TxtGiden.Name = "TxtGiden";
            this.TxtGiden.Size = new System.Drawing.Size(260, 20);
            this.TxtGiden.TabIndex = 25;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.Image")));
            this.BtnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTemizle.Location = new System.Drawing.Point(272, 23);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(127, 48);
            this.BtnTemizle.TabIndex = 32;
            this.BtnTemizle.Text = "  TEMİZLE";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGonder
            // 
            this.BtnGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGonder.Image = ((System.Drawing.Image)(resources.GetObject("BtnGonder.Image")));
            this.BtnGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGonder.Location = new System.Drawing.Point(272, 417);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(127, 39);
            this.BtnGonder.TabIndex = 26;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // BtnBaglan
            // 
            this.BtnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaglan.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaglan.Image")));
            this.BtnBaglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaglan.Location = new System.Drawing.Point(139, 23);
            this.BtnBaglan.Name = "BtnBaglan";
            this.BtnBaglan.Size = new System.Drawing.Size(127, 48);
            this.BtnBaglan.TabIndex = 31;
            this.BtnBaglan.Text = "Bağlan";
            this.BtnBaglan.UseVisualStyleBackColor = true;
            this.BtnBaglan.Click += new System.EventHandler(this.BtnBaglan_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 26);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(53, 13);
            this.label43.TabIndex = 27;
            this.label43.Text = "COM Port";
            // 
            // CmbBaudRate
            // 
            this.CmbBaudRate.FormattingEnabled = true;
            this.CmbBaudRate.Location = new System.Drawing.Point(62, 50);
            this.CmbBaudRate.Name = "CmbBaudRate";
            this.CmbBaudRate.Size = new System.Drawing.Size(71, 21);
            this.CmbBaudRate.TabIndex = 30;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 50);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(58, 13);
            this.label44.TabIndex = 28;
            this.label44.Text = "Baud Rate";
            // 
            // CmbPort
            // 
            this.CmbPort.FormattingEnabled = true;
            this.CmbPort.Location = new System.Drawing.Point(62, 23);
            this.CmbPort.Name = "CmbPort";
            this.CmbPort.Size = new System.Drawing.Size(71, 21);
            this.CmbPort.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 483);
            this.Controls.Add(this.groupBox7);
            this.Name = "Form1";
            this.Text = "Serial Port";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label LabelBaglanti;
        private System.Windows.Forms.TextBox TxtGelen;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.CheckBox ChkDebug;
        private System.Windows.Forms.TextBox TxtGiden;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Button BtnBaglan;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox CmbBaudRate;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox CmbPort;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

