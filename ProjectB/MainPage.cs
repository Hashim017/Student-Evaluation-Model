using ProjectB.UI_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        public void setMenu(Control control, string header_name)
        {

            main_panel.Controls.Clear();
            label_header_main.Text = header_name;
            main_panel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Students_btn_Click(object sender, EventArgs e)
        {
            setMenu(new Students_Control(), "Students");
        }

        private void attendance_btn_Click(object sender, EventArgs e)
        {
            setMenu(new AttendanceRecord_Control(), "Attendance Record");
        }

        private void Clo_btn_Click(object sender, EventArgs e)
        {
            setMenu(new ManageClos_Control(), "CLO Management");
        }

        private void Rubric_Levels_btn_Click(object sender, EventArgs e)
        {
            setMenu(new ManageRubrics_Control(), "Rubric Management");

        }

        private void Assesment_btn_Click(object sender, EventArgs e)
        {
            setMenu(new Assessments_Control(), "Assessment Management");

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            setMenu(new AssessmentComponent_Control(), "Assessment Component Management");

        }

        private void btn_rlevels_Click(object sender, EventArgs e)
        {
            setMenu(new ManageRubricLevels_Control(), "Rubric Levels Management");
        }

        private void btn_evaluation_Click(object sender, EventArgs e)
        {
            setMenu(new MarkEvaluation_Control(), "Mark Evaluation Against Student");

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            setMenu(new Reports_Control(), "Reports Generation");

        }
    }
}
