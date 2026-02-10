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
            Label lblPhoneLabel;
            Label lblAddressLabel;
            btnMarkContacted = new Button();
            lblPhoneDisplay = new Label();
            lblEmailInfo = new Label();
            lblFullNameLabel = new Label();
            lblFullName = new Label();
            lblPhoneLabel = new Label();
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
            // lblAddressLabel
            // 
            lblAddressLabel.AutoSize = true;
            lblAddressLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressLabel.Location = new Point(3, 60);
            lblAddressLabel.Name = "lblAddressLabel";
            lblAddressLabel.Size = new Size(62, 25);
            lblAddressLabel.TabIndex = 4;
            lblAddressLabel.Text = "Email:";
            // 
            // btnMarkContacted
            // 
            btnMarkContacted.Location = new Point(273, 14);
            btnMarkContacted.Name = "btnMarkContacted";
            btnMarkContacted.Size = new Size(75, 23);
            btnMarkContacted.TabIndex = 6;
            btnMarkContacted.Text = "Contact";
            btnMarkContacted.UseVisualStyleBackColor = true;
            btnMarkContacted.Click += btnMarkContacted_Click;
            // 
            // lblPhoneDisplay
            // 
            lblPhoneDisplay.AutoSize = true;
            lblPhoneDisplay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneDisplay.Location = new Point(92, 35);
            lblPhoneDisplay.Name = "lblPhoneDisplay";
            lblPhoneDisplay.Size = new Size(104, 25);
            lblPhoneDisplay.TabIndex = 7;
            lblPhoneDisplay.Text = "Phone XXX";
            // 
            // lblEmailInfo
            // 
            lblEmailInfo.AutoSize = true;
            lblEmailInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailInfo.Location = new Point(92, 60);
            lblEmailInfo.Name = "lblEmailInfo";
            lblEmailInfo.Size = new Size(133, 25);
            lblEmailInfo.TabIndex = 8;
            lblEmailInfo.Text = "person@place";
            // 
            // ContactControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblEmailInfo);
            Controls.Add(lblPhoneDisplay);
            Controls.Add(btnMarkContacted);
            Controls.Add(lblAddressLabel);
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
        private Label lblPhoneDisplay;
        private Label lblEmailInfo;
    }
}
