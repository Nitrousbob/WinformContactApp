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
            btnClear = new Button();
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
            gbContact.Controls.Add(btnClear);
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
            gbContact.Margin = new Padding(4, 5, 4, 5);
            gbContact.Name = "gbContact";
            gbContact.Padding = new Padding(4, 5, 4, 5);
            gbContact.Size = new Size(813, 370);
            gbContact.TabIndex = 0;
            gbContact.TabStop = false;
            gbContact.Text = "Contact Form";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(581, 322);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 38);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btn_ClearClicked;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(697, 322);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 38);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.None;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(34, 67);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(34, 263);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Anchor = AnchorStyles.None;
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(34, 202);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(78, 25);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone #";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(153, 258);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(563, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.None;
            txtPhoneNumber.Location = new Point(153, 188);
            txtPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(563, 31);
            txtPhoneNumber.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.None;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(34, 133);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.Location = new Point(153, 120);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(563, 31);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.Location = new Point(153, 53);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(563, 31);
            txtFirstName.TabIndex = 0;
            // 
            // lblContactList
            // 
            lblContactList.AutoSize = true;
            lblContactList.Location = new Point(17, 192);
            lblContactList.Margin = new Padding(4, 0, 4, 0);
            lblContactList.Name = "lblContactList";
            lblContactList.Size = new Size(0, 25);
            lblContactList.TabIndex = 1;
            // 
            // lbContacts
            // 
            lbContacts.FormattingEnabled = true;
            lbContacts.Location = new Point(17, 380);
            lbContacts.Margin = new Padding(4, 5, 4, 5);
            lbContacts.Name = "lbContacts";
            lbContacts.Size = new Size(777, 379);
            lbContacts.TabIndex = 2;
            lbContacts.Click += lbContacts_Click;
            // 
            // ContactForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 778);
            Controls.Add(lbContacts);
            Controls.Add(lblContactList);
            Controls.Add(gbContact);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnClear;
    }
}
