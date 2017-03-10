using System;

namespace AddressBook
{
    public class Contact
    {
        public String Name { get; set; }
        public String Number { get; set; }

        public Contact()
        {
        }
        public Contact(String name, String number)
	    {
            this.Name = name;
            this.Number = number;
	    }

    }
}
