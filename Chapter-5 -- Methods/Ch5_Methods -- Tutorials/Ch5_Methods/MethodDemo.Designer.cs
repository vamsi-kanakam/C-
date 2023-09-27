namespace Ch5_Methods
{
    partial class MethodDemo
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblRestingRate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtRestingRate = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnTrainingRate = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSize = true;
            this.btnAbout.Location = new System.Drawing.Point(316, 64);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(78, 35);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblRestingRate
            // 
            this.lblRestingRate.AutoSize = true;
            this.lblRestingRate.Location = new System.Drawing.Point(104, 143);
            this.lblRestingRate.Name = "lblRestingRate";
            this.lblRestingRate.Size = new System.Drawing.Size(200, 25);
            this.lblRestingRate.TabIndex = 1;
            this.lblRestingRate.Text = "Resting Heart Rate:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(109, 199);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(56, 25);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // txtRestingRate
            // 
            this.txtRestingRate.Location = new System.Drawing.Point(345, 136);
            this.txtRestingRate.Name = "txtRestingRate";
            this.txtRestingRate.Size = new System.Drawing.Size(100, 31);
            this.txtRestingRate.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(345, 199);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 31);
            this.txtAge.TabIndex = 4;
            // 
            // btnTrainingRate
            // 
            this.btnTrainingRate.Location = new System.Drawing.Point(285, 295);
            this.btnTrainingRate.Name = "btnTrainingRate";
            this.btnTrainingRate.Size = new System.Drawing.Size(160, 102);
            this.btnTrainingRate.TabIndex = 5;
            this.btnTrainingRate.Text = "Compute Training Rate";
            this.btnTrainingRate.UseVisualStyleBackColor = true;
            this.btnTrainingRate.Click += new System.EventHandler(this.btnTrainingRate_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(546, 199);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(511, 104);
            this.lstOutput.TabIndex = 6;
            // 
            // MethodDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 450);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnTrainingRate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtRestingRate);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblRestingRate);
            this.Controls.Add(this.btnAbout);
            this.Name = "MethodDemo";
            this.Text = "MethodDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblRestingRate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtRestingRate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnTrainingRate;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

