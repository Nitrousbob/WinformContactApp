using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactApp
{
    public partial class ContactControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Contact ContactDetails { get; set; }
        public ContactControl(Contact contactDetails)
        {
            InitializeComponent();
            ContactDetails = contactDetails;

            //fill in all the details on the control using the data
            lblFullName.Text = $"{ContactDetails.FullName}";
            lblEmailInfo.Text = ContactDetails.Email;
            lblPhoneDisplay.Text = ContactDetails.PhoneNumber;
        }

        private void btnMarkContacted_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have marked {ContactDetails.FullName} as contacted.");

        }
    }
}
