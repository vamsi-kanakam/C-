namespace Ch4_Loops
{
    partial class FinPlannerForLoop
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnComputeInvestment = new System.Windows.Forms.Button();
            this.txtnoOfYears = new System.Windows.Forms.TextBox();
            this.txtGrowth = new System.Windows.Forms.TextBox();
            this.txtInvestment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(525, 54);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(587, 704);
            this.lstOutput.TabIndex = 15;
            // 
            // btnComputeInvestment
            // 
            this.btnComputeInvestment.AutoSize = true;
            this.btnComputeInvestment.Location = new System.Drawing.Point(99, 273);
            this.btnComputeInvestment.Name = "btnComputeInvestment";
            this.btnComputeInvestment.Size = new System.Drawing.Size(242, 35);
            this.btnComputeInvestment.TabIndex = 14;
            this.btnComputeInvestment.Text = "  Compute Investment  ";
            this.btnComputeInvestment.UseVisualStyleBackColor = true;
            this.btnComputeInvestment.Click += new System.EventHandler(this.btnComputeInvestment_Click);
            // 
            // txtnoOfYears
            // 
            this.txtnoOfYears.Location = new System.Drawing.Point(264, 178);
            this.txtnoOfYears.Name = "txtnoOfYears";
            this.txtnoOfYears.Size = new System.Drawing.Size(100, 31);
            this.txtnoOfYears.TabIndex = 13;
            // 
            // txtGrowth
            // 
            this.txtGrowth.Location = new System.Drawing.Point(264, 109);
            this.txtGrowth.Name = "txtGrowth";
            this.txtGrowth.Size = new System.Drawing.Size(100, 31);
            this.txtGrowth.TabIndex = 12;
            // 
            // txtInvestment
            // 
            this.txtInvestment.Location = new System.Drawing.Point(264, 54);
            this.txtInvestment.Name = "txtInvestment";
            this.txtInvestment.Size = new System.Drawing.Size(100, 31);
            this.txtInvestment.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "No.of Years:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yearly Growth (%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yearly Invesment:";
            // 
            // FinPlannerForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 905);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnComputeInvestment);
            this.Controls.Add(this.txtnoOfYears);
            this.Controls.Add(this.txtGrowth);
            this.Controls.Add(this.txtInvestment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FinPlannerForLoop";
            this.Text = "FinPlannerForLoop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnComputeInvestment;
        private System.Windows.Forms.TextBox txtnoOfYears;
        private System.Windows.Forms.TextBox txtGrowth;
        private System.Windows.Forms.TextBox txtInvestment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}