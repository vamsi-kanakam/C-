namespace Ch8_FilesAndArrays
{
    partial class ReadBinaryFile
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
            this.btnComputePercent = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnComputePercent
            // 
            this.btnComputePercent.BackColor = System.Drawing.Color.Silver;
            this.btnComputePercent.Location = new System.Drawing.Point(22, 13);
            this.btnComputePercent.Name = "btnComputePercent";
            this.btnComputePercent.Size = new System.Drawing.Size(104, 32);
            this.btnComputePercent.TabIndex = 11;
            this.btnComputePercent.Text = "Compute Percent";
            this.btnComputePercent.UseVisualStyleBackColor = false;
            this.btnComputePercent.Click += new System.EventHandler(this.btnComputePercent_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(22, 51);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(335, 88);
            this.lstDisplay.TabIndex = 10;
            // 
            // ReadBinaryFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 151);
            this.Controls.Add(this.btnComputePercent);
            this.Controls.Add(this.lstDisplay);
            this.Name = "ReadBinaryFile";
            this.Text = "ReadBinaryFile";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnComputePercent;
        internal System.Windows.Forms.ListBox lstDisplay;
    }
}