/*
 * Joey Selamat
 * 9/18/2024
 * 
 * This program is to demonstrate the different GUIs by having the user fill out a form and the data be outputted back to the user
 * 
 * 9/18 - 30 minutes
 * 9/19 - 60 minutes
 * 
 * Analysis:
 * This project took about 1.5 hours to finish. For the first 30 minutes, it was brainstorming 
 * on what kind of project this will be to demonstrate the different GUIs to be used in a form.
 * For the brainstorming, I had to go through a few ideas and changes before settling on this information form.
 * For future purposes, I think planning out what the project will be as well as the context that 
 * will be within each form before creating a project will help a lot in the time consumption
 * I can improve on planning as well as making sure I have what I need to program the project.
 */
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string firstN = firstName.Text;
            string secondN = lastName.Text;
            DateTime dt = DOB.Value;

            Form2 form2 = new Form2(firstN, secondN, dt);
            form2.Show();
        }
    }
}
