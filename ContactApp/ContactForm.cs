using System.Diagnostics;
#pragma warning disable WFO1000

namespace ContactApp
{
    public partial class ContactForm : Form
    {
        public List<Contact> Contacts { get; set; }
        public ContactForm()
        {
            InitializeComponent();
            Contacts = new List<Contact>();

            //refreshes the list box with the newest contacts
            UpdateContactListBox();
        }

        public void UpdateContactListBox()
        {
            lbContacts.Items.Clear();  //clear existing items in the list box
            foreach (Contact contact in Contacts)
            {
                lbContacts.Items.Add(contact); //add each contact to the list box
            }
        }

        public void AddContact(  //a method to add a contact by details
            string first,
            string last,
            string? phone = null,
            string? email = null
            )
        {
            Contacts.Add(new Contact
            {
                FirstName = first,
                LastName = last,
                PhoneNumber = phone,
                Email = email
            });
        }
        public void AddContact(Contact contact)  //a method to add a contact by object
        {
            Contacts.Add(contact);
        }
        private void ContactForm_Load(object sender, EventArgs e)
        {
            foreach (var contact in Contacts)
            {
                Debug.WriteLine(contact);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate the data, some type of failure message
            if (txtFirstName.Text.Length <= 0) //check if first name does not contain data
            {
                MessageBox.Show("First name must contain a letter.");
                txtFirstName.Focus();
                return;
            }
            if (txtLastName.Text.Length <= 0) //check if first name does not contain data
            {
                MessageBox.Show("Last name must contain a letter.");
                txtLastName.Focus();
                return;
            }
            if (txtEmail.Text.Length <= 0 && txtPhoneNumber.Text.Length <= 0) //check if email and phone number
            {
                MessageBox.Show("You need an Email or Phone number to create a contact.");
                txtPhoneNumber.Focus();
                return;
            }
            //capture data
            //create a new contact
            Contact newContact = new Contact  //Create a Contact Object
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
            };
            //add it to the list
            Contacts.Add(newContact);  //Add the Contact to the Contact List
            //update the list
            UpdateContactListBox();
            ClearForm();
            txtFirstName.Focus(); //set focus back to the first name text box
        }

        private void lbContacts_Click(object sender, EventArgs e)
        {
            Contact selectedObject = (Contact)lbContacts.SelectedItem;
            if (selectedObject != null)
            {
                int selectedIndex = lbContacts.SelectedIndex;

                Debug.WriteLine($"contact list box was clicked: {selectedObject}");
                selectedObject.IsContacted = true;
                lbContacts.Items[selectedIndex] = selectedObject; //update the item in the list box
                //show message box that says the contact was contacted
                MessageBox.Show($"Mark {selectedObject.FirstName} {selectedObject.LastName} as contacted?", "Success");
                lbContacts.Items.RemoveAt(selectedIndex);
                //lbContacts.Items = Contacts.Where(contact => contact.IsContacted == false);
            }
        }

        private void ClearForm()
        {             
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
        }

        private void btn_ClearClicked(object sender, EventArgs e)
        {
            //gain access to the text boxes and clear them
            ClearForm();
            txtFirstName.Focus();
        }
    }
}
