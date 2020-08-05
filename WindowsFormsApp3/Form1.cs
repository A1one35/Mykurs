﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private double a, b, c, p, q;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (initGraph())
            {
                Form2 form2 = new Form2(a, b, c);
                form2.ShowDialog();
            }
            else MessageBox.Show("Please, fill in all parameters!");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (initGraph())
            {
                Form3 form3 = new Form3(p, q);
                form3.ShowDialog();
            }
            else MessageBox.Show("Please, fill in all parameters!");
        }
        private void hyperbolicParaboloidButton_Click(object sender, EventArgs e)
        {
            if (initGraph())
            {
                Form4 form4 = new Form4(p, q);
                form4.ShowDialog();
            }
            else MessageBox.Show("Please, fill in all parameters!");
        }
        private void hyperboloid1Button_Click(object sender, EventArgs e)
        {
            if (initGraph())
            {
                Form5 form5 = new Form5(a, b, c);
                form5.ShowDialog();
            }
            else MessageBox.Show("Please, fill in all parameters!");
        }
        private void hyperboloid2Button_Click(object sender, EventArgs e)
        {
            if (initGraph())
            {
                Form6 form6 = new Form6(a, b, c);
                form6.ShowDialog();
            }
            else MessageBox.Show("Please, fill in all parameters!");
        }
        private bool initGraph()
        {
            return (double.TryParse(textBox1.Text, out a) &&
                double.TryParse(textBox2.Text, out b) &&
                double.TryParse(textBox3.Text, out c) &&
                double.TryParse(textBox4.Text, out p) &&
                double.TryParse(textBox5.Text, out q));
        }
    }
}