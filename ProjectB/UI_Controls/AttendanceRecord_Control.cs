using MidProjectEven;
using MidProjectEven.Classes.BL;
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
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProjectB.UI_Controls
{
    public partial class AttendanceRecord_Control : UserControl
    {
        public AttendanceRecord_Control()
        {
            InitializeComponent();
        }

        private void AttendanceRecord_Control_Load(object sender, EventArgs e)
        {
            FillCheckbox();
        }

        void FillCheckbox()
        {
            List<string> list = DataBase.GetAllDateAndTimes();
            {
                foreach (var item in list)
                {
                    DateTime date = DateTime.Parse(item);
                    string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
                    AllTime_box.Items.Add(formattedDate);
                }
                AllTime_box.SelectedIndex = -1;
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            if (AllTime_box.SelectedIndex == -1)
            {
            MessageBox.Show("Kindly First Select A Date and Time From box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GridAttendance.Visible = true;
                GridAttendance.DataSource = null;

                string selectedDate = AllTime_box.SelectedItem.ToString();


                int GetSelectDateId = DataBase.GetSelectedTimeIdFromClassAttendance(selectedDate);
                List<StudentAttendanceWithDetails> newlist = DataBase.GetAttendanceDetails(GetSelectDateId);
                GridAttendance.Columns.Clear();
                GridAttendance.Columns.Add("FirstName", "First Name");
                GridAttendance.Columns.Add("LastName", "Last Name");
                GridAttendance.Columns.Add("Email", "Email");
                GridAttendance.Columns.Add("RegistrationNumber", "Registration Number");
                GridAttendance.Columns.Add("Contact", "Contact");
                GridAttendance.Columns.Add("AttendanceStatus", "Attendance Status");


                foreach (var detail in newlist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(GridAttendance);

                    row.Cells[0].Value = detail.Student.FirstName;
                    row.Cells[1].Value = detail.Student.LastName;
                    row.Cells[2].Value = detail.Student.Email;
                    row.Cells[3].Value = detail.Student.RegistrationNumber;
                    row.Cells[4].Value = detail.Student.Contact;
                    row.Cells[5].Value = detail.Attendance.AttendanceStatusId;
                    DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                    cellStyle.BackColor = Color.DarkGray; 
                    cellStyle.ForeColor = Color.Black;
                    cellStyle.Font = new System.Drawing.Font("Times New Roman", 9, FontStyle.Bold);

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ApplyStyle(cellStyle);
                    }
                    GridAttendance.Rows.Add(row);
                }
                GridAttendance.Refresh();
                foreach (DataGridViewRow row in GridAttendance.Rows)
                {
                    row.Height = 30; 
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DECLARE @cols AS NVARCHAR(MAX), @query AS NVARCHAR(MAX), @MinDate DATE, @MaxDate DATE, @SQL NVARCHAR(MAX); SELECT @MinDate = MIN(AttendanceDate), @MaxDate = MAX(AttendanceDate) FROM ClassAttendance; SET @cols = ''; WHILE @MinDate <= @MaxDate BEGIN SET @cols = CONCAT(@cols, ', MAX(CASE WHEN AttendanceDate = ''', CONVERT(VARCHAR(10), @MinDate, 120), ''' THEN CASE sa.AttendanceStatus WHEN 1 THEN ''Present'' WHEN 2 THEN ''Absent'' WHEN 3 THEN ''Late'' WHEN 4 THEN ''Leave'' ELSE ''Not Marked Yet'' END ELSE NULL END) AS [', CONVERT(VARCHAR(10), @MinDate, 120), ']'); SET @MinDate = DATEADD(DAY, 1, @MinDate); END; SET @SQL = 'SELECT s.FirstName + '' '' + s.LastName AS Name' + @cols + ' FROM Student s LEFT JOIN StudentAttendance sa ON s.Id = sa.StudentId LEFT JOIN ClassAttendance ca ON ca.Id = sa.AttendanceId GROUP BY s.Id, s.FirstName, s.LastName ORDER BY s.LastName, s.FirstName'; EXEC sp_executesql @SQL;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridAttendance.DataSource = dt;

            // Create a new PDF document


            // Create a new PDF document
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Complete_Attendance_report.pdf", FileMode.Create));

            // Open the document
            doc.Open();

            // Add a title
            Paragraph title = new Paragraph("Full Attendance Report");
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20f;
            doc.Add(title);

            // Add a table
            PdfPTable table = new PdfPTable(dt.Columns.Count);
            table.WidthPercentage = 100f;
            table.SpacingAfter = 20f;
            table.DefaultCell.Padding = 5;
            table.DefaultCell.BackgroundColor = new BaseColor(240, 240, 240);
            table.DefaultCell.BorderColor = new BaseColor(128, 128, 128);

            // Add header cells
            foreach (DataColumn column in dt.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                table.AddCell(cell);
            }

            // Add data cells
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(row[column].ToString()));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    table.AddCell(cell);
                }
            }

            doc.Add(table);

            // Close the document
            doc.Close();

            MessageBox.Show("Downloaded Successfully", "inform", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*string[] headers = { "Id", "Registration Number", "Name", "Status" };
            DateTime date = DateTime.Now;
            var dates = date.ToString("yyyy-MM-dd");
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select max(Id) from ClassAttendance", con1);
            int Ids = (Int32)cmd1.ExecuteScalar();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select distinct Student.Id, RegistrationNumber , FirstName + ' ' + LastName As Name,(select Name from Lookup where LookupId=StudentAttendance.AttendanceStatus) As Status From Student JOIN StudentAttendance on Student.Id=StudentAttendance.StudentId JOIN ClassAttendance on ClassAttendance.Id=StudentAttendance.AttendanceId  Where Status = 5 and AttendanceDate=@AttendanceDate", con);
            cmd.Parameters.AddWithValue("@Id", Ids);
            cmd.Parameters.AddWithValue("@AttendanceDate", date);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridAttendance.DataSource = dt;
            Document doc = new Document();


            // Create a new PDF writer
            string temp = date + " " + "Attendance_Report.pdf";
            //MaterialMessageBox.Show(temp);
            PdfWriter.GetInstance(doc, new FileStream(temp, FileMode.Create));

            // Open the document
            doc.Open();
            // Add heading with current date and time
            PdfPTable headingTable = new PdfPTable(1);
            headingTable.WidthPercentage = 100;

            PdfPCell headingCell = new PdfPCell(new Phrase("Attendance Report - " + dates));
            headingCell.HorizontalAlignment = Element.ALIGN_CENTER;
            headingCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            headingCell.Padding = 8;
            headingCell.BackgroundColor = new BaseColor(204, 204, 204);
            headingTable.AddCell(headingCell);

            doc.Add(headingTable);


            // Create a new table with the same number of columns as the DataGridView
            PdfPTable table = new PdfPTable(GridAttendance.ColumnCount);
            table.WidthPercentage = 100;

            // Add the column headers to the table
            for (int i = 0; i < GridAttendance.ColumnCount; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(GridAttendance.Columns[i].HeaderText));
                cell.BackgroundColor = new BaseColor(204, 204, 204); // gray background color
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.Padding = 8;
                table.AddCell(cell);
            }

            // Add the rows to the table
            for (int i = 0; i < GridAttendance.RowCount; i++)
            {
                for (int j = 0; j < GridAttendance.ColumnCount; j++)
                {
                    if (GridAttendance[j, i].Value != null)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(GridAttendance[j, i].Value.ToString()));
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
            MessageBox.Show("Downloaded Successfully", "inform", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void GridAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
