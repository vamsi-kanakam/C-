namespace Ch8_FilesAndArrays
{
    partial class SmallFiles
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
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.cboVendorNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(217, 18);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(226, 43);
            this.lstDisplay.TabIndex = 3;
            // 
            // cboVendorNames
            // 
            this.cboVendorNames.FormattingEnabled = true;
            this.cboVendorNames.Location = new System.Drawing.Point(22, 18);
            this.cboVendorNames.Name = "cboVendorNames";
            this.cboVendorNames.Size = new System.Drawing.Size(189, 21);
            this.cboVendorNames.TabIndex = 2;
            this.cboVendorNames.Text = "Select Vendor";
            this.cboVendorNames.SelectedIndexChanged += new System.EventHandler(this.cboVendorNames_SelectedIndexChanged);
            // 
            // SmallFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 75);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.cboVendorNames);
            this.Name = "SmallFiles";
            this.Text = "SmallFiles";
            this.Load += new System.EventHandler(this.SmallFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ComboBox cboVendorNames;
    }
}