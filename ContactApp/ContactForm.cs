using System.Diagnostics;

namespace ContactApp
{
    public partial class ContactForm : Form
    {
        public List<Contact> Contacts { get; set; }
        public ContactForm()
        {
            InitializeComponent();
            Contacts = new List<Contact>();

            Contacts.Add(new Contact
            {
                FirstName = "Bear",
                LastName = "Fulmer",
                PhoneNumber = "123-456-7890",
                Email = "bf@gmail.com"
            }
            );

            Contacts.Add(new Contact
            {
                FirstName = "Ron",
                LastName = "Swanson",
                PhoneNumber = "123-436-7890",
                Email = "rs@gmail.com"
            }
            );

            AddContact(new Contact
            {
                FirstName = "April",
                LastName = "Ludgate",
                PhoneNumber = "123-456-7891",
                Email = "al@gmail.com"
            });
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
    }
}
