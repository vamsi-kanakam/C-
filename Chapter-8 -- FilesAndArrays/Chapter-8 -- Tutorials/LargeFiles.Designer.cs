namespace Ch8_FilesAndArrays
{
    partial class LargeFiles
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
            this.Label1 = new System.Windows.Forms.Label();
            this.btnFindPhone = new System.Windows.Forms.Button();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(18, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 24);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Name:";
            // 
            // btnFindPhone
            // 
            this.btnFindPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPhone.Location = new System.Drawing.Point(21, 43);
            this.btnFindPhone.Name = "btnFindPhone";
            this.btnFindPhone.Size = new System.Drawing.Size(141, 32);
            this.btnFindPhone.TabIndex = 21;
            this.btnFindPhone.Text = "Find Phone#";
            this.btnFindPhone.Click += new System.EventHandler(this.btnFindPhone_Click);
            // 
            // txtVendorName
            // 
            this.txtVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorName.Location = new System.Drawing.Point(75, 17);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(87, 22);
            this.txtVendorName.TabIndex = 20;
            this.txtVendorName.Text = "Philip";
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(185, 43);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(216, 46);
            this.lstDisplay.TabIndex = 19;
            // 
            // LargeFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 102);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnFindPhone);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.lstDisplay);
            this.Name = "LargeFiles";
            this.Text = "LargeFiles";
            this.Load += new System.EventHandler(this.LargeFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnFindPhone;
        internal System.Windows.Forms.TextBox txtVendorName;
        internal System.Windows.Forms.ListBox lstDisplay;
    }
}