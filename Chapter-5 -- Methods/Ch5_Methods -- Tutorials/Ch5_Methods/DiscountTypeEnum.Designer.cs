namespace Ch5_Methods
{
    partial class DiscountTypeEnum
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
            this.cboDiscountType = new System.Windows.Forms.ComboBox();
            this.btnComputeRate = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboDiscountType
            // 
            this.cboDiscountType.FormattingEnabled = true;
            this.cboDiscountType.Location = new System.Drawing.Point(56, 109);
            this.cboDiscountType.Name = "cboDiscountType";
            this.cboDiscountType.Size = new System.Drawing.Size(175, 33);
            this.cboDiscountType.TabIndex = 0;
            this.cboDiscountType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnComputeRate
            // 
            this.btnComputeRate.AutoSize = true;
            this.btnComputeRate.Location = new System.Drawing.Point(311, 109);
            this.btnComputeRate.Name = "btnComputeRate";
            this.btnComputeRate.Size = new System.Drawing.Size(159, 35);
            this.btnComputeRate.TabIndex = 1;
            this.btnComputeRate.Text = "Compute Rate";
            this.btnComputeRate.UseVisualStyleBackColor = true;
            this.btnComputeRate.Click += new System.EventHandler(this.btnComputeRate_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(311, 164);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(384, 79);
            this.lstOutput.TabIndex = 2;
            // 
            // DiscountTypeEnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnComputeRate);
            this.Controls.Add(this.cboDiscountType);
            this.Name = "DiscountTypeEnum";
            this.Text = "DiscountTypeEnum";
            this.Load += new System.EventHandler(this.DiscountTypeEnum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDiscountType;
        private System.Windows.Forms.Button btnComputeRate;
        private System.Windows.Forms.ListBox lstOutput;
    }
}