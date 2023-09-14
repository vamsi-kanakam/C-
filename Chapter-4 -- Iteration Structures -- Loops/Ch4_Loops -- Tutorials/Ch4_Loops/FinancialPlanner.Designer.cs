namespace Ch4_Loops
{
    partial class FinancialPlanner
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvestment = new System.Windows.Forms.TextBox();
            this.txtGrowth = new System.Windows.Forms.TextBox();
            this.txtTargetAmt = new System.Windows.Forms.TextBox();
            this.btnHowLong = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yearly Invesment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yearly Growth (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Target Amount:";
            // 
            // txtInvestment
            // 
            this.txtInvestment.Location = new System.Drawing.Point(289, 62);
            this.txtInvestment.Name = "txtInvestment";
            this.txtInvestment.Size = new System.Drawing.Size(100, 31);
            this.txtInvestment.TabIndex = 3;
            // 
            // txtGrowth
            // 
            this.txtGrowth.Location = new System.Drawing.Point(289, 117);
            this.txtGrowth.Name = "txtGrowth";
            this.txtGrowth.Size = new System.Drawing.Size(100, 31);
            this.txtGrowth.TabIndex = 4;
            // 
            // txtTargetAmt
            // 
            this.txtTargetAmt.Location = new System.Drawing.Point(289, 186);
            this.txtTargetAmt.Name = "txtTargetAmt";
            this.txtTargetAmt.Size = new System.Drawing.Size(100, 31);
            this.txtTargetAmt.TabIndex = 5;
            // 
            // btnHowLong
            // 
            this.btnHowLong.AutoSize = true;
            this.btnHowLong.Location = new System.Drawing.Point(223, 286);
            this.btnHowLong.Name = "btnHowLong";
            this.btnHowLong.Size = new System.Drawing.Size(166, 35);
            this.btnHowLong.TabIndex = 6;
            this.btnHowLong.Text = "   How Long?   ";
            this.btnHowLong.UseVisualStyleBackColor = true;
            this.btnHowLong.Click += new System.EventHandler(this.btnHowLong_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(550, 62);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(587, 704);
            this.lstOutput.TabIndex = 7;
            // 
            // FinancialPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 861);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnHowLong);
            this.Controls.Add(this.txtTargetAmt);
            this.Controls.Add(this.txtGrowth);
            this.Controls.Add(this.txtInvestment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FinancialPlanner";
            this.Text = "FinancialPlanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvestment;
        private System.Windows.Forms.TextBox txtGrowth;
        private System.Windows.Forms.TextBox txtTargetAmt;
        private System.Windows.Forms.Button btnHowLong;
        private System.Windows.Forms.ListBox lstOutput;
    }
}