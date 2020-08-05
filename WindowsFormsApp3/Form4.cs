﻿using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        double p, q;
        public Form4(double p, double q)
        {
            this.p = p;
            this.q = q;
            InitializeComponent();
            hyperbolicParaboloidGraph.InitializeContexts();
        }
        private void hyperbolicParaboloidGraph_Paint(object sender, PaintEventArgs e)
        {
            var step = 0.2;

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);

            for (double x = -10; x <= 10 + .0001; x += step)
            {
                //сообщаем что нужно рисовать точку или точки
                Gl.glBegin(Gl.GL_TRIANGLE_STRIP);
                Gl.glColor3d(0.0f, 1.0f, 0.0f);
                for (double y = -10; y <= 10 + .0001; y += step)
                {
                    double z1 = Math.Pow(x, 2) / (2 * p) - Math.Pow(y, 2) / (2 * q);
                    Gl.glColor3d(0.0f, 1.0f, 0.0f);
                    Gl.glVertex3f((float)x, (float)y, (float)z1);

                    double z2 = Math.Pow(x + step, 2) / (2 * p) - Math.Pow(y + step, 2) / (2 * q);
                    Gl.glColor3d(0.0f, 1.0f, 0.0f);
                    Gl.glVertex3f((float)(x + step), (float)(y + step), (float)z2);
                }
                //сообщаем что завершили рисовать точку или точки
                Gl.glEnd();
            }
            //перерисовываем окно
            hyperbolicParaboloidGraph.Invalidate();
        }
        bool IsDown = false;
        private void hyperbolicParaboloidGraph_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown = false;
        }
        private void hyperbolicParaboloidGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown)
            {
                this.Text = "X: " + e.X.ToString() + "; Y: " + e.Y.ToString();
                Gl.glRotated(1, e.X, e.Y, 0);
            }
        }
        private void hyperbolicParaboloidGraph_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown = true;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
        }
    }
}
