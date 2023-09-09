namespace Ch2_DataTypes
{
    partial class GraduationDate
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
            this.lblGradDate = new System.Windows.Forms.Label();
            this.lblGradTime = new System.Windows.Forms.Label();
            this.dtpGradDate = new System.Windows.Forms.DateTimePicker();
            this.dtpGradTime = new System.Windows.Forms.DateTimePicker();
            this.btnGradInfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblGradDate
            // 
            this.lblGradDate.AutoSize = true;
            this.lblGradDate.Location = new System.Drawing.Point(36, 33);
            this.lblGradDate.Name = "lblGradDate";
            this.lblGradDate.Size = new System.Drawing.Size(175, 25);
            this.lblGradDate.TabIndex = 0;
            this.lblGradDate.Text = "Graduation Date:";
            // 
            // lblGradTime
            // 
            this.lblGradTime.AutoSize = true;
            this.lblGradTime.Location = new System.Drawing.Point(41, 87);
            this.lblGradTime.Name = "lblGradTime";
            this.lblGradTime.Size = new System.Drawing.Size(177, 25);
            this.lblGradTime.TabIndex = 1;
            this.lblGradTime.Text = "Graduation Time:";
            // 
            // dtpGradDate
            // 
            this.dtpGradDate.CustomFormat = "";
            this.dtpGradDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGradDate.Location = new System.Drawing.Point(270, 33);
            this.dtpGradDate.Name = "dtpGradDate";
            this.dtpGradDate.Size = new System.Drawing.Size(232, 31);
            this.dtpGradDate.TabIndex = 2;
            this.dtpGradDate.Value = new System.DateTime(2023, 9, 4, 0, 0, 0, 0);
            // 
            // dtpGradTime
            // 
            this.dtpGradTime.CustomFormat = "hh:mm tt";
            this.dtpGradTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGradTime.Location = new System.Drawing.Point(270, 87);
            this.dtpGradTime.Name = "dtpGradTime";
            this.dtpGradTime.ShowUpDown = true;
            this.dtpGradTime.Size = new System.Drawing.Size(136, 31);
            this.dtpGradTime.TabIndex = 3;
            this.dtpGradTime.Value = new System.DateTime(2023, 9, 4, 0, 34, 0, 0);
            // 
            // btnGradInfo
            // 
            this.btnGradInfo.AutoSize = true;
            this.btnGradInfo.Location = new System.Drawing.Point(237, 138);
            this.btnGradInfo.Name = "btnGradInfo";
            this.btnGradInfo.Size = new System.Drawing.Size(169, 35);
            this.btnGradInfo.TabIndex = 4;
            this.btnGradInfo.Text = "Graduation Info";
            this.btnGradInfo.UseVisualStyleBackColor = true;
            this.btnGradInfo.Click += new System.EventHandler(this.btnGradInfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(469, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 23;
            this.lstDisplay.Location = new System.Drawing.Point(31, 179);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(744, 395);
            this.lstDisplay.TabIndex = 6;
            // 
            // GraduationDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGradInfo);
            this.Controls.Add(this.dtpGradTime);
            this.Controls.Add(this.dtpGradDate);
            this.Controls.Add(this.lblGradTime);
            this.Controls.Add(this.lblGradDate);
            this.Name = "GraduationDate";
            this.Text = "GraduationDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradDate;
        private System.Windows.Forms.Label lblGradTime;
        private System.Windows.Forms.DateTimePicker dtpGradDate;
        private System.Windows.Forms.DateTimePicker dtpGradTime;
        private System.Windows.Forms.Button btnGradInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstDisplay;
    }
}