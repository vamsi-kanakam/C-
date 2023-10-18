namespace Ch8_FilesAndArrays
{
    partial class ReadTextFile
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
            this.btnDisplayRecords = new System.Windows.Forms.Button();
            this.btnAboveAvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComputePercent
            // 
            this.btnComputePercent.BackColor = System.Drawing.SystemColors.Control;
            this.btnComputePercent.Location = new System.Drawing.Point(136, 15);
            this.btnComputePercent.Name = "btnComputePercent";
            this.btnComputePercent.Size = new System.Drawing.Size(104, 32);
            this.btnComputePercent.TabIndex = 7;
            this.btnComputePercent.Text = "Compute Percent";
            this.btnComputePercent.UseVisualStyleBackColor = false;
            this.btnComputePercent.Click += new System.EventHandler(this.btnComputPercent_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(24, 55);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(335, 88);
            this.lstDisplay.TabIndex = 6;
            // 
            // btnDisplayRecords
            // 
            this.btnDisplayRecords.BackColor = System.Drawing.SystemColors.Control;
            this.btnDisplayRecords.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDisplayRecords.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayRecords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisplayRecords.Location = new System.Drawing.Point(24, 15);
            this.btnDisplayRecords.Name = "btnDisplayRecords";
            this.btnDisplayRecords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDisplayRecords.Size = new System.Drawing.Size(104, 33);
            this.btnDisplayRecords.TabIndex = 5;
            this.btnDisplayRecords.Text = "Display Records";
            this.btnDisplayRecords.UseVisualStyleBackColor = false;
            this.btnDisplayRecords.Click += new System.EventHandler(this.btnDisplayRecords_Click);
            // 
            // btnAboveAvg
            // 
            this.btnAboveAvg.Location = new System.Drawing.Point(246, 17);
            this.btnAboveAvg.Name = "btnAboveAvg";
            this.btnAboveAvg.Size = new System.Drawing.Size(113, 29);
            this.btnAboveAvg.TabIndex = 8;
            this.btnAboveAvg.Text = "Display Above Avg";
            this.btnAboveAvg.UseVisualStyleBackColor = true;
            this.btnAboveAvg.Click += new System.EventHandler(this.btnAboveAvg_Click);
            // 
            // ReadTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 154);
            this.Controls.Add(this.btnAboveAvg);
            this.Controls.Add(this.btnComputePercent);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnDisplayRecords);
            this.Name = "ReadTextFile";
            this.Text = "Read Text File";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnComputePercent;
        internal System.Windows.Forms.ListBox lstDisplay;
        public System.Windows.Forms.Button btnDisplayRecords;
        private System.Windows.Forms.Button btnAboveAvg;
    }
}

