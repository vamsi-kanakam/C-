namespace Ch2_DataTypes
{
    partial class IceCreamTotalWithDiscount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScoops = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnComputeTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "# of Scoops:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit Price:";
            // 
            // txtScoops
            // 
            this.txtScoops.Location = new System.Drawing.Point(167, 98);
            this.txtScoops.Name = "txtScoops";
            this.txtScoops.Size = new System.Drawing.Size(100, 31);
            this.txtScoops.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(167, 205);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 31);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(420, 98);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(380, 254);
            this.lstOutput.TabIndex = 4;
            // 
            // btnComputeTotal
            // 
            this.btnComputeTotal.Location = new System.Drawing.Point(86, 423);
            this.btnComputeTotal.Name = "btnComputeTotal";
            this.btnComputeTotal.Size = new System.Drawing.Size(183, 43);
            this.btnComputeTotal.TabIndex = 5;
            this.btnComputeTotal.Text = "Compute Total";
            this.btnComputeTotal.UseVisualStyleBackColor = true;
            this.btnComputeTotal.Click += new System.EventHandler(this.btnComputeTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(621, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 43);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(434, 423);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 43);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // IceCreamTotalDataTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 577);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnComputeTotal);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtScoops);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IceCreamTotalDataTypes";
            this.Text = "Ice Cream Total Data Types";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScoops;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnComputeTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

