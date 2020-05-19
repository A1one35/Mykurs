using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label4.Visible = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label4.Visible = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label4.Visible = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            textBox1.Visible = true;


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label4.Visible = true;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
