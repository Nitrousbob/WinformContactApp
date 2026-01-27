namespace ContactApp
{
    partial class ContactForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbContact = new GroupBox();
            btnSave = new Button();
            lblFirstName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblContactList = new Label();
            lbContacts = new ListBox();
            gbContact.SuspendLayout();
            SuspendLayout();
            // 
            // gbContact
            // 
            gbContact.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbContact.Controls.Add(btnSave);
            gbContact.Controls.Add(lblFirstName);
            gbContact.Controls.Add(lblEmail);
            gbContact.Controls.Add(lblPhoneNumber);
            gbContact.Controls.Add(txtEmail);
            gbContact.Controls.Add(txtPhoneNumber);
            gbContact.Controls.Add(lblLastName);
            gbContact.Controls.Add(txtLastName);
            gbContact.Controls.Add(txtFirstName);
            gbContact.Dock = DockStyle.Top;
            gbContact.Location = new Point(0, 0);
            gbContact.Name = "gbContact";
            gbContact.Size = new Size(569, 222);
            gbContact.TabIndex = 0;
            gbContact.TabStop = false;
            gbContact.Text = "Contact Form";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(488, 193);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.None;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(24, 40);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Anchor = AnchorStyles.None;
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(24, 121);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(51, 15);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone #";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(107, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(395, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.None;
            txtPhoneNumber.Location = new Point(107, 113);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(395, 23);
            txtPhoneNumber.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.None;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(24, 80);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.Location = new Point(107, 72);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(395, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.Location = new Point(107, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(395, 23);
            txtFirstName.TabIndex = 0;
            // 
            // lblContactList
            // 
            lblContactList.AutoSize = true;
            lblContactList.Location = new Point(12, 115);
            lblContactList.Name = "lblContactList";
            lblContactList.Size = new Size(0, 15);
            lblContactList.TabIndex = 1;
            // 
            // lbContacts
            // 
            lbContacts.FormattingEnabled = true;
            lbContacts.Location = new Point(12, 228);
            lbContacts.Name = "lbContacts";
            lbContacts.Size = new Size(545, 229);
            lbContacts.TabIndex = 2;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 467);
            Controls.Add(lbContacts);
            Controls.Add(lblContactList);
            Controls.Add(gbContact);
            Name = "ContactForm";
            Text = "Contacts";
            Load += ContactForm_Load;
            gbContact.ResumeLayout(false);
            gbContact.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbContact;
        private Label lblContactList;
        private TextBox txtFirstName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private Button btnSave;
        private ListBox lbContacts;
    }
}
