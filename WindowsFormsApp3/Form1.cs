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
            simpleOpenGlControl1.InitializeContexts();
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
            
            textBox1.Visible = true;
            label4.Visible = true;
            
            //var a = Convert.ToDouble(textBox4.Text);
            //var b = Convert.ToDouble(textBox3.Text);
            //var c = Convert.ToDouble(textBox1.Text);
            
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
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
        void elipsoid()
        {
            
        }
        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            var a = 0.9;
            var b = 0.9;
            var c = 0.9;
            var tStep = Math.PI / 50;
            var sStep = Math.PI / 50;

            Tao.OpenGl.Gl.glClear(Tao.OpenGl.Gl.GL_COLOR_BUFFER_BIT | Tao.OpenGl.Gl.GL_DEPTH_BUFFER_BIT);
            Tao.OpenGl.Gl.glPolygonMode(Tao.OpenGl.Gl.GL_FRONT_AND_BACK, Tao.OpenGl.Gl.GL_LINE);

            for (double t = -Math.PI; t <= (Math.PI / 2) + .0001; t += tStep)
            {
                /*сообщаем что нужно рисовать точку или точки*/
                Tao.OpenGl.Gl.glBegin(Tao.OpenGl.Gl.GL_TRIANGLE_STRIP);
                Tao.OpenGl.Gl.glColor3d(0.0f, 1.0f, 0.0f);
                for (double s = -Math.PI; s <= Math.PI + .0001; s += sStep)
                {
                    float x1 = (float)(a * Math.Sin(t) * Math.Cos(s));
                    float y1 = (float)(b * Math.Sin(t) * Math.Sin(s));
                    float z1 = (float)(c * Math.Cos(t));
                    Tao.OpenGl.Gl.glColor3d(0.0f, 1.0f, 0.0f);
                    Tao.OpenGl.Gl.glVertex3f(x1, y1, z1);

                    float x2 = (float)(a * Math.Sin(t + tStep) * Math.Cos(s));
                    float y2 = (float)(b * Math.Sin(t + tStep) * Math.Sin(s));
                    float z2 = (float)(c * Math.Cos(t + tStep));
                    Tao.OpenGl.Gl.glColor3d(1.0f, 0.5f, 0.0f);
                    Tao.OpenGl.Gl.glVertex3f(x2, y2, z2);
                }
                /*сообщаем что завершили рисовать точку или точки*/
                Tao.OpenGl.Gl.glEnd();
            }
            /*перерисовываем окно */
            simpleOpenGlControl1.Invalidate();
        }

        bool IsDown = false;

        private void simpleOpenGlControl1_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown = false;
        }

        private void simpleOpenGlControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown)
            {
                this.Text = "X: " + e.X.ToString() + "; Y: " + e.Y.ToString();
                Tao.OpenGl.Gl.glRotated(1, .0, e.Y, e.X);
            }
        }
        
        private void simpleOpenGlControl1_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown = true;
        }
    }
}
