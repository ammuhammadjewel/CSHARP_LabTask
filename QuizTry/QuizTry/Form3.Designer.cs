namespace QuizTry
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
            this.Back3 = new System.Windows.Forms.Button();
            this.Exit3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back3
            // 
            this.Back3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back3.Location = new System.Drawing.Point(238, 525);
            this.Back3.Name = "Back3";
            this.Back3.Size = new System.Drawing.Size(115, 46);
            this.Back3.TabIndex = 1;
            this.Back3.Text = "Back";
            this.Back3.UseVisualStyleBackColor = true;
            this.Back3.Click += new System.EventHandler(this.Back3_Click);
            // 
            // Exit3
            // 
            this.Exit3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit3.Location = new System.Drawing.Point(587, 525);
            this.Exit3.Name = "Exit3";
            this.Exit3.Size = new System.Drawing.Size(115, 46);
            this.Exit3.TabIndex = 2;
            this.Exit3.Text = "Exit";
            this.Exit3.UseVisualStyleBackColor = true;
            this.Exit3.Click += new System.EventHandler(this.Exit3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 680);
            this.Controls.Add(this.Exit3);
            this.Controls.Add(this.Back3);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back3;
        private System.Windows.Forms.Button Exit3;
    }
}