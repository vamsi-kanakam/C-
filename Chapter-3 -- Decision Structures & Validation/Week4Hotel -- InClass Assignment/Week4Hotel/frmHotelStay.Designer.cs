namespace Week4Hotel
{
    partial class frmHotelStay
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTIme = new System.Windows.Forms.DateTimePicker();
            this.txtNoOfGuests = new System.Windows.Forms.TextBox();
            this.rdBussiness = new System.Windows.Forms.RadioButton();
            this.rdSenior = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.cbParking = new System.Windows.Forms.CheckBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.grpCheckbox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCheckbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "# of guests:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parking:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(254, 60);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 31);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.Value = new System.DateTime(2023, 9, 13, 0, 0, 0, 0);
            // 
            // dtpEndTIme
            // 
            this.dtpEndTIme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndTIme.Location = new System.Drawing.Point(254, 117);
            this.dtpEndTIme.Name = "dtpEndTIme";
            this.dtpEndTIme.Size = new System.Drawing.Size(200, 31);
            this.dtpEndTIme.TabIndex = 6;
            this.dtpEndTIme.Value = new System.DateTime(2023, 9, 13, 0, 0, 0, 0);
            // 
            // txtNoOfGuests
            // 
            this.txtNoOfGuests.Location = new System.Drawing.Point(254, 172);
            this.txtNoOfGuests.Name = "txtNoOfGuests";
            this.txtNoOfGuests.Size = new System.Drawing.Size(200, 31);
            this.txtNoOfGuests.TabIndex = 7;
            this.txtNoOfGuests.Validating += new System.ComponentModel.CancelEventHandler(this.txtNoOfGuests_Validating);
            // 
            // rdBussiness
            // 
            this.rdBussiness.AutoSize = true;
            this.rdBussiness.Location = new System.Drawing.Point(6, 17);
            this.rdBussiness.Name = "rdBussiness";
            this.rdBussiness.Size = new System.Drawing.Size(142, 29);
            this.rdBussiness.TabIndex = 8;
            this.rdBussiness.TabStop = true;
            this.rdBussiness.Text = "Bussiness";
            this.rdBussiness.UseVisualStyleBackColor = true;
            // 
            // rdSenior
            // 
            this.rdSenior.AutoSize = true;
            this.rdSenior.Location = new System.Drawing.Point(6, 52);
            this.rdSenior.Name = "rdSenior";
            this.rdSenior.Size = new System.Drawing.Size(177, 29);
            this.rdSenior.TabIndex = 9;
            this.rdSenior.TabStop = true;
            this.rdSenior.Text = "Senior Citizen";
            this.rdSenior.UseVisualStyleBackColor = true;
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(6, 87);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(117, 29);
            this.rdStudent.TabIndex = 10;
            this.rdStudent.TabStop = true;
            this.rdStudent.Text = "Student";
            this.rdStudent.UseVisualStyleBackColor = true;
            // 
            // cbParking
            // 
            this.cbParking.AutoSize = true;
            this.cbParking.Location = new System.Drawing.Point(259, 420);
            this.cbParking.Name = "cbParking";
            this.cbParking.Size = new System.Drawing.Size(82, 29);
            this.cbParking.TabIndex = 11;
            this.cbParking.Text = "Yes";
            this.cbParking.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.AutoSize = true;
            this.btnCompute.Location = new System.Drawing.Point(105, 495);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(162, 35);
            this.btnCompute.TabIndex = 12;
            this.btnCompute.Text = "Compute Cost";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(526, 67);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(672, 354);
            this.lstOutput.TabIndex = 13;
            // 
            // grpCheckbox
            // 
            this.grpCheckbox.Controls.Add(this.rdBussiness);
            this.grpCheckbox.Controls.Add(this.rdSenior);
            this.grpCheckbox.Controls.Add(this.rdStudent);
            this.grpCheckbox.Location = new System.Drawing.Point(254, 223);
            this.grpCheckbox.Name = "grpCheckbox";
            this.grpCheckbox.Size = new System.Drawing.Size(200, 142);
            this.grpCheckbox.TabIndex = 14;
            this.grpCheckbox.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(323, 495);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(526, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 35);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHotelStay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 580);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpCheckbox);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.cbParking);
            this.Controls.Add(this.txtNoOfGuests);
            this.Controls.Add(this.dtpEndTIme);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHotelStay";
            this.Text = "Hotel Stay";
            this.grpCheckbox.ResumeLayout(false);
            this.grpCheckbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndTIme;
        private System.Windows.Forms.TextBox txtNoOfGuests;
        private System.Windows.Forms.RadioButton rdBussiness;
        private System.Windows.Forms.RadioButton rdSenior;
        private System.Windows.Forms.RadioButton rdStudent;
        private System.Windows.Forms.CheckBox cbParking;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.GroupBox grpCheckbox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

