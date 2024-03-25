using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectB.UI_Controls
{
    public partial class ManageRubricLevels_Control : UserControl
    {
        public ManageRubricLevels_Control()
        {
            InitializeComponent();
            var con2 = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("Select Id from Rubric", con2);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            rubicid_combo_Box.ValueMember = "Id";
            rubicid_combo_Box.DataSource = dt2;
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            mlevel_combo_box.DataSource = list;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (rubicid_combo_Box.Text != "" && txtbx_details.Text != "" && mlevel_combo_box.Text != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    // Check if a RubricLevel with the same RubricId and Details already exists
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM RubricLevel WHERE RubricId = @RubricId AND Details = @Details", con);
                    checkCmd.Parameters.AddWithValue("@RubricId", int.Parse(rubicid_combo_Box.Text));
                    checkCmd.Parameters.AddWithValue("@Details", txtbx_details.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        // If the RubricLevel does not already exist, insert it into the database
                        SqlCommand cmd = new SqlCommand("Insert into RubricLevel values(@RubricId,@Details,@MeasurementLevel)", con);
                        cmd.Parameters.AddWithValue("@RubricId", int.Parse(rubicid_combo_Box.Text));
                        cmd.Parameters.AddWithValue("@Details", txtbx_details.Text);
                        cmd.Parameters.AddWithValue("@MeasurementLevel", int.Parse(mlevel_combo_box.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // If the RubricLevel already exists, show an error message
                        MessageBox.Show("A RubricLevel with the same RubricId and Details already exists", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the database operation
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter All Credentials", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from RubricLevel", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGrid.CurrentRow.Selected = true;
                rubicid_combo_Box.Text = dataGrid.Rows[e.RowIndex].Cells["RubricId"].Value.ToString();
                mlevel_combo_box.Text = dataGrid.Rows[e.RowIndex].Cells["MeasurementLevel"].Value.ToString();
                txtbx_details.Text = dataGrid.Rows[e.RowIndex].Cells["Details"].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
