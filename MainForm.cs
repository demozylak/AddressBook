﻿using System;
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

            foreach (Contact c in addressbook)
            {
                listBox1.Items.Add(c.Name);
            }
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            NewContactDialog subForm = new NewContactDialog(this);
            subForm.ShowDialog();
        }
    }
}