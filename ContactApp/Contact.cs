using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp
{
    public class Contact
    {
        //what describes a contact
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public Contact()
        {
            
        }

        public override string? ToString()
        {
            return $"Name: {FirstName} {LastName} Phone: {PhoneNumber} Email: {Email}";
            //return base.ToString() + " toast";
        }


        //what a contact can do
    }
}
