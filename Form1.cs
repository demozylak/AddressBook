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
    public partial class Form1 : Form
    {
        public Form1()
        {
            AB addressbook = AB.Instance;
 
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                listBox1.Items.Add("asdasd");
            }
            listBox1.Items.Add("asdasd");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("dupa");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
