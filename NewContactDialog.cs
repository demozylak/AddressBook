using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class NewContactDialog : Form
    {
        private MainForm caller;

        public NewContactDialog(MainForm caller)
        {
            InitializeComponent();
            this.caller = caller;
        }

        private void discard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Contact c = new Contact(tbName.Text, tbNumber.Text);
            caller.addressbook.addContact(c);
            this.Close();
        }




    }
}
