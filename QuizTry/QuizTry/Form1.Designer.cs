namespace QuizTry
{
    partial class Form1
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
            this.Go1 = new System.Windows.Forms.Button();
            this.Exit1 = new System.Windows.Forms.Button();
            this.Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Go1
            // 
            this.Go1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go1.Location = new System.Drawing.Point(405, 559);
            this.Go1.Name = "Go1";
            this.Go1.Size = new System.Drawing.Size(115, 46);
            this.Go1.TabIndex = 1;
            this.Go1.Text = "Form2";
            this.Go1.UseVisualStyleBackColor = true;
            this.Go1.Click += new System.EventHandler(this.Go1_Click);
            // 
            // Exit1
            // 
            this.Exit1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit1.Location = new System.Drawing.Point(625, 559);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(115, 46);
            this.Exit1.TabIndex = 2;
            this.Exit1.Text = "Exit";
            this.Exit1.UseVisualStyleBackColor = true;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // Go
            // 
            this.Go.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(204, 559);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(115, 46);
            this.Go.TabIndex = 3;
            this.Go.Text = "Form3";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(908, 674);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Exit1);
            this.Controls.Add(this.Go1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Go1;
        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.Button Go;
    }
}

