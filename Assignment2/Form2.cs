﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form2 : Form
    {
        public Form2(string firstN, string secondN, DateTime DoB)
        {
            InitializeComponent();
            firstName.Text = firstN;
            lastName.Text = secondN;
            DOB.Value = DoB;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
