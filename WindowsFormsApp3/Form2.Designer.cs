namespace WindowsFormsApp3
{
    partial class Form2
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
            this.elipsoidGraph = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // elipsoidGraph
            // 
            this.elipsoidGraph.AccumBits = ((byte)(0));
            this.elipsoidGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elipsoidGraph.AutoCheckErrors = false;
            this.elipsoidGraph.AutoFinish = false;
            this.elipsoidGraph.AutoMakeCurrent = true;
            this.elipsoidGraph.AutoSwapBuffers = true;
            this.elipsoidGraph.BackColor = System.Drawing.Color.Black;
            this.elipsoidGraph.ColorBits = ((byte)(32));
            this.elipsoidGraph.DepthBits = ((byte)(16));
            this.elipsoidGraph.Location = new System.Drawing.Point(12, 12);
            this.elipsoidGraph.Name = "elipsoidGraph";
            this.elipsoidGraph.Size = new System.Drawing.Size(451, 426);
            this.elipsoidGraph.StencilBits = ((byte)(0));
            this.elipsoidGraph.TabIndex = 15;
            this.elipsoidGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.elipsoidGraph_Paint);
            this.elipsoidGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.elipsoidGraph_MouseDown);
            this.elipsoidGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.elipsoidGraph_MouseMove);
            this.elipsoidGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.elipsoidGraph_MouseUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.elipsoidGraph);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl elipsoidGraph;
    }
}