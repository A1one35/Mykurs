using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        double a, b, c;
        public Form6(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            InitializeComponent();
            hyperboloid2Graph.InitializeContexts();
        }
        private void hyperboloid2Graph_Paint(object sender, PaintEventArgs e)
        {
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
                    float x1 = (float)(a * Math.Sinh(t) * Math.Cos(s));
                    float y1 = (float)(b * Math.Sinh(t) * Math.Sin(s));
                    float z1 = (float)(c * Math.Cosh(t));
                    Gl.glColor3d(0.0f, 1.0f, 0.0f);
                    Gl.glVertex3f(x1, y1, z1);

                    float x2 = (float)(a * Math.Sinh(t + tStep) * Math.Cos(s));
                    float y2 = (float)(b * Math.Sinh(t + tStep) * Math.Sin(s));
                    float z2 = (float)(c * Math.Cosh(t + tStep));
                    Gl.glColor3d(1.0f, 0.5f, 0.0f);
                    Gl.glVertex3f(x2, y2, z2);
                }
                for (double s = -100; s <= 100 + .0001; s += sStep)
                {
                    float x1 = (float)(a * Math.Sinh(t) * Math.Cos(s));
                    float y1 = (float)(b * Math.Sinh(t) * Math.Sin(s));
                    float z1 = -(float)(c * Math.Cosh(t));
                    Gl.glColor3d(0.0f, 1.0f, 0.0f);
                    Gl.glVertex3f(x1, y1, z1);

                    float x2 = (float)(a * Math.Sinh(t + tStep) * Math.Cos(s));
                    float y2 = (float)(b * Math.Sinh(t + tStep) * Math.Sin(s));
                    float z2 = -(float)(c * Math.Cosh(t + tStep));
                    Gl.glColor3d(1.0f, 0.5f, 0.0f);
                    Gl.glVertex3f(x2, y2, z2);
                }
                /*сообщаем что завершили рисовать точку или точки*/
                Gl.glEnd();
            }
            /*перерисовываем окно */
            hyperboloid2Graph.Invalidate();
        }
        bool IsDown = false;
        private void hyperboloid2Graph_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown = false;
        }
        private void hyperboloid2Graph_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown)
            {
                this.Text = "X: " + e.X.ToString() + "; Y: " + e.Y.ToString();
                Gl.glRotated(1, e.X, e.Y, 0);
            }
        }
        private void hyperboloid2Graph_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown = true;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
        }
    }
}