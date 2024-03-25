namespace ProjectB.UI_Controls
{
    partial class Reports_Control
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_cloname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loadclo = new System.Windows.Forms.Button();
            this.btn_downloadclo = new System.Windows.Forms.Button();
            this.btn_downloadass = new System.Windows.Forms.Button();
            this.btn_loadass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGrid.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGrid.ColumnHeadersHeight = 30;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGrid.GridColor = System.Drawing.Color.DarkGray;
            this.dataGrid.Location = new System.Drawing.Point(3, 92);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.Size = new System.Drawing.Size(1304, 331);
            this.dataGrid.TabIndex = 62;
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
            // 
            // lbl_cloname
            // 
            this.lbl_cloname.AutoSize = true;
            this.lbl_cloname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_cloname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cloname.Location = new System.Drawing.Point(617, 470);
            this.lbl_cloname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cloname.Name = "lbl_cloname";
            this.lbl_cloname.Size = new System.Drawing.Size(251, 25);
            this.lbl_cloname.TabIndex = 88;
            this.lbl_cloname.Text = "Assessment Wise Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 481);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "CLO Wise Result";
            // 
            // btn_loadclo
            // 
            this.btn_loadclo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_loadclo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadclo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadclo.ForeColor = System.Drawing.Color.Transparent;
            this.btn_loadclo.Location = new System.Drawing.Point(120, 536);
            this.btn_loadclo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_loadclo.Name = "btn_loadclo";
            this.btn_loadclo.Size = new System.Drawing.Size(109, 50);
            this.btn_loadclo.TabIndex = 90;
            this.btn_loadclo.Text = "Load";
            this.btn_loadclo.UseVisualStyleBackColor = false;
            this.btn_loadclo.Click += new System.EventHandler(this.btn_loadclo_Click);
            // 
            // btn_downloadclo
            // 
            this.btn_downloadclo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_downloadclo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_downloadclo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadclo.ForeColor = System.Drawing.Color.Transparent;
            this.btn_downloadclo.Location = new System.Drawing.Point(250, 536);
            this.btn_downloadclo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_downloadclo.Name = "btn_downloadclo";
            this.btn_downloadclo.Size = new System.Drawing.Size(135, 50);
            this.btn_downloadclo.TabIndex = 91;
            this.btn_downloadclo.Text = "Download";
            this.btn_downloadclo.UseVisualStyleBackColor = false;
            this.btn_downloadclo.Click += new System.EventHandler(this.btn_downloadclo_Click);
            // 
            // btn_downloadass
            // 
            this.btn_downloadass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_downloadass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_downloadass.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadass.ForeColor = System.Drawing.Color.Transparent;
            this.btn_downloadass.Location = new System.Drawing.Point(752, 536);
            this.btn_downloadass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_downloadass.Name = "btn_downloadass";
            this.btn_downloadass.Size = new System.Drawing.Size(130, 50);
            this.btn_downloadass.TabIndex = 93;
            this.btn_downloadass.Text = "Download";
            this.btn_downloadass.UseVisualStyleBackColor = false;
            this.btn_downloadass.Click += new System.EventHandler(this.btn_downloadass_Click);
            // 
            // btn_loadass
            // 
            this.btn_loadass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_loadass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadass.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadass.ForeColor = System.Drawing.Color.Transparent;
            this.btn_loadass.Location = new System.Drawing.Point(622, 536);
            this.btn_loadass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_loadass.Name = "btn_loadass";
            this.btn_loadass.Size = new System.Drawing.Size(109, 50);
            this.btn_loadass.TabIndex = 92;
            this.btn_loadass.Text = "Load";
            this.btn_loadass.UseVisualStyleBackColor = false;
            this.btn_loadass.Click += new System.EventHandler(this.btn_loadass_Click);
            // 
            // Reports_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectB.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_downloadass);
            this.Controls.Add(this.btn_loadass);
            this.Controls.Add(this.btn_downloadclo);
            this.Controls.Add(this.btn_loadclo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cloname);
            this.Controls.Add(this.dataGrid);
            this.Name = "Reports_Control";
            this.Size = new System.Drawing.Size(1002, 671);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private System.Windows.Forms.Label lbl_cloname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_loadclo;
        private System.Windows.Forms.Button btn_downloadclo;
        private System.Windows.Forms.Button btn_downloadass;
        private System.Windows.Forms.Button btn_loadass;
    }
}
