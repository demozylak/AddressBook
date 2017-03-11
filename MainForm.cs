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
            MessageBox.Show("dupa");
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
                
            Contact c = addressbook.getContact(listBox1.SelectedIndex);
            lblName.Text = c.Name;
            lblNumber.Text = c.Number;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            addressbook.remContact(listBox1.SelectedIndex);
            updateList();
            lblName.Text = "";
            lblNumber.Text = "";
        }

    }
}
