namespace Ch5_Methods
{
    partial class HeartRateTopDownAlt
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
            this.btnTrainingRate = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtRestingRate = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblRestingRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(444, 187);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(511, 104);
            this.lstOutput.TabIndex = 12;
            // 
            // btnTrainingRate
            // 
            this.btnTrainingRate.Location = new System.Drawing.Point(108, 189);
            this.btnTrainingRate.Name = "btnTrainingRate";
            this.btnTrainingRate.Size = new System.Drawing.Size(160, 102);
            this.btnTrainingRate.TabIndex = 11;
            this.btnTrainingRate.Text = "Compute Training Rate";
            this.btnTrainingRate.UseVisualStyleBackColor = true;
            this.btnTrainingRate.Click += new System.EventHandler(this.btnTrainingRate_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(253, 101);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 31);
            this.txtAge.TabIndex = 10;
            // 
            // txtRestingRate
            // 
            this.txtRestingRate.Location = new System.Drawing.Point(253, 38);
            this.txtRestingRate.Name = "txtRestingRate";
            this.txtRestingRate.Size = new System.Drawing.Size(100, 31);
            this.txtRestingRate.TabIndex = 9;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(17, 101);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(56, 25);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age:";
            // 
            // lblRestingRate
            // 
            this.lblRestingRate.AutoSize = true;
            this.lblRestingRate.Location = new System.Drawing.Point(12, 45);
            this.lblRestingRate.Name = "lblRestingRate";
            this.lblRestingRate.Size = new System.Drawing.Size(200, 25);
            this.lblRestingRate.TabIndex = 7;
            this.lblRestingRate.Text = "Resting Heart Rate:";
            // 
            // HeartRateTopDownAlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 350);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnTrainingRate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtRestingRate);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblRestingRate);
            this.Name = "HeartRateTopDownAlt";
            this.Text = "HeartRateTopDownAlt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnTrainingRate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtRestingRate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblRestingRate;
    }
}