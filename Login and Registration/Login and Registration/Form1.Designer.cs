namespace Login_and_Registration
{
    partial class Form
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
            this.button1Exit = new System.Windows.Forms.Button();
            this.button2Registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1Exit
            // 
            this.button1Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Exit.Location = new System.Drawing.Point(551, 366);
            this.button1Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button1Exit.Name = "button1Exit";
            this.button1Exit.Size = new System.Drawing.Size(117, 37);
            this.button1Exit.TabIndex = 0;
            this.button1Exit.Text = "Exit";
            this.button1Exit.UseVisualStyleBackColor = true;
            this.button1Exit.Click += new System.EventHandler(this.button1Exit_Click);
            // 
            // button2Registration
            // 
            this.button2Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Registration.Location = new System.Drawing.Point(139, 366);
            this.button2Registration.Margin = new System.Windows.Forms.Padding(2);
            this.button2Registration.Name = "button2Registration";
            this.button2Registration.Size = new System.Drawing.Size(173, 37);
            this.button2Registration.TabIndex = 1;
            this.button2Registration.Text = "Registration";
            this.button2Registration.UseVisualStyleBackColor = true;
            this.button2Registration.Click += new System.EventHandler(this.button2Registration_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2Registration);
            this.Controls.Add(this.button1Exit);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1Exit;
        private System.Windows.Forms.Button button2Registration;
    }
}

