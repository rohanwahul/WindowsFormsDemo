namespace WindowsFormsDemo
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
            this.btnCreatFold = new System.Windows.Forms.Button();
            this.btnCreatFil = new System.Windows.Forms.Button();
            this.btnBinR = new System.Windows.Forms.Button();
            this.btnBinW = new System.Windows.Forms.Button();
            this.txtDeptID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreatFold
            // 
            this.btnCreatFold.Location = new System.Drawing.Point(296, 45);
            this.btnCreatFold.Name = "btnCreatFold";
            this.btnCreatFold.Size = new System.Drawing.Size(98, 42);
            this.btnCreatFold.TabIndex = 0;
            this.btnCreatFold.Text = "Create Folder";
            this.btnCreatFold.UseVisualStyleBackColor = true;
            this.btnCreatFold.Click += new System.EventHandler(this.BtnCreatFil_Click);
            // 
            // btnCreatFil
            // 
            this.btnCreatFil.Location = new System.Drawing.Point(434, 45);
            this.btnCreatFil.Name = "btnCreatFil";
            this.btnCreatFil.Size = new System.Drawing.Size(98, 42);
            this.btnCreatFil.TabIndex = 1;
            this.btnCreatFil.Text = "Create File";
            this.btnCreatFil.UseVisualStyleBackColor = true;
            this.btnCreatFil.Click += new System.EventHandler(this.BtnCreatFil_Click_1);
            // 
            // btnBinR
            // 
            this.btnBinR.Location = new System.Drawing.Point(434, 300);
            this.btnBinR.Name = "btnBinR";
            this.btnBinR.Size = new System.Drawing.Size(98, 44);
            this.btnBinR.TabIndex = 2;
            this.btnBinR.Text = "Binary Read";
            this.btnBinR.UseVisualStyleBackColor = true;
            this.btnBinR.Click += new System.EventHandler(this.BtnBinR_Click);
            // 
            // btnBinW
            // 
            this.btnBinW.Location = new System.Drawing.Point(296, 300);
            this.btnBinW.Name = "btnBinW";
            this.btnBinW.Size = new System.Drawing.Size(98, 44);
            this.btnBinW.TabIndex = 3;
            this.btnBinW.Text = "Binary Write";
            this.btnBinW.UseVisualStyleBackColor = true;
            this.btnBinW.Click += new System.EventHandler(this.BtnBinW_Click);
            // 
            // txtDeptID
            // 
            this.txtDeptID.Location = new System.Drawing.Point(384, 136);
            this.txtDeptID.Name = "txtDeptID";
            this.txtDeptID.Size = new System.Drawing.Size(148, 20);
            this.txtDeptID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(384, 189);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(384, 249);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(148, 20);
            this.txtLocation.TabIndex = 6;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(293, 139);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(44, 13);
            this.lblDeptID.TabIndex = 7;
            this.lblDeptID.Text = "Dept ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(293, 193);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(293, 249);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 9;
            this.lblLocation.Text = "Location";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDeptID);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDeptID);
            this.Controls.Add(this.btnBinW);
            this.Controls.Add(this.btnBinR);
            this.Controls.Add(this.btnCreatFil);
            this.Controls.Add(this.btnCreatFold);
            this.Name = "Form3";
            this.Text = "File IO Operation";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatFold;
        private System.Windows.Forms.Button btnCreatFil;
        private System.Windows.Forms.Button btnBinR;
        private System.Windows.Forms.Button btnBinW;
        private System.Windows.Forms.TextBox txtDeptID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
    }
}