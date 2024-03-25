namespace ProjectB.UI_Controls
{
    partial class Students_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students_Control));
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Full_panel = new System.Windows.Forms.Panel();
            this.search_bar_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Mark_Attandance = new Guna.UI2.WinForms.Guna2Button();
            this.Attendance_box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Add_student_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.status_bar_panel = new System.Windows.Forms.Panel();
            this.count_students_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.Full_panel.SuspendLayout();
            this.search_bar_panel.SuspendLayout();
            this.status_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeight = 30;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.GridColor = System.Drawing.Color.DarkGray;
            this.dataGrid.Location = new System.Drawing.Point(1, 80);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.Size = new System.Drawing.Size(1304, 331);
            this.dataGrid.TabIndex = 16;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGrid.ThemeStyle.ReadOnly = true;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.ThemeStyle.RowsStyle.Height = 28;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // Full_panel
            // 
            this.Full_panel.BackColor = System.Drawing.Color.White;
            this.Full_panel.BackgroundImage = global::ProjectB.Properties.Resources.download;
            this.Full_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Full_panel.Controls.Add(this.dataGrid);
            this.Full_panel.Controls.Add(this.search_bar_panel);
            this.Full_panel.Controls.Add(this.status_bar_panel);
            this.Full_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Full_panel.Location = new System.Drawing.Point(0, 0);
            this.Full_panel.Name = "Full_panel";
            this.Full_panel.Size = new System.Drawing.Size(834, 602);
            this.Full_panel.TabIndex = 4;
            this.Full_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Full_panel_Paint_1);
            // 
            // search_bar_panel
            // 
            this.search_bar_panel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.search_bar_panel.Controls.Add(this.Mark_Attandance);
            this.search_bar_panel.Controls.Add(this.Attendance_box);
            this.search_bar_panel.Controls.Add(this.Delete_btn);
            this.search_bar_panel.Controls.Add(this.Add_student_btn);
            this.search_bar_panel.Controls.Add(this.Searchbox);
            this.search_bar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_bar_panel.Location = new System.Drawing.Point(0, 0);
            this.search_bar_panel.Name = "search_bar_panel";
            this.search_bar_panel.Size = new System.Drawing.Size(834, 78);
            this.search_bar_panel.TabIndex = 14;
            // 
            // Mark_Attandance
            // 
            this.Mark_Attandance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Mark_Attandance.BorderRadius = 10;
            this.Mark_Attandance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mark_Attandance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Mark_Attandance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Mark_Attandance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Mark_Attandance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Mark_Attandance.FillColor = System.Drawing.Color.DarkGray;
            this.Mark_Attandance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Mark_Attandance.ForeColor = System.Drawing.Color.Black;
            this.Mark_Attandance.Image = ((System.Drawing.Image)(resources.GetObject("Mark_Attandance.Image")));
            this.Mark_Attandance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Mark_Attandance.Location = new System.Drawing.Point(269, 17);
            this.Mark_Attandance.Name = "Mark_Attandance";
            this.Mark_Attandance.Size = new System.Drawing.Size(209, 48);
            this.Mark_Attandance.TabIndex = 58;
            this.Mark_Attandance.Text = "Mark Attendance";
            this.Mark_Attandance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Mark_Attandance.Click += new System.EventHandler(this.Mark_Attandance_Click);
            // 
            // Attendance_box
            // 
            this.Attendance_box.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Attendance_box.BackColor = System.Drawing.Color.Transparent;
            this.Attendance_box.BorderRadius = 10;
            this.Attendance_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Attendance_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Attendance_box.FillColor = System.Drawing.Color.DarkGray;
            this.Attendance_box.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Attendance_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Attendance_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Attendance_box.ForeColor = System.Drawing.Color.Black;
            this.Attendance_box.ItemHeight = 30;
            this.Attendance_box.Location = new System.Drawing.Point(485, 11);
            this.Attendance_box.Name = "Attendance_box";
            this.Attendance_box.Size = new System.Drawing.Size(144, 36);
            this.Attendance_box.TabIndex = 0;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Delete_btn.BorderRadius = 10;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_btn.FillColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete_btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("Delete_btn.Image")));
            this.Delete_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_btn.ImageSize = new System.Drawing.Size(18, 18);
            this.Delete_btn.Location = new System.Drawing.Point(206, 17);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(191, 48);
            this.Delete_btn.TabIndex = 57;
            this.Delete_btn.Text = "Delete Student";
            this.Delete_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Add_student_btn
            // 
            this.Add_student_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Add_student_btn.BorderRadius = 10;
            this.Add_student_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_student_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_student_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_student_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_student_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_student_btn.FillColor = System.Drawing.Color.DarkGray;
            this.Add_student_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add_student_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_student_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_student_btn.Image")));
            this.Add_student_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_student_btn.Location = new System.Drawing.Point(3, 17);
            this.Add_student_btn.Name = "Add_student_btn";
            this.Add_student_btn.Size = new System.Drawing.Size(197, 48);
            this.Add_student_btn.TabIndex = 56;
            this.Add_student_btn.Text = "Add Student";
            this.Add_student_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_student_btn.Click += new System.EventHandler(this.Add_student_btn_Click);
            // 
            // Searchbox
            // 
            this.Searchbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Searchbox.BorderRadius = 10;
            this.Searchbox.BorderThickness = 2;
            this.Searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchbox.DefaultText = "";
            this.Searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.FillColor = System.Drawing.Color.DarkGray;
            this.Searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Searchbox.ForeColor = System.Drawing.Color.Black;
            this.Searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Searchbox.IconLeft")));
            this.Searchbox.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Searchbox.IconLeftSize = new System.Drawing.Size(18, 18);
            this.Searchbox.Location = new System.Drawing.Point(642, 13);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.PasswordChar = '\0';
            this.Searchbox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Searchbox.PlaceholderText = "Search";
            this.Searchbox.SelectedText = "";
            this.Searchbox.Size = new System.Drawing.Size(189, 52);
            this.Searchbox.TabIndex = 55;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged_1);
            // 
            // status_bar_panel
            // 
            this.status_bar_panel.BackColor = System.Drawing.Color.DimGray;
            this.status_bar_panel.Controls.Add(this.count_students_label);
            this.status_bar_panel.Controls.Add(this.label7);
            this.status_bar_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_bar_panel.Location = new System.Drawing.Point(0, 577);
            this.status_bar_panel.Name = "status_bar_panel";
            this.status_bar_panel.Size = new System.Drawing.Size(834, 25);
            this.status_bar_panel.TabIndex = 15;
            // 
            // count_students_label
            // 
            this.count_students_label.AutoSize = true;
            this.count_students_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.count_students_label.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_students_label.Location = new System.Drawing.Point(105, 0);
            this.count_students_label.Name = "count_students_label";
            this.count_students_label.Size = new System.Drawing.Size(18, 19);
            this.count_students_label.TabIndex = 9;
            this.count_students_label.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Stuents:";
            // 
            // Students_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Full_panel);
            this.Name = "Students_Control";
            this.Size = new System.Drawing.Size(834, 602);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.Full_panel.ResumeLayout(false);
            this.search_bar_panel.ResumeLayout(false);
            this.status_bar_panel.ResumeLayout(false);
            this.status_bar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        public System.Windows.Forms.Panel Full_panel;
        private Guna.UI2.WinForms.Guna2Panel search_bar_panel;
        private Guna.UI2.WinForms.Guna2Button Mark_Attandance;
        private Guna.UI2.WinForms.Guna2ComboBox Attendance_box;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private Guna.UI2.WinForms.Guna2Button Add_student_btn;
        private Guna.UI2.WinForms.Guna2TextBox Searchbox;
        private System.Windows.Forms.Panel status_bar_panel;
        private System.Windows.Forms.Label count_students_label;
        private System.Windows.Forms.Label label7;
    }
}
