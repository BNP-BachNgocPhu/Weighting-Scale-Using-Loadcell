namespace CalibLoadcell
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
            this.butConnect = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.sendData = new System.Windows.Forms.TextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtDataReceive1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butZero = new System.Windows.Forms.Button();
            this.trackBarZero = new System.Windows.Forms.TrackBar();
            this.trackBarSpan = new System.Windows.Forms.TrackBar();
            this.butSpan = new System.Windows.Forms.Button();
            this.txtspan = new System.Windows.Forms.TextBox();
            this.txtZero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butCalib = new System.Windows.Forms.Button();
            this.CalibReset = new System.Windows.Forms.Button();
            this.txtDataReceive2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpan)).BeginInit();
            this.SuspendLayout();
            // 
            // butConnect
            // 
            this.butConnect.BackColor = System.Drawing.Color.PaleGreen;
            this.butConnect.Location = new System.Drawing.Point(66, 98);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(130, 42);
            this.butConnect.TabIndex = 1;
            this.butConnect.Text = "Connect";
            this.butConnect.UseVisualStyleBackColor = false;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butExit.Location = new System.Drawing.Point(225, 98);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(166, 42);
            this.butExit.TabIndex = 2;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // serCOM
            // 
            this.serCOM.BaudRate = 115200;
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // sendData
            // 
            this.sendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendData.Location = new System.Drawing.Point(225, 355);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(166, 45);
            this.sendData.TabIndex = 7;
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(66, 355);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(130, 47);
            this.butSend.TabIndex = 8;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.cboBaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboComPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(120, 71);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(121, 28);
            this.cboBaudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate: ";
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(120, 26);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 28);
            this.cboComPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM: ";
            // 
            // txtDataReceive1
            // 
            this.txtDataReceive1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataReceive1.Location = new System.Drawing.Point(433, 220);
            this.txtDataReceive1.Name = "txtDataReceive1";
            this.txtDataReceive1.Size = new System.Drawing.Size(611, 53);
            this.txtDataReceive1.TabIndex = 10;
            this.txtDataReceive1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "GIÁ TRỊ CẢM BIẾN LOADCELL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1068, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "(kg)";
            // 
            // butZero
            // 
            this.butZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butZero.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butZero.Location = new System.Drawing.Point(433, 366);
            this.butZero.Name = "butZero";
            this.butZero.Size = new System.Drawing.Size(166, 45);
            this.butZero.TabIndex = 14;
            this.butZero.Text = "Calib-Zero";
            this.butZero.UseVisualStyleBackColor = false;
            this.butZero.Click += new System.EventHandler(this.butZero_Click);
            // 
            // trackBarZero
            // 
            this.trackBarZero.Location = new System.Drawing.Point(574, 303);
            this.trackBarZero.Maximum = 1000;
            this.trackBarZero.Name = "trackBarZero";
            this.trackBarZero.Size = new System.Drawing.Size(482, 56);
            this.trackBarZero.TabIndex = 15;
            this.trackBarZero.Value = 500;
            this.trackBarZero.Scroll += new System.EventHandler(this.trackBarZero_Scroll);
            // 
            // trackBarSpan
            // 
            this.trackBarSpan.Location = new System.Drawing.Point(574, 441);
            this.trackBarSpan.Maximum = 1000;
            this.trackBarSpan.Name = "trackBarSpan";
            this.trackBarSpan.Size = new System.Drawing.Size(470, 56);
            this.trackBarSpan.TabIndex = 17;
            this.trackBarSpan.Value = 500;
            this.trackBarSpan.Scroll += new System.EventHandler(this.trackBarSpan_Scroll);
            // 
            // butSpan
            // 
            this.butSpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butSpan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSpan.Location = new System.Drawing.Point(433, 503);
            this.butSpan.Name = "butSpan";
            this.butSpan.Size = new System.Drawing.Size(166, 45);
            this.butSpan.TabIndex = 18;
            this.butSpan.Text = "Calib-Span";
            this.butSpan.UseVisualStyleBackColor = false;
            this.butSpan.Click += new System.EventHandler(this.butSpan_Click);
            // 
            // txtspan
            // 
            this.txtspan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtspan.Location = new System.Drawing.Point(631, 502);
            this.txtspan.Name = "txtspan";
            this.txtspan.Size = new System.Drawing.Size(413, 45);
            this.txtspan.TabIndex = 19;
            this.txtspan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtspan.TextChanged += new System.EventHandler(this.txtspan_TextChanged);
            // 
            // txtZero
            // 
            this.txtZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZero.Location = new System.Drawing.Point(631, 365);
            this.txtZero.Name = "txtZero";
            this.txtZero.Size = new System.Drawing.Size(413, 45);
            this.txtZero.TabIndex = 12;
            this.txtZero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZero.TextChanged += new System.EventHandler(this.txtZero_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Zero Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Span Value";
            // 
            // butCalib
            // 
            this.butCalib.BackColor = System.Drawing.Color.LightGreen;
            this.butCalib.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCalib.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.butCalib.Location = new System.Drawing.Point(525, 101);
            this.butCalib.Name = "butCalib";
            this.butCalib.Size = new System.Drawing.Size(187, 42);
            this.butCalib.TabIndex = 22;
            this.butCalib.Text = "Calib Loadcell";
            this.butCalib.UseVisualStyleBackColor = false;
            this.butCalib.Click += new System.EventHandler(this.butCalib_Click);
            // 
            // CalibReset
            // 
            this.CalibReset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CalibReset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalibReset.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CalibReset.Location = new System.Drawing.Point(740, 101);
            this.CalibReset.Name = "CalibReset";
            this.CalibReset.Size = new System.Drawing.Size(186, 42);
            this.CalibReset.TabIndex = 24;
            this.CalibReset.Text = "Reset";
            this.CalibReset.UseVisualStyleBackColor = false;
            this.CalibReset.Click += new System.EventHandler(this.CalibReset_Click);
            // 
            // txtDataReceive2
            // 
            this.txtDataReceive2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataReceive2.Location = new System.Drawing.Point(66, 434);
            this.txtDataReceive2.Name = "txtDataReceive2";
            this.txtDataReceive2.Size = new System.Drawing.Size(325, 30);
            this.txtDataReceive2.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(363, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(412, 40);
            this.label7.TabIndex = 26;
            this.label7.Text = "Measurement of weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 595);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataReceive2);
            this.Controls.Add(this.CalibReset);
            this.Controls.Add(this.butCalib);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtspan);
            this.Controls.Add(this.butSpan);
            this.Controls.Add(this.trackBarSpan);
            this.Controls.Add(this.trackBarZero);
            this.Controls.Add(this.butZero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataReceive1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.sendData);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butConnect);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butExit;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.TextBox sendData;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtDataReceive1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butZero;
        private System.Windows.Forms.TrackBar trackBarZero;
        private System.Windows.Forms.TrackBar trackBarSpan;
        private System.Windows.Forms.Button butSpan;
        private System.Windows.Forms.TextBox txtspan;
        private System.Windows.Forms.TextBox txtZero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butCalib;
        private System.Windows.Forms.Button CalibReset;
        private System.Windows.Forms.TextBox txtDataReceive2;
        private System.Windows.Forms.Label label7;
    }
}

