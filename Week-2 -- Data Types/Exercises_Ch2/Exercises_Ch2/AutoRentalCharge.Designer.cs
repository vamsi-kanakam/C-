namespace Exercises_Ch2
{
    partial class AutoRentalCharge
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
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.txtChargePerDay = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTimeRented = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeReturned = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Rented:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Returned:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Charge Per Day:";
            // 
            // dtpDateRented
            // 
            this.dtpDateRented.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateRented.Location = new System.Drawing.Point(448, 39);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(200, 31);
            this.dtpDateRented.TabIndex = 3;
            this.dtpDateRented.Value = new System.DateTime(2023, 9, 4, 0, 0, 0, 0);
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateReturned.Location = new System.Drawing.Point(448, 129);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(200, 31);
            this.dtpDateReturned.TabIndex = 4;
            this.dtpDateReturned.Value = new System.DateTime(2023, 9, 4, 0, 0, 0, 0);
            // 
            // txtChargePerDay
            // 
            this.txtChargePerDay.Location = new System.Drawing.Point(448, 212);
            this.txtChargePerDay.Name = "txtChargePerDay";
            this.txtChargePerDay.Size = new System.Drawing.Size(100, 31);
            this.txtChargePerDay.TabIndex = 5;
            // 
            // btnCompute
            // 
            this.btnCompute.AutoSize = true;
            this.btnCompute.Location = new System.Drawing.Point(319, 259);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(158, 35);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute Cost";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(66, 316);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(686, 279);
            this.lstOutput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Rented:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time Returned:";
            // 
            // dtpTimeRented
            // 
            this.dtpTimeRented.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpTimeRented.CustomFormat = "hh:mm:tt";
            this.dtpTimeRented.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeRented.Location = new System.Drawing.Point(448, 88);
            this.dtpTimeRented.Name = "dtpTimeRented";
            this.dtpTimeRented.ShowUpDown = true;
            this.dtpTimeRented.Size = new System.Drawing.Size(200, 31);
            this.dtpTimeRented.TabIndex = 10;
            // 
            // dtpTimeReturned
            // 
            this.dtpTimeReturned.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpTimeReturned.CustomFormat = "hh:mm:tt";
            this.dtpTimeReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeReturned.Location = new System.Drawing.Point(448, 168);
            this.dtpTimeReturned.Name = "dtpTimeReturned";
            this.dtpTimeReturned.ShowUpDown = true;
            this.dtpTimeReturned.Size = new System.Drawing.Size(200, 31);
            this.dtpTimeReturned.TabIndex = 11;
            // 
            // AutoRentalCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.dtpTimeReturned);
            this.Controls.Add(this.dtpTimeRented);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtChargePerDay);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.dtpDateRented);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AutoRentalCharge";
            this.Text = "Ace Auto Rentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateRented;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.TextBox txtChargePerDay;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTimeRented;
        private System.Windows.Forms.DateTimePicker dtpTimeReturned;
    }
}