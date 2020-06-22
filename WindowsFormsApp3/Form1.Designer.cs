namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.elypsoidButton = new System.Windows.Forms.Button();
            this.elypticParaboloidButton = new System.Windows.Forms.Button();
            this.hyperbolicParaboloidButton = new System.Windows.Forms.Button();
            this.hyperboloid1Button = new System.Windows.Forms.Button();
            this.hyperboloid2Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elypsoidButton
            // 
            this.elypsoidButton.Location = new System.Drawing.Point(15, 57);
            this.elypsoidButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elypsoidButton.Name = "elypsoidButton";
            this.elypsoidButton.Size = new System.Drawing.Size(239, 44);
            this.elypsoidButton.TabIndex = 0;
            this.elypsoidButton.Text = "Еліпсоїд";
            this.elypsoidButton.UseVisualStyleBackColor = true;
            this.elypsoidButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // elypticParaboloidButton
            // 
            this.elypticParaboloidButton.Location = new System.Drawing.Point(15, 106);
            this.elypticParaboloidButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elypticParaboloidButton.Name = "elypticParaboloidButton";
            this.elypticParaboloidButton.Size = new System.Drawing.Size(239, 44);
            this.elypticParaboloidButton.TabIndex = 1;
            this.elypticParaboloidButton.Text = "Еліптичний параболоїд";
            this.elypticParaboloidButton.UseVisualStyleBackColor = true;
            this.elypticParaboloidButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // hyperbolicParaboloidButton
            // 
            this.hyperbolicParaboloidButton.Location = new System.Drawing.Point(15, 156);
            this.hyperbolicParaboloidButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hyperbolicParaboloidButton.Name = "hyperbolicParaboloidButton";
            this.hyperbolicParaboloidButton.Size = new System.Drawing.Size(239, 44);
            this.hyperbolicParaboloidButton.TabIndex = 2;
            this.hyperbolicParaboloidButton.Text = "Гіперболічний параболоїд";
            this.hyperbolicParaboloidButton.UseVisualStyleBackColor = true;
            this.hyperbolicParaboloidButton.Click += new System.EventHandler(this.hyperbolicParaboloidButton_Click);
            // 
            // hyperboloid1Button
            // 
            this.hyperboloid1Button.Location = new System.Drawing.Point(15, 207);
            this.hyperboloid1Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hyperboloid1Button.Name = "hyperboloid1Button";
            this.hyperboloid1Button.Size = new System.Drawing.Size(239, 44);
            this.hyperboloid1Button.TabIndex = 3;
            this.hyperboloid1Button.Text = "Гіперболоїд однолистовий";
            this.hyperboloid1Button.UseVisualStyleBackColor = true;
            this.hyperboloid1Button.Click += new System.EventHandler(this.hyperboloid1Button_Click);
            // 
            // hyperboloid2Button
            // 
            this.hyperboloid2Button.Location = new System.Drawing.Point(15, 256);
            this.hyperboloid2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hyperboloid2Button.Name = "hyperboloid2Button";
            this.hyperboloid2Button.Size = new System.Drawing.Size(239, 44);
            this.hyperboloid2Button.TabIndex = 4;
            this.hyperboloid2Button.Text = "Гіперболоїд дволистовий";
            this.hyperboloid2Button.UseVisualStyleBackColor = true;
            this.hyperboloid2Button.Click += new System.EventHandler(this.hyperboloid2Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 52);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть графік";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hyperboloid2Button);
            this.Controls.Add(this.hyperboloid1Button);
            this.Controls.Add(this.hyperbolicParaboloidButton);
            this.Controls.Add(this.elypticParaboloidButton);
            this.Controls.Add(this.elypsoidButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Поверхні другого порядку";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button elypsoidButton;
        private System.Windows.Forms.Button elypticParaboloidButton;
        private System.Windows.Forms.Button hyperbolicParaboloidButton;
        private System.Windows.Forms.Button hyperboloid1Button;
        private System.Windows.Forms.Button hyperboloid2Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

