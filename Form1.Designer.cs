namespace WindowsFormsDemo
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
            this.lblUsrNam = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsrNam = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsrNam
            // 
            this.lblUsrNam.AutoSize = true;
            this.lblUsrNam.Location = new System.Drawing.Point(270, 118);
            this.lblUsrNam.Name = "lblUsrNam";
            this.lblUsrNam.Size = new System.Drawing.Size(60, 13);
            this.lblUsrNam.TabIndex = 0;
            this.lblUsrNam.Text = "User Name";
            this.lblUsrNam.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(275, 220);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsrNam
            // 
            this.txtUsrNam.Location = new System.Drawing.Point(332, 115);
            this.txtUsrNam.Name = "txtUsrNam";
            this.txtUsrNam.Size = new System.Drawing.Size(146, 20);
            this.txtUsrNam.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(332, 217);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(146, 20);
            this.txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(332, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(413, 290);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(65, 23);
            this.btnClr.TabIndex = 5;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsrNam);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsrNam);
            this.Name = "Form1";
            this.Text = "WindowsFormDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsrNam;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsrNam;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClr;
    }
}

