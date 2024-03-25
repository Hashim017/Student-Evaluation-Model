using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB.UI_Controls
{
    public partial class Assessments_Control : UserControl
    {
        public Assessments_Control()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtbx_title.Text != "" && txtbx_totalmarks.Text != "" && txtbx_weightage.Text != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into Assessment values (@Title,@DateCreated,@TotalMarks,@TotalWeightage)", con);

                    cmd.Parameters.AddWithValue("@Title", txtbx_title.Text);
                    cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);

                    cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(txtbx_totalmarks.Text));
                    cmd.Parameters.AddWithValue("@TotalWeightage", int.Parse(txtbx_weightage.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                }
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Assessment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbx_title.Text = dataGrid.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtbx_totalmarks.Text = dataGrid.Rows[e.RowIndex].Cells["TotalMarks"].Value.ToString();
                txtbx_weightage.Text = dataGrid.Rows[e.RowIndex].Cells["TotalWeightage"].Value.ToString();
                btn_Add.Text = "Update";
            }
            catch (Exception)
            {

            }
        }
    }
}
