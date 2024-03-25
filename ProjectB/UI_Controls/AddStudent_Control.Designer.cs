namespace ProjectB.UI_Controls
{
    partial class AddStudent_Control
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbx_contact = new System.Windows.Forms.RichTextBox();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.txtbx_email = new System.Windows.Forms.RichTextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtbx_regno = new System.Windows.Forms.RichTextBox();
            this.lbl_RegNo = new System.Windows.Forms.Label();
            this.txtbx_lastname = new System.Windows.Forms.RichTextBox();
            this.txtbx_firstname = new System.Windows.Forms.RichTextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.status_combo_box = new System.Windows.Forms.ComboBox();
            this.btn_StudentAdd = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::ProjectB.Properties.Resources.download;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_StudentAdd);
            this.panel2.Controls.Add(this.status_combo_box);
            this.panel2.Controls.Add(this.lbl_status);
            this.panel2.Controls.Add(this.txtbx_contact);
            this.panel2.Controls.Add(this.lbl_Contact);
            this.panel2.Controls.Add(this.txtbx_email);
            this.panel2.Controls.Add(this.lbl_Email);
            this.panel2.Controls.Add(this.txtbx_regno);
            this.panel2.Controls.Add(this.lbl_RegNo);
            this.panel2.Controls.Add(this.txtbx_lastname);
            this.panel2.Controls.Add(this.txtbx_firstname);
            this.panel2.Controls.Add(this.lbl_LastName);
            this.panel2.Controls.Add(this.lbl_FirstName);
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 533);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtbx_contact
            // 
            this.txtbx_contact.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtbx_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_contact.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_contact.Location = new System.Drawing.Point(329, 317);
            this.txtbx_contact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_contact.Name = "txtbx_contact";
            this.txtbx_contact.Size = new System.Drawing.Size(310, 39);
            this.txtbx_contact.TabIndex = 58;
            this.txtbx_contact.Text = "";
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact.Location = new System.Drawing.Point(210, 323);
            this.lbl_Contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(87, 25);
            this.lbl_Contact.TabIndex = 57;
            this.lbl_Contact.Text = "Contact";
            // 
            // txtbx_email
            // 
            this.txtbx_email.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtbx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_email.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_email.Location = new System.Drawing.Point(329, 252);
            this.txtbx_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(310, 39);
            this.txtbx_email.TabIndex = 56;
            this.txtbx_email.Text = "";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(232, 258);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(65, 25);
            this.lbl_Email.TabIndex = 55;
            this.lbl_Email.Text = "Email";
            // 
            // txtbx_regno
            // 
            this.txtbx_regno.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtbx_regno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_regno.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_regno.Location = new System.Drawing.Point(329, 184);
            this.txtbx_regno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_regno.Name = "txtbx_regno";
            this.txtbx_regno.Size = new System.Drawing.Size(310, 39);
            this.txtbx_regno.TabIndex = 54;
            this.txtbx_regno.Text = "";
            // 
            // lbl_RegNo
            // 
            this.lbl_RegNo.AutoSize = true;
            this.lbl_RegNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_RegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegNo.Location = new System.Drawing.Point(92, 189);
            this.lbl_RegNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RegNo.Name = "lbl_RegNo";
            this.lbl_RegNo.Size = new System.Drawing.Size(207, 25);
            this.lbl_RegNo.TabIndex = 53;
            this.lbl_RegNo.Text = "Registration Number";
            this.lbl_RegNo.Click += new System.EventHandler(this.lbl_RegNo_Click);
            // 
            // txtbx_lastname
            // 
            this.txtbx_lastname.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtbx_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_lastname.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_lastname.Location = new System.Drawing.Point(329, 115);
            this.txtbx_lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_lastname.Name = "txtbx_lastname";
            this.txtbx_lastname.Size = new System.Drawing.Size(310, 39);
            this.txtbx_lastname.TabIndex = 52;
            this.txtbx_lastname.Text = "";
            // 
            // txtbx_firstname
            // 
            this.txtbx_firstname.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtbx_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_firstname.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_firstname.Location = new System.Drawing.Point(329, 49);
            this.txtbx_firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_firstname.Name = "txtbx_firstname";
            this.txtbx_firstname.Size = new System.Drawing.Size(310, 39);
            this.txtbx_firstname.TabIndex = 51;
            this.txtbx_firstname.Text = "";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(183, 121);
            this.lbl_LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(115, 25);
            this.lbl_LastName.TabIndex = 48;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(181, 55);
            this.lbl_FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(116, 25);
            this.lbl_FirstName.TabIndex = 47;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(212, 393);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(74, 25);
            this.lbl_status.TabIndex = 59;
            this.lbl_status.Text = "Status";
            // 
            // status_combo_box
            // 
            this.status_combo_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.status_combo_box.BackColor = System.Drawing.SystemColors.GrayText;
            this.status_combo_box.ForeColor = System.Drawing.Color.White;
            this.status_combo_box.FormattingEnabled = true;
            this.status_combo_box.Location = new System.Drawing.Point(329, 223);
            this.status_combo_box.Name = "status_combo_box";
            this.status_combo_box.Size = new System.Drawing.Size(310, 28);
            this.status_combo_box.Sorted = true;
            this.status_combo_box.TabIndex = 60;
            // 
            // btn_StudentAdd
            // 
            this.btn_StudentAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StudentAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StudentAdd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btn_StudentAdd.Location = new System.Drawing.Point(340, 455);
            this.btn_StudentAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_StudentAdd.Name = "btn_StudentAdd";
            this.btn_StudentAdd.Size = new System.Drawing.Size(162, 68);
            this.btn_StudentAdd.TabIndex = 61;
            this.btn_StudentAdd.Text = "Add";
            this.btn_StudentAdd.UseVisualStyleBackColor = false;
            this.btn_StudentAdd.Click += new System.EventHandler(this.btn_StudentAdd_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectB.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(834, 602);
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtbx_contact;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.RichTextBox txtbx_email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.RichTextBox txtbx_regno;
        private System.Windows.Forms.Label lbl_RegNo;
        private System.Windows.Forms.RichTextBox txtbx_lastname;
        private System.Windows.Forms.RichTextBox txtbx_firstname;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.ComboBox status_combo_box;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_StudentAdd;
    }
}
