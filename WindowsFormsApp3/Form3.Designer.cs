namespace WindowsFormsApp3
{
    partial class Form3
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
            this.elipticParaboloidGraph = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // elipticParaboloidGraph
            // 
            this.elipticParaboloidGraph.AccumBits = ((byte)(0));
            this.elipticParaboloidGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elipticParaboloidGraph.AutoCheckErrors = false;
            this.elipticParaboloidGraph.AutoFinish = false;
            this.elipticParaboloidGraph.AutoMakeCurrent = true;
            this.elipticParaboloidGraph.AutoSwapBuffers = true;
            this.elipticParaboloidGraph.BackColor = System.Drawing.Color.Black;
            this.elipticParaboloidGraph.ColorBits = ((byte)(32));
            this.elipticParaboloidGraph.DepthBits = ((byte)(16));
            this.elipticParaboloidGraph.Location = new System.Drawing.Point(12, 12);
            this.elipticParaboloidGraph.Name = "elipticParaboloidGraph";
            this.elipticParaboloidGraph.Size = new System.Drawing.Size(451, 426);
            this.elipticParaboloidGraph.StencilBits = ((byte)(0));
            this.elipticParaboloidGraph.TabIndex = 16;
            this.elipticParaboloidGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.elipticParaboloidGraph_Paint);
            this.elipticParaboloidGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.elipticParaboloidGraph_MouseDown);
            this.elipticParaboloidGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.elipticParaboloidGraph_MouseMove);
            this.elipticParaboloidGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.elipticParaboloidGraph_MouseUp);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.elipticParaboloidGraph);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl elipticParaboloidGraph;
    }
}