namespace Ch3_DecisionsAndValidation_Tutorials
{
    partial class ComputeGrade
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
            this.txtTotalScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.Label();
            this.btnComputeGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Score:";
            // 
            // txtTotalScore
            // 
            this.txtTotalScore.Location = new System.Drawing.Point(203, 85);
            this.txtTotalScore.Name = "txtTotalScore";
            this.txtTotalScore.Size = new System.Drawing.Size(100, 31);
            this.txtTotalScore.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attendance:";
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(576, 85);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(100, 31);
            this.txtAttendance.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grade:";
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGrade.Location = new System.Drawing.Point(340, 311);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(85, 33);
            this.txtGrade.TabIndex = 5;
            // 
            // btnComputeGrade
            // 
            this.btnComputeGrade.Location = new System.Drawing.Point(317, 182);
            this.btnComputeGrade.Name = "btnComputeGrade";
            this.btnComputeGrade.Size = new System.Drawing.Size(126, 39);
            this.btnComputeGrade.TabIndex = 6;
            this.btnComputeGrade.Text = "Compute";
            this.btnComputeGrade.UseVisualStyleBackColor = true;
            this.btnComputeGrade.Click += new System.EventHandler(this.btnComputeGrade_Click);
            // 
            // ComputeGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComputeGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalScore);
            this.Controls.Add(this.label1);
            this.Name = "ComputeGrade";
            this.Text = "Compute Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtGrade;
        private System.Windows.Forms.Button btnComputeGrade;
    }
}

