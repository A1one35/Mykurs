using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        double a, b, c;
        public Form2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            InitializeComponent();
            elipsoidGraph.InitializeContexts();
        }
        private void elipsoidGraph_Paint(object sender, PaintEventArgs e)
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
                for (double s = -Math.PI; s <= Math.PI + .0001; s += sStep)
                {
                    float x1 = (float)(a * Math.Sin(t) * Math.Cos(s));
                    float y1 = (float)(b * Math.Sin(t) * Math.Sin(s));
                    float z1 = (float)(c * Math.Cos(t));
                    Gl.glColor3d(0.0f, 1.0f, 0.0f);
                    Gl.glVertex3f(x1, y1, z1);

                    float x2 = (float)(a * Math.Sin(t + tStep) * Math.Cos(s));
                    float y2 = (float)(b * Math.Sin(t + tStep) * Math.Sin(s));
                    float z2 = (float)(c * Math.Cos(t + tStep));
                    Gl.glColor3d(1.0f, 0.5f, 0.0f);
                    Gl.glVertex3f(x2, y2, z2);
                }
                /*сообщаем что завершили рисовать точку или точки*/
                Gl.glEnd();
            }
            /*перерисовываем окно */
            elipsoidGraph.Invalidate();
        }
        bool IsDown = false;
        private void elipsoidGraph_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown = false;
        }
        private void elipsoidGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown)
            {
                this.Text = "X: " + e.X.ToString() + "; Y: " + e.Y.ToString();
                Gl.glRotated(1, e.X, e.X, e.Y);
            }
        }
        private void elipsoidGraph_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
        }
    }
}