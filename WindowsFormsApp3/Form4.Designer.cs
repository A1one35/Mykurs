namespace WindowsFormsApp3
{
    partial class Form4
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
            this.hyperbolicParaboloidGraph = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // hyperbolicParaboloidGraph
            // 
            this.hyperbolicParaboloidGraph.AccumBits = ((byte)(0));
            this.hyperbolicParaboloidGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hyperbolicParaboloidGraph.AutoCheckErrors = false;
            this.hyperbolicParaboloidGraph.AutoFinish = false;
            this.hyperbolicParaboloidGraph.AutoMakeCurrent = true;
            this.hyperbolicParaboloidGraph.AutoSwapBuffers = true;
            this.hyperbolicParaboloidGraph.BackColor = System.Drawing.Color.Black;
            this.hyperbolicParaboloidGraph.ColorBits = ((byte)(32));
            this.hyperbolicParaboloidGraph.DepthBits = ((byte)(16));
            this.hyperbolicParaboloidGraph.Location = new System.Drawing.Point(12, 12);
            this.hyperbolicParaboloidGraph.Name = "hyperbolicParaboloidGraph";
            this.hyperbolicParaboloidGraph.Size = new System.Drawing.Size(442, 426);
            this.hyperbolicParaboloidGraph.StencilBits = ((byte)(0));
            this.hyperbolicParaboloidGraph.TabIndex = 17;
            this.hyperbolicParaboloidGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.hyperbolicParaboloidGraph_Paint);
            this.hyperbolicParaboloidGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hyperbolicParaboloidGraph_MouseDown);
            this.hyperbolicParaboloidGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hyperbolicParaboloidGraph_MouseMove);
            this.hyperbolicParaboloidGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hyperbolicParaboloidGraph_MouseUp);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.hyperbolicParaboloidGraph);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.hyperbolicParaboloidGraph_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hyperbolicParaboloidGraph_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hyperbolicParaboloidGraph_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hyperbolicParaboloidGraph_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl hyperbolicParaboloidGraph;
    }
}