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
    public partial class MainForm : Form
    {
        public AB addressbook = AB.Instance; // well should be private - new design needed

        public MainForm()
        {
            InitializeComponent();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Contact c in addressbook) 
            {
                if(c.Name.Contains(searchbox.Text) || c.Number.Contains(searchbox.Text))
                {
                    listBox1.Items.Add(c.Name);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void newcontact_Click(object sender, EventArgs e)
        {
            NewContactDialog subForm = new NewContactDialog(this);
            subForm.ShowDialog();
            updateList();

        }

        private void updateList()
        {
            listBox1.Items.Clear();
            foreach (Contact c in addressbook)
            {
                listBox1.Items.Add(c.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                lblName.Text = "";
                lblNumber.Text = "";
                return;
            }
                
            Contact c = addressbook.getContact((String)listBox1.SelectedItem);
            lblName.Text = c.Name;
            lblNumber.Text = c.Number;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            addressbook.remContact((String)listBox1.SelectedItem);
            updateList();
            lblName.Text = "";
            lblNumber.Text = "";
        }

    }
}
