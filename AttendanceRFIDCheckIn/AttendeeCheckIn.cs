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
        List<Attendee> attendees;

        public AttendeeCheckIn()
        {
            InitializeComponent();

            attendees = new List<Attendee>();

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
            string in_data = Port.ReadLine();
            var attendee = await new AttendeeDAO().GetAllAttendee();

            //if(attendee != null)
            //{
            //    ObjectToReturn objectToReturn = new ObjectToReturn
            //    (
            //        attendee.AttendeeID,
            //        attendee.Name,
            //        DateTime.Today.ToString("dd/MM/yyyy"),
            //        DateTime.Now.ToString("HH:mm")
            //    );

            //    attendees.Add(objectToReturn);
            attendees = attendee;
            //}
        }

        private void AttendeeCheckIn_Load(object sender, EventArgs e)
        {
            gridCheckIn.DataSource = attendees; 
        }
    }
}
