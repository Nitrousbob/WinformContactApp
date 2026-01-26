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
            label1 = new Label();
            textBox1 = new TextBox();
            lblContactList = new Label();
            gbContact.SuspendLayout();
            SuspendLayout();
            // 
            // gbContact
            // 
            gbContact.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbContact.Controls.Add(label1);
            gbContact.Controls.Add(textBox1);
            gbContact.Dock = DockStyle.Top;
            gbContact.Location = new Point(0, 0);
            gbContact.Name = "gbContact";
            gbContact.Size = new Size(484, 154);
            gbContact.TabIndex = 0;
            gbContact.TabStop = false;
            gbContact.Text = "Contact Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Right;
            textBox1.Location = new Point(47, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 23);
            textBox1.TabIndex = 0;
            // 
            // lblContactList
            // 
            lblContactList.AutoSize = true;
            lblContactList.Location = new Point(12, 115);
            lblContactList.Name = "lblContactList";
            lblContactList.Size = new Size(0, 15);
            lblContactList.TabIndex = 1;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
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
        private Label label1;
        private TextBox textBox1;
    }
}
