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

            AddContact("Bear", "Fulmer");

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

        public void AddContact(
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
        public void AddContact(Contact contact)
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
        }
    }
}
