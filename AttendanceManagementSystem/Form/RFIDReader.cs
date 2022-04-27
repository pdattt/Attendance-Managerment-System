using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AttendanceManagementSystem
{
    public partial class RFIDReader : Form
    {
        //object serialport to listen usb
        private SerialPort Port;

        //variable to check if arduino is connect
        bool IsClosed = false;

        public RFIDReader()
        {
            InitializeComponent();

            //configuration of arduino, you check if com3 is the port correct, 
            //in arduino ide you can make it
            Port = new SerialPort();
            Port.BaudRate = 9600;
            Port.PortName = "COM4";
            Port.Parity = Parity.None;
            Port.DataBits = 8;
            //Port.StopBits = StopBits.None;
            Port.ReadTimeout = 500;
            Port.DataReceived += Port_DataReceived;

            try
            {
                Port.Open();
                txtData.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            string in_data = Port.ReadLine();
            txtData.Text = in_data;
        }
    }
}
