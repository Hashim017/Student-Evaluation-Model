using MidProjectEven;
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

namespace ProjectB.UI_Controls
{
    public partial class AddStudent_Control : UserControl
    {
        private bool controlRemoved = false;
        string first_name, last_name, email, registration_number, contact;
        int selectindex;
        Student student = null;

        public AddStudent_Control(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void btn_CLear_Click(object sender, EventArgs e)
        {

        }

        private void lbl_RegNo_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            FillStatusComboBox();
            AddDataToTextBoxes();
        }

        public void clearfieldes()
        {
            txtbx_firstname.Text = "";
            txtbx_lastname.Text = "";
            txtbx_email.Text = "";
            txtbx_contact.Text = "";
            txtbx_regno.Text = "";
            status_combo_box.SelectedIndex = -1;

        }
        private void btn_StudentAdd_Click(object sender, EventArgs e)
        {
            if (btn_StudentAdd.Text == "Update")
            {
                string lastreg = student.RegistrationNumber;
                Student student1 = CheckFields();
                if (student1 != null)
                {
                    bool updated = DataBase.EditStudent(lastreg, student1);
                    if (updated)
                    {
                        MessageBox.Show("Student Record Updated Successfully!", "congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfieldes();
                    }
                    else
                    {
                        MessageBox.Show("You Can Not Edit This Record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Student student1 = CheckFields();
                if(student1 != null)
                {
                    bool inserted = DataBase.InsertStudent(student1);
                    if (inserted)
                    {
                        MessageBox.Show("Student Record Added Successfully!", "congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfieldes();
                    }
                    else
                    {
                        MessageBox.Show("Student with the same Registration Number already exists.");
                    }
                }
            }
        }

        public Student CheckFields()
        {
            if (txtbx_firstname.Text == "" || txtbx_lastname.Text == "" || txtbx_regno.Text == ""
            || txtbx_email.Text == "" || txtbx_contact.Text == "")
            {
                MessageBox.Show("Kindly Fill All Above Fields!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (status_combo_box.SelectedIndex != -1)
            {
                string selectedStatus = status_combo_box.SelectedItem.ToString();
                selectindex = status_combo_box.SelectedIndex;

                first_name = txtbx_firstname.Text;
                last_name = txtbx_lastname.Text;
                email = txtbx_email.Text;
                contact = txtbx_contact.Text;
                registration_number = txtbx_regno.Text;
                int id = DataBase.GetStatusIdOne(selectedStatus);
                if (id != -1)
                {
                    Student student = new Student(first_name, last_name, registration_number, email, contact, id);
                    return student;

                }

            }
            else
            {
                MessageBox.Show("Kindly Select a Status from the combo boxs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        void FillStatusComboBox()
        {
            status_combo_box.Items.Clear();
            List<string> list = DataBase.FillStudentStatusComboBox();
            foreach (var item in list)
            {
                status_combo_box.Items.Add(item);
            }
            status_combo_box.SelectedItem = 0;
        }

        public void AddDataToTextBoxes()
        {
            if (student != null)
            {
                txtbx_firstname.Text = student.FirstName;
                txtbx_lastname.Text = student.LastName;
                txtbx_email.Text = student.Email;
                txtbx_regno.Text = student.RegistrationNumber;
                txtbx_contact.Text = student.Contact;
                btn_StudentAdd.Text = "Update";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
