using AttendanceManagementSystem.BUS;
using AttendanceManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementSystem
{
    public partial class EventClassManagementForm : Form
    {
        private string state = "";

        public EventClassManagementForm()
        {
            InitializeComponent();
        }

        private void EventClassManagementForm_Load(object sender, EventArgs e)
        {
            labelEvent.Hide();
            labelClass.Hide();
            labelEventID.Hide();
            labelEventName.Hide();
            labelLocation.Hide();
            labelDate.Hide();
            labelStart.Hide();
            labelEnd.Hide();
            labelClassID.Hide();
            labelClassName.Hide();
            labelDateEnd.Hide();
            labelDateStart.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.Show();
        }

        private void radioBtnEvent_CheckedChanged(object sender, EventArgs e)
        {
            labelEvent.Show();
            labelClass.Hide();
            labelEventID.Show();
            labelEventName.Show();
            labelLocation.Show();
            labelDate.Show();
            labelStart.Show();
            labelEnd.Show();
            labelClassID.Hide();
            labelClassName.Hide();
            labelDateEnd.Hide();
            labelDateStart.Hide();
            txtDateEnd.Hide();
            txtDateStart.Hide();
        }

        private void radioBtnClass_CheckedChanged(object sender, EventArgs e)
        {
            labelClass.Show();
            labelEvent.Hide();
            labelEventID.Hide();
            labelEventName.Hide();
            labelLocation.Show();
            labelDate.Show();
            labelStart.Show();
            labelEnd.Show();
            labelClassID.Show();
            labelClassName.Show();
            labelDateEnd.Show();
            labelDateStart.Show();
            txtDateEnd.Show();
            txtDateStart.Show();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (state == "Event")
            {
                Event eve = new Event(txtID.Text,
                                      txtName.Text,
                                      txtDate.Text,
                                      txtLocation.Text,
                                      txtStart.Text,
                                      txtEnd.Text);

                bool result = new EventBUS().AddNewEvent(eve);

                if (result)
                {
                    MessageBox.Show("Thêm thành công!");
                    List<Event> listEvent = await new EventBUS().GetAllEvent();
                    gridEventClass.DataSource = listEvent;
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
            else
            {
                Class cls = new Class(txtID.Text,
                                      txtName.Text,
                                      txtLocation.Text,
                                      txtStart.Text,
                                      txtEnd.Text,
                                      txtDateStart.Text,
                                      txtDateEnd.Text,
                                      txtDate.Text);

                bool result = new ClassBUS().AddNewClass(cls);

                if (result)
                {
                    MessageBox.Show("Thêm thành công!");
                    List<Class> listEvent = await new ClassBUS().GetAllClass();
                    gridEventClass.DataSource = listEvent;
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
        }

        private async void radioBtnEvent_Click(object sender, EventArgs e)
        {
            List<Event> events = await new EventBUS().GetAllEvent();
            gridEventClass.DataSource = events;
            state = "Event";
            txtID.Text = new EventBUS().GetRandom(5);
        }

        private async void radioBtnClass_Click(object sender, EventArgs e)
        {
            List<Class> classes = await new ClassBUS().GetAllClass();
            gridEventClass.DataSource = classes;
            state = "Class";
            txtID.Text = new ClassBUS().GetRandomID(5);
        }

        private async void gridEventClass_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtLocation.Text = "";
            txtDate.Text = "";
            txtStart.Text = "";
            txtEnd.Text = "";
            txtDateStart.Text = "";
            txtDateEnd.Text = "";

            if (gridEventClass.SelectedRows.Count > 0)
            {
                string id = gridEventClass.SelectedCells[0].Value.ToString();

                if (state == "Event")
                {
                    Event eve = await new EventBUS().GetEventByID(id);

                    txtID.Text = eve.EventID;
                    txtName.Text = eve.EventName;
                    txtLocation.Text = eve.Location;
                    txtDate.Text = eve.EventDate;
                    txtStart.Text = eve.EventStartTime;
                    txtEnd.Text = eve.EventEndTime;
                }
                else
                {
                    Class cls = await new ClassBUS().GetClassByID(id);

                    txtID.Text = cls.ClassID;
                    txtName.Text = cls.ClassName;
                    txtLocation.Text = cls.Location;
                    txtDate.Text = cls.ClassDate;
                    txtStart.Text = cls.ClassStartTime;
                    txtEnd.Text = cls.ClassEndTime;
                    txtDateStart.Text = cls.ClassDateStart;
                    txtDateEnd.Text = cls.ClassDateEnd;
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridEventClass.SelectedRows.Count > 0)
            {
                string id = gridEventClass.SelectedCells[0].Value.ToString();
                string message = "Mã: " + id;

                var result = MessageBox.Show(message + "\nBạn có chắc chắn về việc xóa chứ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                dynamic checkDelete;

                if (state == "Event")
                    checkDelete = await new EventBUS().DeleteEventByID(id);
                else
                    checkDelete = await new ClassBUS().DeleteClassByID(id);

                if (checkDelete)
                {
                    MessageBox.Show("Xoá thành công");
                    if (state == "Event")
                    {
                        List<Event> listEvent = await new EventBUS().GetAllEvent();
                        gridEventClass.DataSource = listEvent;
                    }
                    else
                    {
                        List<Class> listEvent = await new ClassBUS().GetAllClass();
                        gridEventClass.DataSource = listEvent;
                    }
                    return;
                }
            }

            MessageBox.Show("Xóa thất bại!");
        }

        private void gridEventClass_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = gridEventClass.SelectedCells[0].Value.ToString();

            AttendeeListInEvent frm = new AttendeeListInEvent(id);
            frm.Show();
            this.Enabled = false;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (state == "Event")
            {
                Event newEvent = new Event()
                {
                    EventID = txtID.Text,
                    EventName = txtName.Text,
                    EventDate = txtDate.Text,
                    Location = txtLocation.Text,
                    EventStartTime = txtStart.Text,
                    EventEndTime = txtEnd.Text,
                };
                bool result = await new EventBUS().UpdateEvent(newEvent);
                if (result)
                {
                    MessageBox.Show("Cập nhật sự kiện thành công!");
                    List<Event> listEvent = await new EventBUS().GetAllEvent();
                    gridEventClass.DataSource = listEvent;
                }
                else
                {
                    MessageBox.Show("Cập nhật sự kiện thất bại");
                }
            }
            else
            {
                Class cls = new Class()
                {
                    ClassID = txtID.Text,
                    ClassName = txtName.Text,
                    ClassDate = txtDate.Text,
                    Location = txtLocation.Text,
                    ClassStartTime = txtStart.Text,
                    ClassEndTime = txtEnd.Text,
                    ClassDateStart = txtDateStart.Text,
                    ClassDateEnd = txtDateEnd.Text,
                };

                bool result = await new ClassBUS().UpdateClass(cls);

                if (result)
                {
                    MessageBox.Show("Cập nhật sự kiện thành công!");
                    List<Class> listEvent = await new ClassBUS().GetAllClass();
                    gridEventClass.DataSource = listEvent;
                }
                else
                    MessageBox.Show("Cập nhật sự kiện thất bại!");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyWord = txtSearch.Text.Trim();
            if (state == "Event")
            {
                List<Event> listEvent = await new EventBUS().SelectByKeyWord(keyWord);
                gridEventClass.DataSource = listEvent;
            }
            else
            {
                List<Class> listClass = await new ClassBUS().SelectByKeyWord(keyWord);
                gridEventClass.DataSource = listClass;
            }
        }
    }
}