namespace ContactApp
{
    partial class ContactControl
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
            Label lblFullNameLabel;
            Label lblFullName;
            Label lblPhoneNumber;
            Label lblPhoneLabel;
            Label lblAddress;
            Label lblAddressLabel;
            btnMarkContacted = new Button();
            lblFullNameLabel = new Label();
            lblFullName = new Label();
            lblPhoneNumber = new Label();
            lblPhoneLabel = new Label();
            lblAddress = new Label();
            lblAddressLabel = new Label();
            SuspendLayout();
            // 
            // lblFullNameLabel
            // 
            lblFullNameLabel.AutoSize = true;
            lblFullNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullNameLabel.Location = new Point(3, 10);
            lblFullNameLabel.Name = "lblFullNameLabel";
            lblFullNameLabel.Size = new Size(66, 25);
            lblFullNameLabel.TabIndex = 0;
            lblFullNameLabel.Text = "Name:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(92, 10);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 25);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "John Doe";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(92, 35);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(138, 25);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "XXX-XXX-XXXX";
            // 
            // lblPhoneLabel
            // 
            lblPhoneLabel.AutoSize = true;
            lblPhoneLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneLabel.Location = new Point(3, 35);
            lblPhoneLabel.Name = "lblPhoneLabel";
            lblPhoneLabel.Size = new Size(70, 25);
            lblPhoneLabel.TabIndex = 2;
            lblPhoneLabel.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(17, 85);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(179, 50);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "123 Johnson Drive\r\nCentralia, Wa 98531\r\n";
            // 
            // lblAddressLabel
            // 
            lblAddressLabel.AutoSize = true;
            lblAddressLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressLabel.Location = new Point(3, 60);
            lblAddressLabel.Name = "lblAddressLabel";
            lblAddressLabel.Size = new Size(83, 25);
            lblAddressLabel.TabIndex = 4;
            lblAddressLabel.Text = "Address:";
            // 
            // btnMarkContacted
            // 
            btnMarkContacted.Location = new Point(273, 14);
            btnMarkContacted.Name = "btnMarkContacted";
            btnMarkContacted.Size = new Size(75, 23);
            btnMarkContacted.TabIndex = 6;
            btnMarkContacted.Text = "Contact";
            btnMarkContacted.UseVisualStyleBackColor = true;
            // 
            // ContactControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnMarkContacted);
            Controls.Add(lblAddress);
            Controls.Add(lblAddressLabel);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblPhoneLabel);
            Controls.Add(lblFullName);
            Controls.Add(lblFullNameLabel);
            Name = "ContactControl";
            Size = new Size(356, 174);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullNameLabel;
        private Button btnMarkContacted;
    }
}
