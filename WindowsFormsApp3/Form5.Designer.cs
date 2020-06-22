namespace WindowsFormsApp3
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hyperboloid1Graph = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // hyperboloid1Graph
            // 
            this.hyperboloid1Graph.AccumBits = ((byte)(0));
            this.hyperboloid1Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hyperboloid1Graph.AutoCheckErrors = false;
            this.hyperboloid1Graph.AutoFinish = false;
            this.hyperboloid1Graph.AutoMakeCurrent = true;
            this.hyperboloid1Graph.AutoSwapBuffers = true;
            this.hyperboloid1Graph.BackColor = System.Drawing.Color.Black;
            this.hyperboloid1Graph.ColorBits = ((byte)(32));
            this.hyperboloid1Graph.DepthBits = ((byte)(16));
            this.hyperboloid1Graph.Location = new System.Drawing.Point(12, 12);
            this.hyperboloid1Graph.Name = "hyperboloid1Graph";
            this.hyperboloid1Graph.Size = new System.Drawing.Size(463, 426);
            this.hyperboloid1Graph.StencilBits = ((byte)(0));
            this.hyperboloid1Graph.TabIndex = 18;
            this.hyperboloid1Graph.Paint += new System.Windows.Forms.PaintEventHandler(this.hyperboloid1Graph_Paint);
            this.hyperboloid1Graph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hyperboloid1Graph_MouseDown);
            this.hyperboloid1Graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hyperboloid1Graph_MouseMove);
            this.hyperboloid1Graph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hyperboloid1Graph_MouseUp);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.hyperboloid1Graph);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.hyperboloid1Graph_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hyperboloid1Graph_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hyperboloid1Graph_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hyperboloid1Graph_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl hyperboloid1Graph;
    }
}