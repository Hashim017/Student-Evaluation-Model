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

namespace ProjectB.UI_Controls
{
    public partial class Reports_Control : UserControl
    {
        public Reports_Control()
        {
            InitializeComponent();
        }

        private void btn_loadclo_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Name, RegistrationNumber, ObtainedMarks, TotalMarks, AssessmentComponentId, RubricMeasurementId, AssessmentComponent, Title FROM(SELECT FirstName + ' ' + LastName AS Name, RegistrationNumber, (CONVERT(FLOAT, RubricLevel.MeasurementLevel) / MAX(RubricLevel.MeasurementLevel) OVER() * AssessmentComponent.TotalMarks) AS ObtainedMarks, AssessmentComponent.TotalMarks, AssessmentComponentId, RubricMeasurementId,AssessmentComponent.Name AS AssessmentComponent, Assessment.Title FROM Student JOIN StudentResult ON Student.Id = StudentResult.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id JOIN AssessmentComponent ON Rubric.Id = AssessmentComponent.RubricId JOIN Assessment ON AssessmentComponent.AssessmentId = Assessment.Id WHERE StudentResult.StudentId = StudentId AND AssessmentComponent.Id = AssessmentComponentId) AS subquery", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void btn_downloadclo_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string[] headers = { "Registration Number", "Name", "Total Marks", "Obtained Marks", };
            // Define variables
            // Execute query and fill DataTable
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT RegistrationNumber, Name, SUM(TotalMarks) AS TotalMarks, SUM(ObtainedMarks) AS ObtainedMarks FROM( SELECT S.RegistrationNumber, S.FirstName + ' ' + S.LastName AS Name, Clo.Name AS[CLO Name], Clo.Id, A.Title, AC.Name AS[Assessment Component Name], AC.TotalMarks AS TotalMarks, A.Totalweightage, (CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks) AS ObtainedMarks, ((CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks) / A.TotalMarks * A.TotalWeightage) AS ObtainedWeightage FROM Student S INNER JOIN StudentResult SR ON S.Id = SR.StudentId INNER JOIN RubricLevel RL ON SR.RubricMeasurementId = RL.Id INNER JOIN Rubric R ON RL.RubricId = R.Id INNER JOIN Clo ON R.CloId = Clo.Id INNER JOIN AssessmentComponent AC ON R.Id = AC.RubricId INNER JOIN Assessment A ON AC.AssessmentId = A.Id WHERE SR.StudentId = [StudentId] AND AC.Id = [AssessmentComponentId]) AS NewTable WHERE [CLO Name] ='" + "'GROUP BY RegistrationNumber, Name, Title", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;

            // Create a new PDF document
            Document doc = new Document();

            // Create a new PDF writer
            PdfWriter.GetInstance(doc, new FileStream("CLO_report.pdf", FileMode.Create));

            // Open the document
            doc.Open();
            // Add heading with current date and time
            PdfPTable headingTable = new PdfPTable(1);
            headingTable.WidthPercentage = 100;

            PdfPCell headingCell = new PdfPCell(new Phrase("CLO_Report - "));
            headingCell.HorizontalAlignment = Element.ALIGN_CENTER;
            headingCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            headingCell.Padding = 8;
            headingCell.BackgroundColor = new BaseColor(204, 204, 204);
            headingTable.AddCell(headingCell);

            doc.Add(headingTable);

            // Create a new table with the same number of columns as the DataGridView
            PdfPTable table = new PdfPTable(dataGrid.ColumnCount);
            table.WidthPercentage = 100;

            // Add the column headers to the table
            for (int i = 0; i < dataGrid.ColumnCount; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dataGrid.Columns[i].HeaderText));
                cell.BackgroundColor = new BaseColor(204, 204, 204); // gray background color
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.Padding = 8;
                table.AddCell(cell);
            }

            // Add the rows to the table
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {
                    if (dataGrid[j, i].Value != null)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(dataGrid[j, i].Value.ToString()));
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

        private void btn_loadass_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Name, RegistrationNumber, ObtainedMarks, TotalMarks, AssessmentComponentId, RubricMeasurementId, AssessmentComponent, Title FROM(SELECT FirstName + ' ' + LastName AS Name, RegistrationNumber, (CONVERT(FLOAT, RubricLevel.MeasurementLevel) / MAX(RubricLevel.MeasurementLevel) OVER() * AssessmentComponent.TotalMarks) AS ObtainedMarks, AssessmentComponent.TotalMarks, AssessmentComponentId, RubricMeasurementId,AssessmentComponent.Name AS AssessmentComponent, Assessment.Title FROM Student JOIN StudentResult ON Student.Id = StudentResult.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id JOIN AssessmentComponent ON Rubric.Id = AssessmentComponent.RubricId JOIN Assessment ON AssessmentComponent.AssessmentId = Assessment.Id WHERE StudentResult.StudentId = StudentId AND AssessmentComponent.Id = AssessmentComponentId) AS subquery", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void btn_downloadass_Click(object sender, EventArgs e)
        {
            // Define variables
            DataTable dataTable = new DataTable();
            string[] headers = { "Registration Number", "Name", "Total Marks", "Obtained Marks", "Total Weightage", "Obtained Weightage" };

            // Execute query and fill DataTable
            // Execute query and fill DataTable
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT SubQuery.RegistrationNumber, SubQuery.Name, SubQuery.TotalMarks, SUM(SubQuery.ObtainedMarks) AS ObtainedMarks, SubQuery.TotalWeightage, SUM(SubQuery.ObtainedWeightage) AS ObtainedWeightage FROM(SELECT DISTINCT S.RegistrationNumber, S.FirstName + '' + S.LastName AS Name, A.Title, A.TotalMarks, A.Totalweightage, (CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks) AS ObtainedMarks, ((CONVERT(FLOAT, RL.MeasurementLevel) / MAX(RL.MeasurementLevel) OVER() * AC.TotalMarks) / A.TotalMarks * A.TotalWeightage) AS ObtainedWeightage FROM Student S JOIN StudentResult SR ON S.Id = SR.StudentId JOIN RubricLevel RL ON SR.RubricMeasurementId = RL.Id JOIN Rubric R ON RL.RubricId = R.Id JOIN AssessmentComponent AC ON R.Id = AC.RubricId JOIN Assessment A ON AC.AssessmentId = A.Id WHERE SR.StudentId = [StudentId] AND AC.Id = [AssessmentComponentId] AND A.Title ='" + "') AS SubQuery GROUP BY SubQuery.RegistrationNumber, SubQuery.Name, SubQuery.TotalMarks, SubQuery.TotalWeightage", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;


            // Create PDF document and set margins
            Document doc = new Document();

            // Create a new PDF writer
            PdfWriter.GetInstance(doc, new FileStream("AssessmentWise_report.pdf", FileMode.Create));

            // Open the document
            doc.Open();
            PdfPTable headingTable = new PdfPTable(1);
            headingTable.WidthPercentage = 100;
            PdfPCell headingCell = new PdfPCell(new Phrase("Assessment Report"));
            headingCell.HorizontalAlignment = Element.ALIGN_CENTER;
            headingCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            headingCell.Padding = 8;
            headingCell.BackgroundColor = new BaseColor(204, 204, 204);
            headingTable.AddCell(headingCell);
            doc.Add(headingTable);

            // Create a new table with the same number of columns as the DataGridView
            PdfPTable table = new PdfPTable(dataGrid.ColumnCount);
            table.WidthPercentage = 100;

            // Add the column headers to the table
            for (int i = 0; i < dataGrid.ColumnCount; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dataGrid.Columns[i].HeaderText));
                cell.BackgroundColor = new BaseColor(204, 204, 204); // gray background color
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.Padding = 8;
                table.AddCell(cell);
            }

            // Add the rows to the table
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {
                    if (dataGrid[j, i].Value != null)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(dataGrid[j, i].Value.ToString()));
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
