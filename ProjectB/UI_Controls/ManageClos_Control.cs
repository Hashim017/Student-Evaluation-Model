using MidProjectEven;
using MidProjectEven.Classes.BL;
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
using System.Data.SqlClient;

namespace ProjectB.UI_Controls
{
    public partial class ManageClos_Control : UserControl
    {
        private string cloName;
        private string rubricDetails;
        private string rubriclevelDetails;
        private int measurementLevel;
        public ManageClos_Control()
        {
            InitializeComponent();
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

       

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtbx_cloname.Text != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand check1 = new SqlCommand("select count(*) from Clo where Name='" + txtbx_cloname.Text + "'", con);
                    int count = Convert.ToInt32(check1.ExecuteScalar());
                    if (count == 0)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Clo values (@Name,@DateCreated,@DateUpdated)", con);
                        
                        cmd.Parameters.AddWithValue("@Name", txtbx_cloname.Text);
                        
                        DateTime date = DateTime.Now;
                        cmd.Parameters.AddWithValue("@DateCreated", date);
                        cmd.Parameters.AddWithValue("@DateUpdated", date);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully saved", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CLO name already exists", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                }

            }
            else
            {
                MessageBox.Show("Enter All Credentials", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.CurrentRow.Selected = true;
            txtbx_cloname.Text = dataGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.CurrentRow.Selected = true;
            txtbx_cloname.Text = dataGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            btn_Add.Text = "Update";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbx_cloname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_cloname_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
