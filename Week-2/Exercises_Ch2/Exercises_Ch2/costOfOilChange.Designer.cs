namespace Exercises_Ch2
{
    partial class costOfOilChange
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
            this.lblLaborCharge = new System.Windows.Forms.Label();
            this.lblQuartsUsed = new System.Windows.Forms.Label();
            this.lblCostPerQuart = new System.Windows.Forms.Label();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.txtLaborCharge = new System.Windows.Forms.TextBox();
            this.txtQuartsUsed = new System.Windows.Forms.TextBox();
            this.txtCostPerQuart = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.btnComputeCost = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblLaborCharge
            // 
            this.lblLaborCharge.AutoSize = true;
            this.lblLaborCharge.Location = new System.Drawing.Point(35, 60);
            this.lblLaborCharge.Name = "lblLaborCharge";
            this.lblLaborCharge.Size = new System.Drawing.Size(149, 25);
            this.lblLaborCharge.TabIndex = 0;
            this.lblLaborCharge.Text = "Labor Charge:";
            // 
            // lblQuartsUsed
            // 
            this.lblQuartsUsed.AutoSize = true;
            this.lblQuartsUsed.Location = new System.Drawing.Point(35, 114);
            this.lblQuartsUsed.Name = "lblQuartsUsed";
            this.lblQuartsUsed.Size = new System.Drawing.Size(138, 25);
            this.lblQuartsUsed.TabIndex = 1;
            this.lblQuartsUsed.Text = "Quarts Used:";
            // 
            // lblCostPerQuart
            // 
            this.lblCostPerQuart.AutoSize = true;
            this.lblCostPerQuart.Location = new System.Drawing.Point(35, 180);
            this.lblCostPerQuart.Name = "lblCostPerQuart";
            this.lblCostPerQuart.Size = new System.Drawing.Size(158, 25);
            this.lblCostPerQuart.TabIndex = 2;
            this.lblCostPerQuart.Text = "Cost per Quart:";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(35, 242);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(165, 25);
            this.lblTaxRate.TabIndex = 3;
            this.lblTaxRate.Text = "Sales Tax Rate:";
            // 
            // txtLaborCharge
            // 
            this.txtLaborCharge.Location = new System.Drawing.Point(264, 60);
            this.txtLaborCharge.Name = "txtLaborCharge";
            this.txtLaborCharge.Size = new System.Drawing.Size(100, 31);
            this.txtLaborCharge.TabIndex = 4;
            // 
            // txtQuartsUsed
            // 
            this.txtQuartsUsed.Location = new System.Drawing.Point(264, 114);
            this.txtQuartsUsed.Name = "txtQuartsUsed";
            this.txtQuartsUsed.Size = new System.Drawing.Size(100, 31);
            this.txtQuartsUsed.TabIndex = 5;
            // 
            // txtCostPerQuart
            // 
            this.txtCostPerQuart.Location = new System.Drawing.Point(264, 180);
            this.txtCostPerQuart.Name = "txtCostPerQuart";
            this.txtCostPerQuart.Size = new System.Drawing.Size(100, 31);
            this.txtCostPerQuart.TabIndex = 6;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(264, 242);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 31);
            this.txtTaxRate.TabIndex = 7;
            // 
            // btnComputeCost
            // 
            this.btnComputeCost.AutoSize = true;
            this.btnComputeCost.Location = new System.Drawing.Point(97, 323);
            this.btnComputeCost.Name = "btnComputeCost";
            this.btnComputeCost.Size = new System.Drawing.Size(158, 35);
            this.btnComputeCost.TabIndex = 8;
            this.btnComputeCost.Text = "Compute Cost";
            this.btnComputeCost.UseVisualStyleBackColor = true;
            this.btnComputeCost.Click += new System.EventHandler(this.btnComputeCost_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(454, 63);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(320, 204);
            this.lstOutput.TabIndex = 9;
            // 
            // costOfOilChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnComputeCost);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.txtCostPerQuart);
            this.Controls.Add(this.txtQuartsUsed);
            this.Controls.Add(this.txtLaborCharge);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.lblCostPerQuart);
            this.Controls.Add(this.lblQuartsUsed);
            this.Controls.Add(this.lblLaborCharge);
            this.Name = "costOfOilChange";
            this.Text = "Cost of Oil Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLaborCharge;
        private System.Windows.Forms.Label lblQuartsUsed;
        private System.Windows.Forms.Label lblCostPerQuart;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.TextBox txtLaborCharge;
        private System.Windows.Forms.TextBox txtQuartsUsed;
        private System.Windows.Forms.TextBox txtCostPerQuart;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Button btnComputeCost;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

