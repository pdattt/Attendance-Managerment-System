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

namespace AttendanceManagementSystem
{
    public partial class RFIDReader : Form
    {
        //object serialport to listen usb
        System.IO.Ports.SerialPort Port;

        //variable to check if arduino is connect
        bool IsClosed = false;

        public RFIDReader()
        {
            InitializeComponent();

            //configuration of arduino, you check if com3 is the port correct, 
            //in arduino ide you can make it
            Port = new System.IO.Ports.SerialPort();
            Port.PortName = "COM4";
            Port.BaudRate = 9600;
            Port.ReadTimeout = 500;

            try
            {
                Port.Open();
            }
            catch { }
        }

        private void ListenSerial()
        {
            while (!IsClosed)
            {
                try
                {
                    //read to data from arduino
                    string AString = Port.ReadLine();

                    //write the data in something textbox
                    txtSomething.Invoke(new MethodInvoker(
                        delegate
                        {
                            txtSomething.Text = AString;
                        }
                        ));

                }
                catch { }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when the form will be closed this line close the serial port
            IsClosed = true;
            if (Port.IsOpen)
                Port.Close();
        }

        private void RFIDReader_Load(object sender, EventArgs e)
        {
            //A Thread to listen forever the serial port
            Thread Hilo = new Thread(ListenSerial);
            Hilo.Start();
        }
    }
}
