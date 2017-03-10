using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public sealed class AB
    {
        #region Singleton stuff
        private static AB instance = null;

        public static AB Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new AB();
                }
                return instance;
            }
        }
        #endregion

        List<Contact> allContacts;

        private AB() /* private constructor bcs singleton */
        {
            allContacts = new List<Contact>();
            Contact c = new Contact();
            c.Name = "aasd";
            allContacts.Add(c);
        }

        public void addContact(Contact c)
        {
            allContacts.Add(c);
        }

        public List<Contact> GetList()
        {
            return allContacts;
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return allContacts.GetEnumerator();
        }
        
        
    }
}
