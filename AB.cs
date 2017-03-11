using System;
using System.IO;
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
            load();
        }

        public void addContact(Contact c)
        {
            allContacts.Add(c);
            save();
        }

        public List<Contact> GetList()
        {
            return allContacts;
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return allContacts.GetEnumerator();
        }

        public Contact getContact(int n) 
        {
            return allContacts[n];
        }
        
        private void save()
        {
                StreamWriter w = new StreamWriter("save.txt");

                foreach (Contact c in allContacts)
                {
                    w.WriteLine(c.Name);
                    w.WriteLine(c.Number);
                }
                w.Close();
        }

        private void load()
        {
            StreamReader reader = new StreamReader("save.txt");
            try
            {
                do
                {
                    Contact c = new Contact(reader.ReadLine(), reader.ReadLine());
                    allContacts.Add(c);
                }
                while (reader.Peek() != -1);
            }

            catch
            {
            }

            finally
            {
                reader.Close();
            }
        }
        
    }
}
