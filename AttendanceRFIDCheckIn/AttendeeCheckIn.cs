using AttendanceRFIDCheckIn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceRFIDCheckIn
{
    public partial class AttendeeCheckIn : Form
    {
        //object serialport to listen usb
        private SerialPort Port;
        List<ObjectToReturn> attendees = new List<ObjectToReturn>();

        public AttendeeCheckIn()
        {
            InitializeComponent();

            //attendees 

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(displaydata_event));
        }

        private async void displaydata_event(object sender, EventArgs e)
        {
            string in_data = Port.ReadLine().Replace("\r", "");
            Attendee attendee = await new AttendeeBUS().GetByCardID(in_data);
            List<ObjectToReturn> objs = new List<ObjectToReturn>();

            if (attendee != null)
            {
                ObjectToReturn objectToReturn = new ObjectToReturn
                (
                    attendee.AttendeeID,
                    attendee.Name,
                    DateTime.Today.ToString("dd/MM/yyyy"),
                    DateTime.Now.ToString("HH:mm")
                );

                //attendees.Add(objectToReturn);               

                objs.Add(objectToReturn);
            }

            gridCheckIn.DataSource = objs;

        }

        private void AttendeeCheckIn_Load(object sender, EventArgs e)
        {
            gridCheckIn.DataSource = attendees; 
        }
    }
}
