using AttendanceManagementSystem.BUS;
using IronXL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementSystem
{
    public partial class AttendeeListInEvent : Form
    {
        private string eventID;
        private List<Attendee> attendees;

        public AttendeeListInEvent(string id)
        {
            InitializeComponent();
            this.eventID = id;
        }

        private async void AttendeeListInEvent_Load(object sender, EventArgs e)
        {
            attendees = await new AttendeeListEventBUS().GetAllAttendeeByEvent(eventID);
            gridAttendance.DataSource = attendees;
        }

        private void AttendeeListInEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fcs = Application.OpenForms;

            foreach (Form form in fcs)
                if (form.Name == "EventClassManagementForm")
                    form.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAttendeeToEvent addForm = new AddAttendeeToEvent(eventID);
            addForm.Show();
            this.Hide();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridAttendance.SelectedRows.Count > 0)
            {
                string attendeeId = gridAttendance.SelectedCells[0].Value.ToString();
                string message = "Mã: " + attendeeId;

                var result = MessageBox.Show(message + "\nBạn có chắc chắn về việc xóa chứ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                bool checkDelete = await new AttendeeListEventBUS().DeleteAttendeeFromEvent(eventID, attendeeId);

                if (checkDelete)
                {
                    MessageBox.Show("Xóa thành công!");
                    attendees = await new AttendeeListEventBUS().GetAllAttendeeByEvent(eventID);
                    gridAttendance.DataSource = attendees;
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileExt = Path.GetExtension(file.FileName);
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = ReadExcel(file.FileName);
                        List<Attendee> attendeeToImport = dtExcel.AsEnumerable().Select(row =>
                            new Attendee
                            {
                                AttendeeID = row.Field<string>("AttendeeID"),
                                Name = row.Field<string>("Name"),
                                Email = row.Field<string>("Email"),
                                CardID = row.Field<string>("CardID"),
                                Role = row.Field<string>("Role")
                            }).ToList();

                        AddAttendeeToEvent addForm = new AddAttendeeToEvent(eventID, attendeeToImport);
                        addForm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error
                }
            }
        }

        private DataTable ReadExcel(string fileName)
        {
            WorkBook workbook = WorkBook.Load(fileName);
            ////WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
            ////Defaut Sheet: Sheet 1

            WorkSheet sheet = workbook.DefaultWorkSheet;

            return sheet.ToDataTable(true);
        }
    }
}