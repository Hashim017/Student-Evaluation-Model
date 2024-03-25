using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectB.UI_Controls
{
    public partial class MarkEvaluation_Control : UserControl
    {
        public MarkEvaluation_Control()
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
            ass_combo_box.ValueMember = "Id";
            ass_combo_box.DataSource = dt3;

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id, FirstName, LastName, Contact, Email, RegistrationNumber, Status FROM Student WHERE Status = 5", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid1.DataSource = dt;

        }

        private void MarkEvaluation_Control_Load(object sender, EventArgs e)
        {
        }

        private void btn_Mark_Click(object sender, EventArgs e)
        {
            if (txtbx_sid.Text != "" && ass_combo_box.Text != "" && rubicid_combo_Box.Text != "")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into StudentResult values (@StudentId,@AssessmentComponentId,@RubricMeasurementId,@EvaluationDate)", con);
                    cmd.Parameters.AddWithValue("@StudentId", int.Parse(txtbx_sid.Text));
                    cmd.Parameters.AddWithValue("@AssessmentComponentId", int.Parse(ass_combo_box.Text));
                    cmd.Parameters.AddWithValue("@RubricMeasurementId", int.Parse(rubicid_combo_Box.Text));
                    cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Marked", "inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_load_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Name, RegistrationNumber, ObtainedMarks, TotalMarks, AssessmentComponentId, RubricMeasurementId, AssessmentComponent, Title FROM(SELECT FirstName + ' ' + LastName AS Name, RegistrationNumber, (CONVERT(FLOAT, RubricLevel.MeasurementLevel) / MAX(RubricLevel.MeasurementLevel) OVER() * AssessmentComponent.TotalMarks) AS ObtainedMarks, AssessmentComponent.TotalMarks, AssessmentComponentId, RubricMeasurementId,AssessmentComponent.Name AS AssessmentComponent, Assessment.Title FROM Student JOIN StudentResult ON Student.Id = StudentResult.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id JOIN AssessmentComponent ON Rubric.Id = AssessmentComponent.RubricId JOIN Assessment ON AssessmentComponent.AssessmentId = Assessment.Id WHERE StudentResult.StudentId = StudentId AND AssessmentComponent.Id = AssessmentComponentId) AS subquery", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid2.DataSource = dt;
        }

        private void grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_sid.Text = grid1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string[] headers = { "Name", "Registration Number", "Obtained Marks", "Total Marks", "AssessmentComponent Id", "Rubric Measurement Id", "Assessment Component", "Title" };
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Name, RegistrationNumber, ObtainedMarks, TotalMarks, AssessmentComponentId, RubricMeasurementId, AssessmentComponent, Title FROM(SELECT FirstName + ' ' + LastName AS Name, RegistrationNumber, (CONVERT(FLOAT, RubricLevel.MeasurementLevel) / MAX(RubricLevel.MeasurementLevel) OVER() * AssessmentComponent.TotalMarks) AS ObtainedMarks, AssessmentComponent.TotalMarks, AssessmentComponentId, RubricMeasurementId,AssessmentComponent.Name AS AssessmentComponent, Assessment.Title FROM Student JOIN StudentResult ON Student.Id = StudentResult.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id JOIN AssessmentComponent ON Rubric.Id = AssessmentComponent.RubricId JOIN Assessment ON AssessmentComponent.AssessmentId = Assessment.Id WHERE StudentResult.StudentId = StudentId AND AssessmentComponent.Id = AssessmentComponentId) AS subquery", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid2.DataSource = dt;
            Document doc = new Document();


            // Create a new PDF writer
            string temp = "Overall Assessment Report" + ".pdf";
            //MaterialMessageBox.Show(temp);
            PdfWriter.GetInstance(doc, new FileStream(temp, FileMode.Create));

            // Open the document
            doc.Open();
            // Add heading with current date and time
            PdfPTable headingTable = new PdfPTable(1);
            headingTable.WidthPercentage = 100;

            PdfPCell headingCell = new PdfPCell(new Phrase("Overall Assessment Report"));
            headingCell.HorizontalAlignment = Element.ALIGN_CENTER;
            headingCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            headingCell.Padding = 8;
            headingCell.BackgroundColor = new BaseColor(204, 204, 204);
            headingTable.AddCell(headingCell);

            doc.Add(headingTable);


            // Create a new table with the same number of columns as the DataGridView
            PdfPTable table = new PdfPTable(grid2.ColumnCount);
            table.WidthPercentage = 100;

            // Add the column headers to the table
            for (int i = 0; i < grid2.ColumnCount; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(grid2.Columns[i].HeaderText));
                cell.BackgroundColor = new BaseColor(204, 204, 204); // gray background color
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.Padding = 8;
                table.AddCell(cell);
            }

            // Add the rows to the table
            for (int i = 0; i < grid2.RowCount; i++)
            {
                for (int j = 0; j < grid2.ColumnCount; j++)
                {
                    if (grid2[j, i].Value != null)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(grid2[j, i].Value.ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        cell.Padding = 8;
                        table.AddCell(cell);
                    }
                }
            }


            // Add table to document
            doc.Add(table);

            // Close document and clean up resources
            doc.Close();
            MessageBox.Show("Downloaded Successfully", "inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
