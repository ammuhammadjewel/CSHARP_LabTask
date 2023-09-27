namespace Student_Login
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
            this.labelFname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFname.Location = new System.Drawing.Point(62, 88);
            this.labelFname.MaximumSize = new System.Drawing.Size(60, 30);
            this.labelFname.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(100, 30);
            this.labelFname.TabIndex = 1;
            this.labelFname.Tag = "";
            this.labelFname.Text = "FName:";
            this.labelFname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLname.Location = new System.Drawing.Point(62, 145);
            this.labelLname.MaximumSize = new System.Drawing.Size(60, 30);
            this.labelLname.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(100, 30);
            this.labelLname.TabIndex = 2;
            this.labelLname.Tag = "";
            this.labelLname.Text = "LName:";
            this.labelLname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelID.Location = new System.Drawing.Point(62, 205);
            this.labelID.MaximumSize = new System.Drawing.Size(60, 30);
            this.labelID.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(100, 30);
            this.labelID.TabIndex = 3;
            this.labelID.Tag = "";
            this.labelID.Text = "ID:";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPass.Location = new System.Drawing.Point(62, 263);
            this.labelPass.MaximumSize = new System.Drawing.Size(60, 30);
            this.labelPass.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(100, 30);
            this.labelPass.TabIndex = 4;
            this.labelPass.Tag = "";
            this.labelPass.Text = "Password: ";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonLogin.Location = new System.Drawing.Point(146, 339);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 55);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonExit.Location = new System.Drawing.Point(310, 339);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 55);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(234, 88);
            this.textBoxFname.Multiline = true;
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(223, 30);
            this.textBoxFname.TabIndex = 7;
            this.textBoxFname.TextChanged += new System.EventHandler(this.textBoxFname_TextChanged);
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(234, 145);
            this.textBoxLname.Multiline = true;
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(223, 30);
            this.textBoxLname.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(234, 209);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(223, 30);
            this.textBoxId.TabIndex = 9;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(234, 267);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(223, 30);
            this.textBoxPass.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}

