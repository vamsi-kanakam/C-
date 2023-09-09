namespace Exercises_Ch1
{
    partial class totalCost2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnComputeCost = new System.Windows.Forms.Button();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblLabor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(599, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 35);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(481, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 35);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnComputeCost
            // 
            this.btnComputeCost.AutoSize = true;
            this.btnComputeCost.Location = new System.Drawing.Point(211, 350);
            this.btnComputeCost.Name = "btnComputeCost";
            this.btnComputeCost.Size = new System.Drawing.Size(158, 35);
            this.btnComputeCost.TabIndex = 25;
            this.btnComputeCost.Text = "Compute Cost";
            this.btnComputeCost.UseVisualStyleBackColor = true;
            this.btnComputeCost.Click += new System.EventHandler(this.btnComputeCost_Click);
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(211, 210);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(100, 31);
            this.txtMaterial.TabIndex = 18;
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(211, 128);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(100, 31);
            this.txtLabor.TabIndex = 17;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(78, 216);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(95, 25);
            this.lblMaterial.TabIndex = 16;
            this.lblMaterial.Text = "Material:";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(78, 128);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(73, 25);
            this.lblLabor.TabIndex = 15;
            this.lblLabor.Text = "Labor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cost of:";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(456, 112);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(270, 79);
            this.lstOutput.TabIndex = 28;
            // 
            // totalCost2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnComputeCost);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtLabor);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblLabor);
            this.Controls.Add(this.label1);
            this.Name = "totalCost2";
            this.Text = "Total_Cost2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnComputeCost;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOutput;
    }
}