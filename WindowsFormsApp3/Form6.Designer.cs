namespace WindowsFormsApp3
{
    partial class Form6
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
            this.hyperboloid2Graph = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // hyperboloid2Graph
            // 
            this.hyperboloid2Graph.AccumBits = ((byte)(0));
            this.hyperboloid2Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hyperboloid2Graph.AutoCheckErrors = false;
            this.hyperboloid2Graph.AutoFinish = false;
            this.hyperboloid2Graph.AutoMakeCurrent = true;
            this.hyperboloid2Graph.AutoSwapBuffers = true;
            this.hyperboloid2Graph.BackColor = System.Drawing.Color.Black;
            this.hyperboloid2Graph.ColorBits = ((byte)(32));
            this.hyperboloid2Graph.DepthBits = ((byte)(16));
            this.hyperboloid2Graph.Location = new System.Drawing.Point(12, 12);
            this.hyperboloid2Graph.Name = "hyperboloid2Graph";
            this.hyperboloid2Graph.Size = new System.Drawing.Size(455, 426);
            this.hyperboloid2Graph.StencilBits = ((byte)(0));
            this.hyperboloid2Graph.TabIndex = 19;
            this.hyperboloid2Graph.Paint += new System.Windows.Forms.PaintEventHandler(this.hyperboloid2Graph_Paint);
            this.hyperboloid2Graph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hyperboloid2Graph_MouseDown);
            this.hyperboloid2Graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hyperboloid2Graph_MouseMove);
            this.hyperboloid2Graph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hyperboloid2Graph_MouseUp);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.hyperboloid2Graph);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.hyperboloid2Graph_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hyperboloid2Graph_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hyperboloid2Graph_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hyperboloid2Graph_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl hyperboloid2Graph;
    }
}