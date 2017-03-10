using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public sealed class AB
    {
        private static AB instance = null;

        private AB()
        {
        }

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

    }
}
