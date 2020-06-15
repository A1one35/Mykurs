using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging; // BitmapData
using OpenTK; // WindowState , Exit() and so on
using OpenTK.Graphics.OpenGL;
using OpenTK.Input; // KeyboardKeyEventArgs

namespace WindowsFormsApp3
{
    public partial class GameWindow : UserControl
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
