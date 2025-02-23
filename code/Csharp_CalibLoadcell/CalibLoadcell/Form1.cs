using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Linq.Expressions;

namespace CalibLoadcell

{

    public partial class Form1 : Form
    {
        double zero;
        double span;
        double weight;
        double weightprint;
        double calibzero;
        double calibspan; 
        public Form1()
        {
            InitializeComponent();
            string[] Baudrate = {"1200", "2400", "4800", "9600", "115200" };
            cboBaudrate.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboComPort.DataSource = SerialPort.GetPortNames();
            cboBaudrate.Text = "115200";
            calibzero = 500;
            calibspan = 500;
            txtZero.Text = Convert.ToString(calibzero);
            txtspan.Text = Convert.ToString(calibspan);
            string Initially1 = "Chưa kết nối";
            txtDataReceive1.Text = Initially1;
            string Initially2 = "Chưa Calib";
            txtDataReceive2.Text = Initially2;
        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                butConnect.Text = "Disconnect";
                serCOM.PortName = cboComPort.Text;
                serCOM.BaudRate = Convert.ToInt32(cboBaudrate.Text);
                serCOM.Open();
            }
            else
            {
                butConnect.Text = "Connect";
                serCOM.Close();
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*Sendata to ESP32*/
        private void butCalib_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("You are not connected to the device");
            }
            serCOM.Write("CALIB");
            txtDataReceive2.Text = "Đã hiệu chỉnh";
        }

        private void CalibReset_Click(object sender, EventArgs e)
        {
            span = 1;
            calibspan = 1;
            txtspan.Text = Convert.ToString(calibspan);
            zero = 0;
            calibzero = 0;

            txtZero.Text = Convert.ToString(calibzero);
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("You are not connected to the device");
            }
            serCOM.Write("RESET");
            txtDataReceive2.Text = "Bắt đầu hiệu chỉnh";
        }


        private void butZero_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("You are not connected to the device");
            }
            string dataZero = "CZERO" + Convert.ToString(zero);
            serCOM.Write(dataZero);
        }

        private void butSpan_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("You are not connected to the device");
            }
            string dataSpan = "CSPAN" + Convert.ToString(span);
            serCOM.Write(dataSpan);
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            string dulieu = sendData.Text;
            serCOM.Write(dulieu);
        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string AllData = "";
            AllData = serCOM.ReadLine();
            int len = AllData.Length;
            if (len > 0)
            {
                double valueADC = double.Parse(AllData);
                zero = calibzero * 1365 / 500;
                span = calibspan * 525/ 500; 

                weight = (valueADC - zero)/span;
                weightprint = Math.Round(weight, 3 );
                txtDataReceive1.Text = Convert.ToString(weightprint); 
            }
        }

        private void trackBarZero_Scroll(object sender, EventArgs e)
        {
            calibzero = (trackBarZero.Value);
            string zerovalue = Convert.ToString(calibzero);
            txtZero.Text = Convert.ToString(zerovalue);
        }
        
        private void trackBarSpan_Scroll(object sender, EventArgs e)
        {
            calibspan = (trackBarSpan.Value);
            string spanvalue = Convert.ToString(calibspan);
            txtspan.Text = Convert.ToString(spanvalue);
        }
        private void txtZero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtspan_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
