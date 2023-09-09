namespace Ch2_DataTypes
{
    partial class UserNameString
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
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUserName = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(91, 89);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(122, 25);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(91, 161);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(121, 25);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(96, 229);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 25);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(338, 89);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 31);
            this.txtFname.TabIndex = 3;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(338, 161);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 31);
            this.txtLname.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(338, 229);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 31);
            this.txtID.TabIndex = 5;
            // 
            // btnUserName
            // 
            this.btnUserName.AutoSize = true;
            this.btnUserName.Location = new System.Drawing.Point(137, 320);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(224, 35);
            this.btnUserName.TabIndex = 6;
            this.btnUserName.Text = "Generate User Name";
            this.btnUserName.UseVisualStyleBackColor = true;
            this.btnUserName.Click += new System.EventHandler(this.btnUserName_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(557, 131);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(199, 25);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "Your User Name 👇";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserName.Location = new System.Drawing.Point(562, 199);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(194, 26);
            this.lblUserName.TabIndex = 8;
            // 
            // UserNameString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.btnUserName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Name = "UserNameString";
            this.Text = "UserNameString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUserName;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label lblUserName;
    }
}