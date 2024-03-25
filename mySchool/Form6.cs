﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySchool
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addrecord addrecord = new Addrecord();
            addrecord.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deleteform deleteform = new Deleteform();
            deleteform.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
