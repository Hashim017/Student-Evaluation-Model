using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectB.UI_Controls
{
    public partial class AssessmentComponent_Control : UserControl
    {
        public AssessmentComponent_Control()
        {
            InitializeComponent();
            var con2 = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("Select Id from Rubric", con2);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            rubicid_combo_Box.ValueMember = "Id";
            rubicid_combo_Box.DataSource = dt2;

            var con3 = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand("Select Id from Assessment", con3);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            assid_combo_box.ValueMember = "Id";
            assid_combo_box.DataSource = dt3;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (txtbx_name.Text != "" && rubicid_combo_Box.Text != "" && txtbx_totalmarks.Text != "" && assid_combo_box.Text != "")
            {
                try
                {
                  
                        // Check if a record with the same name, rubric id, and assessment id already exists in the database
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM AssessmentComponent WHERE Name=@Name AND AssessmentId=@AssessmentId", con);
                        checkCmd.Parameters.AddWithValue("@Name", txtbx_name.Text);
                        checkCmd.Parameters.AddWithValue("@AssessmentId", assid_combo_box.Text);
                        int recordCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        // If a record already exists, show an error message
                        if (recordCount > 0)
                        {
                            MessageBox.Show("A record with the same name and assessment id already exists in the database.");
                        }
                        else
                        {
                            // Otherwise, insert the record into the database
                            SqlCommand cmd = new SqlCommand("Insert into AssessmentComponent values (@Name,@RubricId,@TotalMarks,@DateCreated,@DateUpdated,@AssessmentId)", con);
                            cmd.Parameters.AddWithValue("@Name", txtbx_name.Text);
                            cmd.Parameters.AddWithValue("@RubricId", rubicid_combo_Box.Text);
                           
                            cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(txtbx_totalmarks.Text));
                            
                            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@AssessmentId", assid_combo_box.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                   
                }

                catch (Exception)
                {
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
            SqlCommand cmd = new SqlCommand("Select * from AssessmentComponent", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbx_name.Text = dataGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                rubicid_combo_Box.Text = dataGrid.Rows[e.RowIndex].Cells["RubricId"].Value.ToString();
                txtbx_totalmarks.Text = dataGrid.Rows[e.RowIndex].Cells["TotalMarks"].Value.ToString();
                assid_combo_box.Text = dataGrid.Rows[e.RowIndex].Cells["AssessmentId"].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
