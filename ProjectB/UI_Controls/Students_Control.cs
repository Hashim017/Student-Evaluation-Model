using MidProjectEven.Classes.DL;
using MidProjectEven.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectEven;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ProjectB.UI_Controls
{
    public partial class Students_Control : UserControl
    {
        public Student student = null;
        ClassAttendance attendance = null;
        int AttendanceStatus = -1, studentid = -1, attendanceid = -1;
        public Students_Control()
        {
            InitializeComponent();
            FillAttendancebox();
            loadData();
            Attendance_box.SelectedIndex = -1;
            Attendance_box.Enabled = false;
            Mark_Attandance.Visible = false;
        }

        public void addStudentForm()
        {

            //Student student = StudentDL.GetCheckedStudent();
            Full_panel.Controls.Clear();
            AddStudent_Control control = new AddStudent_Control(student);
            Full_panel.Dock = DockStyle.Fill;
            control.Dock = DockStyle.Fill;
            Full_panel.Controls.Add(control);
        }

        private void FillAttendancebox()
        {
            List<string> list = new List<string>();
            list = DataBase.FillStatusComboBox();
            for (int i = 0; i < list.Count; i++)
            {
                Attendance_box.Items.Add(list[i]);
            }
        }

        private void loadData()
        {
            dataGrid.DataSource = DataBase.LoadActiveStudents();
        }


        private void Attendance_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_bar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_bar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void count_students_label_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            bool check = DataBase.MakeStudentInactive(student);
            if (check)
            {
                MessageBox.Show("Student Record Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            loadData();
        }

        private void Mark_Attandance_Click(object sender, EventArgs e)
        {
            if (Attendance_box.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item in the ComboBox before proceeding.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (attendance == null)
            {
                attendance = new ClassAttendance();

                attendanceid = DataBase.AddClassAttendanceAndGetId(attendance);
            }
            else
            {
                studentid = DataBase.GetStudentId(student.RegistrationNumber);
                AttendanceStatus = DataBase.GetStatusId(Attendance_box.SelectedItem.ToString());
            }

            if (attendanceid != -1 && studentid != -1 && AttendanceStatus != -1)
            {
                StudentAttendance studentAttendance = new StudentAttendance(studentid, attendanceid, AttendanceStatus);
                bool isadd = StudentAttendanceDL.AddintoList(studentAttendance);
                if (!isadd)
                {
                    MessageBox.Show("Attendance is already marked for that student. Change attendance status if you want to edit it.", "Duplicate Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else

                {
                    MessageBox.Show("Student Attendance Added Successfully!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBase.AddStudentAttendanceInDB(studentAttendance);
                }
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string fname = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
            string lname = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
            string regno = dataGrid.SelectedRows[0].Cells[2].Value.ToString();
            string email = dataGrid.SelectedRows[0].Cells[3].Value.ToString();
            string contact = dataGrid.SelectedRows[0].Cells[4].Value.ToString();
            int status = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[5].Value.ToString());
            student = new Student(fname, lname, regno, email, contact, status);
            Attendance_box.Enabled = true;
            Mark_Attandance.Visible = true;
            Add_student_btn.Text = "Update Student";
        }

        private void Searchbox_TextChanged_1(object sender, EventArgs e)
        {
            List<Student> list = DataBase.SearchData(Searchbox.Text.ToString());
            if (list != null)
            {
                //display(list);
            }
            else
            {
                MessageBox.Show("No Record Found");

            }
        }

        private void Full_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        /*      void display(List<Student> list)
              {
                  StudentDL.ClearStudents();
                  foreach (var person in list)
                  {
                      Student student = new Student(person.FirstName, person.LastName, person.RegistrationNumber, person.Email, person.Contact, person.Status);
                      Student_infromation_card card = new Student_infromation_card(student);
                      StudentDL.Add_Students(card);
                      flowLayoutPanel.Controls.Add(card);
                  }
                  flowLayoutPanel.ResumeLayout();
                  count_students_label.Text = list.Count.ToString();

              }*/

        private void Add_student_btn_Click(object sender, EventArgs e)
        {
            addStudentForm();
        }

        private void Full_panel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
