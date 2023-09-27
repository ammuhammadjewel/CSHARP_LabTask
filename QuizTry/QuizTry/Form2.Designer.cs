namespace QuizTry
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
            this.Go2 = new System.Windows.Forms.Button();
            this.Back2 = new System.Windows.Forms.Button();
            this.Exit2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Go2
            // 
            this.Go2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go2.Location = new System.Drawing.Point(188, 564);
            this.Go2.Name = "Go2";
            this.Go2.Size = new System.Drawing.Size(115, 46);
            this.Go2.TabIndex = 1;
            this.Go2.Text = "Form3";
            this.Go2.UseVisualStyleBackColor = true;
            this.Go2.Click += new System.EventHandler(this.Go2_Click);
            // 
            // Back2
            // 
            this.Back2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back2.Location = new System.Drawing.Point(360, 564);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(115, 46);
            this.Back2.TabIndex = 2;
            this.Back2.Text = "Form1";
            this.Back2.UseVisualStyleBackColor = true;
            this.Back2.Click += new System.EventHandler(this.Back2_Click);
            // 
            // Exit2
            // 
            this.Exit2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit2.Location = new System.Drawing.Point(543, 564);
            this.Exit2.Name = "Exit2";
            this.Exit2.Size = new System.Drawing.Size(115, 46);
            this.Exit2.TabIndex = 3;
            this.Exit2.Text = "Exit";
            this.Exit2.UseVisualStyleBackColor = true;
            this.Exit2.Click += new System.EventHandler(this.Exit2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 672);
            this.Controls.Add(this.Exit2);
            this.Controls.Add(this.Back2);
            this.Controls.Add(this.Go2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Go2;
        private System.Windows.Forms.Button Back2;
        private System.Windows.Forms.Button Exit2;
    }
}