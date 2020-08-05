using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
<<<<<<< HEAD
        double a, b, c;
        public Form5(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
=======
        public Form5()
        {
>>>>>>> 41ab3497ae0a6d9f70c31a1b4b8e2bd4b6d43da1
            InitializeComponent();
            hyperboloid1Graph.InitializeContexts();
        }
        private void hyperboloid1Graph_Paint(object sender, PaintEventArgs e)
        {
<<<<<<< HEAD
=======
            var a = 0.9;
            var b = 0.5;
            var c = 0.6;
>>>>>>> 41ab3497ae0a6d9f70c31a1b4b8e2bd4b6d43da1
            var tStep = Math.PI / 15;
            var sStep = Math.PI / 15;

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);

            for (double t = -Math.PI; t <= (Math.PI / 2) + .0001; t += tStep)
            {
                /*сообщаем что нужно рисовать точку или точки*/
                Gl.glBegin(Gl.GL_TRIANGLE_STRIP);
                Gl.glColor3d(0.0f, 1.0f, 0.0f);
                for (double s = -100; s <= 100 + .0001; s += sStep)
                {
                    float x1 = (float)(a * Math.Cosh(t) * Math.Cos(s));
                    float y1 = (float)(b * Math.Cosh(t) * Math.Sin(s));
                    float z1 = (float)(c * Math.Sinh(t));
                    Gl.glColor3d(0.0f, 1.0f, 0.0f);
                    Gl.glVertex3f(x1, y1, z1);

                    float x2 = (float)(a * Math.Cosh(t + tStep) * Math.Cos(s));
                    float y2 = (float)(b * Math.Cosh(t + tStep) * Math.Sin(s));
                    float z2 = (float)(c * Math.Sinh(t + tStep));
                    Gl.glColor3d(1.0f, 0.5f, 0.0f);
                    Gl.glVertex3f(x2, y2, z2);
                }
                /*сообщаем что завершили рисовать точку или точки*/
                Gl.glEnd();
            }
            /*перерисовываем окно */
            hyperboloid1Graph.Invalidate();
        }
        bool IsDown = false;
        private void hyperboloid1Graph_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown = false;
        }
        private void hyperboloid1Graph_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown)
            {
                this.Text = "X: " + e.X.ToString() + "; Y: " + e.Y.ToString();
                Gl.glRotated(1, e.X, e.Y, 0);
            }
        }
        private void hyperboloid1Graph_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown = true;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
        }
    }
}
