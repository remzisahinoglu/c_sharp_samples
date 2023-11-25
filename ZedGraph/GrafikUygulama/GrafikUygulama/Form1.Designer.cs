namespace GrafikUygulama
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
            this.labelArduinoBaglanti = new System.Windows.Forms.Label();
            this.txtArduinoGelen = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.chkArduinoDebug = new System.Windows.Forms.CheckBox();
            this.txtArduinoGiden = new System.Windows.Forms.TextBox();
            this.btnArduinoTemizle = new System.Windows.Forms.Button();
            this.btnArduinoGonder = new System.Windows.Forms.Button();
            this.btnArduinoBaglan = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.cmbArduinoBaudRate = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.cmbArduinoPort = new System.Windows.Forms.ComboBox();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnCiz = new System.Windows.Forms.Button();
            this.BtnDur = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelArduinoBaglanti);
            this.groupBox7.Controls.Add(this.txtArduinoGelen);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label42);
            this.groupBox7.Controls.Add(this.chkArduinoDebug);
            this.groupBox7.Controls.Add(this.txtArduinoGiden);
            this.groupBox7.Controls.Add(this.btnArduinoTemizle);
            this.groupBox7.Controls.Add(this.btnArduinoGonder);
            this.groupBox7.Controls.Add(this.btnArduinoBaglan);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.cmbArduinoBaudRate);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.cmbArduinoPort);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(306, 499);
            this.groupBox7.TabIndex = 39;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Arduino COMPORT";
            // 
            // labelArduinoBaglanti
            // 
            this.labelArduinoBaglanti.AutoSize = true;
            this.labelArduinoBaglanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelArduinoBaglanti.Location = new System.Drawing.Point(166, 27);
            this.labelArduinoBaglanti.Name = "labelArduinoBaglanti";
            this.labelArduinoBaglanti.Size = new System.Drawing.Size(56, 13);
            this.labelArduinoBaglanti.TabIndex = 37;
            this.labelArduinoBaglanti.Text = "Hat Kapalı";
            // 
            // txtArduinoGelen
            // 
            this.txtArduinoGelen.Location = new System.Drawing.Point(6, 151);
            this.txtArduinoGelen.Multiline = true;
            this.txtArduinoGelen.Name = "txtArduinoGelen";
            this.txtArduinoGelen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArduinoGelen.Size = new System.Drawing.Size(290, 294);
            this.txtArduinoGelen.TabIndex = 22;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 135);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(61, 13);
            this.label37.TabIndex = 23;
            this.label37.Text = "Gelen Data";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 448);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(84, 13);
            this.label42.TabIndex = 24;
            this.label42.Text = "Gönderilen Data";
            // 
            // chkArduinoDebug
            // 
            this.chkArduinoDebug.AutoSize = true;
            this.chkArduinoDebug.Location = new System.Drawing.Point(169, 51);
            this.chkArduinoDebug.Name = "chkArduinoDebug";
            this.chkArduinoDebug.Size = new System.Drawing.Size(56, 17);
            this.chkArduinoDebug.TabIndex = 33;
            this.chkArduinoDebug.Text = "debug";
            this.chkArduinoDebug.UseVisualStyleBackColor = true;
            // 
            // txtArduinoGiden
            // 
            this.txtArduinoGiden.Location = new System.Drawing.Point(6, 464);
            this.txtArduinoGiden.Name = "txtArduinoGiden";
            this.txtArduinoGiden.Size = new System.Drawing.Size(192, 20);
            this.txtArduinoGiden.TabIndex = 25;
            // 
            // btnArduinoTemizle
            // 
            this.btnArduinoTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArduinoTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnArduinoTemizle.Image")));
            this.btnArduinoTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArduinoTemizle.Location = new System.Drawing.Point(169, 77);
            this.btnArduinoTemizle.Name = "btnArduinoTemizle";
            this.btnArduinoTemizle.Size = new System.Drawing.Size(127, 39);
            this.btnArduinoTemizle.TabIndex = 32;
            this.btnArduinoTemizle.Text = "  TEMİZLE";
            this.btnArduinoTemizle.UseVisualStyleBackColor = true;
            this.btnArduinoTemizle.Click += new System.EventHandler(this.btnArduinoTemizle_Click);
            // 
            // btnArduinoGonder
            // 
            this.btnArduinoGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArduinoGonder.Image = ((System.Drawing.Image)(resources.GetObject("btnArduinoGonder.Image")));
            this.btnArduinoGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArduinoGonder.Location = new System.Drawing.Point(204, 451);
            this.btnArduinoGonder.Name = "btnArduinoGonder";
            this.btnArduinoGonder.Size = new System.Drawing.Size(92, 39);
            this.btnArduinoGonder.TabIndex = 26;
            this.btnArduinoGonder.Text = "   GÖNDER";
            this.btnArduinoGonder.UseVisualStyleBackColor = true;
            this.btnArduinoGonder.Click += new System.EventHandler(this.btnArduinoGonder_Click);
            // 
            // btnArduinoBaglan
            // 
            this.btnArduinoBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArduinoBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btnArduinoBaglan.Image")));
            this.btnArduinoBaglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArduinoBaglan.Location = new System.Drawing.Point(6, 77);
            this.btnArduinoBaglan.Name = "btnArduinoBaglan";
            this.btnArduinoBaglan.Size = new System.Drawing.Size(127, 39);
            this.btnArduinoBaglan.TabIndex = 31;
            this.btnArduinoBaglan.Text = "Bağlan";
            this.btnArduinoBaglan.UseVisualStyleBackColor = true;
            this.btnArduinoBaglan.Click += new System.EventHandler(this.btnArduinoBaglan_Click);
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
            // cmbArduinoBaudRate
            // 
            this.cmbArduinoBaudRate.FormattingEnabled = true;
            this.cmbArduinoBaudRate.Location = new System.Drawing.Point(62, 50);
            this.cmbArduinoBaudRate.Name = "cmbArduinoBaudRate";
            this.cmbArduinoBaudRate.Size = new System.Drawing.Size(71, 21);
            this.cmbArduinoBaudRate.TabIndex = 30;
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
            // cmbArduinoPort
            // 
            this.cmbArduinoPort.FormattingEnabled = true;
            this.cmbArduinoPort.Location = new System.Drawing.Point(62, 23);
            this.cmbArduinoPort.Name = "cmbArduinoPort";
            this.cmbArduinoPort.Size = new System.Drawing.Size(71, 21);
            this.cmbArduinoPort.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnCiz
            // 
            this.BtnCiz.Location = new System.Drawing.Point(357, 38);
            this.BtnCiz.Name = "BtnCiz";
            this.BtnCiz.Size = new System.Drawing.Size(161, 54);
            this.BtnCiz.TabIndex = 41;
            this.BtnCiz.Text = "ÇİZMEYE BAŞLA";
            this.BtnCiz.UseVisualStyleBackColor = true;
            this.BtnCiz.Click += new System.EventHandler(this.BtnCiz_Click);
            // 
            // BtnDur
            // 
            this.BtnDur.Location = new System.Drawing.Point(572, 38);
            this.BtnDur.Name = "BtnDur";
            this.BtnDur.Size = new System.Drawing.Size(161, 54);
            this.BtnDur.TabIndex = 42;
            this.BtnDur.Text = "RESETLE";
            this.BtnDur.UseVisualStyleBackColor = true;
            this.BtnDur.Click += new System.EventHandler(this.BtnDur_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(360, 146);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(587, 330);
            this.zedGraphControl1.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 524);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.BtnDur);
            this.Controls.Add(this.BtnCiz);
            this.Controls.Add(this.groupBox7);
            this.Name = "Form1";
            this.Text = "www.kaizen40.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelArduinoBaglanti;
        private System.Windows.Forms.TextBox txtArduinoGelen;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.CheckBox chkArduinoDebug;
        private System.Windows.Forms.TextBox txtArduinoGiden;
        private System.Windows.Forms.Button btnArduinoTemizle;
        private System.Windows.Forms.Button btnArduinoGonder;
        private System.Windows.Forms.Button btnArduinoBaglan;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cmbArduinoBaudRate;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox cmbArduinoPort;
        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnCiz;
        private System.Windows.Forms.Button BtnDur;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}

