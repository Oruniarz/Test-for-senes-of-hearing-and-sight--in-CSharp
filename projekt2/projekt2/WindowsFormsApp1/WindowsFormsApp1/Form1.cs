﻿using System;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInstrukcja_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TopMost = true;
            f2.Show();  
        }

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.TopMost = true;
            f3.Show();
        }



        private void buttonSzkolenie_Test1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.TopMost = true;
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.TopMost = true;
            f6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.TopMost = true;
            f5.Show();
        }

      
    }
}
