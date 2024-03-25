using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectB.UI_Controls
{
    public partial class ManageRubrics_Control : UserControl
    {
        public ManageRubrics_Control()
        {
            InitializeComponent();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id from Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cloid_combo_box.ValueMember = "Id";
            cloid_combo_box.DataSource = dt;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtbx_rubricname.Text != "" && cloid_combo_box.Text != "" && txtbx_desc.Text != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into Rubric values (@Id,@Details,@CloId)", con);
                    cmd.Parameters.AddWithValue("Id", txtbx_rubricname.Text);
                    cmd.Parameters.AddWithValue("CloId", cloid_combo_box.Text);
                    cmd.Parameters.AddWithValue("Details", txtbx_desc.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select * from Rubric", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid.DataSource = dt;
                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Select max(Id)+1 from Rubric", con1);
                
            }
            catch (Exception)
            {
                //MaterialMessageBox.Show(exp.Message);
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGrid.CurrentRow.Selected = true;
                cloid_combo_box.Text = dataGrid.Rows[e.RowIndex].Cells["CloId"].Value.ToString();
                txtbx_rubricname.Text = dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtbx_desc.Text = dataGrid.Rows[e.RowIndex].Cells["Details"].Value.ToString();
                btn_Add.Text = "Update";
            }
            catch (Exception)
            {
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
