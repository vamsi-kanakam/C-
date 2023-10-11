namespace JagSales
{
    partial class JagSales
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBasePay = new System.Windows.Forms.Label();
            this.lblStartinigDate = new System.Windows.Forms.Label();
            this.lblEndingDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBasePay = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnProcessPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndingDate = new System.Windows.Forms.DateTimePicker();
            this.erpBasePay = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpBasePay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // lblBasePay
            // 
            this.lblBasePay.AutoSize = true;
            this.lblBasePay.Location = new System.Drawing.Point(40, 215);
            this.lblBasePay.Name = "lblBasePay";
            this.lblBasePay.Size = new System.Drawing.Size(122, 25);
            this.lblBasePay.TabIndex = 1;
            this.lblBasePay.Text = " Base Pay :";
            // 
            // lblStartinigDate
            // 
            this.lblStartinigDate.AutoSize = true;
            this.lblStartinigDate.Location = new System.Drawing.Point(49, 299);
            this.lblStartinigDate.Name = "lblStartinigDate";
            this.lblStartinigDate.Size = new System.Drawing.Size(149, 25);
            this.lblStartinigDate.TabIndex = 2;
            this.lblStartinigDate.Text = "Starting Date :";
            // 
            // lblEndingDate
            // 
            this.lblEndingDate.AutoSize = true;
            this.lblEndingDate.Location = new System.Drawing.Point(49, 385);
            this.lblEndingDate.Name = "lblEndingDate";
            this.lblEndingDate.Size = new System.Drawing.Size(142, 25);
            this.lblEndingDate.TabIndex = 3;
            this.lblEndingDate.Text = "Ending Date :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 31);
            this.txtName.TabIndex = 4;
            // 
            // txtBasePay
            // 
            this.txtBasePay.Location = new System.Drawing.Point(218, 209);
            this.txtBasePay.Name = "txtBasePay";
            this.txtBasePay.Size = new System.Drawing.Size(176, 31);
            this.txtBasePay.TabIndex = 5;
            this.txtBasePay.TextChanged += new System.EventHandler(this.txtBasePay_TextChanged);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(521, 78);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(553, 404);
            this.lstOutput.TabIndex = 8;
            // 
            // btnProcessPay
            // 
            this.btnProcessPay.AutoSize = true;
            this.btnProcessPay.Location = new System.Drawing.Point(55, 577);
            this.btnProcessPay.Name = "btnProcessPay";
            this.btnProcessPay.Size = new System.Drawing.Size(143, 100);
            this.btnProcessPay.TabIndex = 9;
            this.btnProcessPay.Text = "Process Pay";
            this.btnProcessPay.UseVisualStyleBackColor = true;
            this.btnProcessPay.Click += new System.EventHandler(this.btnProcessPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(347, 577);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 100);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(624, 577);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 100);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartingDate.Location = new System.Drawing.Point(218, 299);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(200, 31);
            this.dtpStartingDate.TabIndex = 12;
            this.dtpStartingDate.Value = new System.DateTime(2023, 10, 5, 0, 0, 0, 0);
            // 
            // dtpEndingDate
            // 
            this.dtpEndingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndingDate.Location = new System.Drawing.Point(218, 385);
            this.dtpEndingDate.Name = "dtpEndingDate";
            this.dtpEndingDate.Size = new System.Drawing.Size(200, 31);
            this.dtpEndingDate.TabIndex = 13;
            this.dtpEndingDate.Value = new System.DateTime(2023, 10, 5, 0, 0, 0, 0);
            // 
            // erpBasePay
            // 
            this.erpBasePay.ContainerControl = this;
            // 
            // JagSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 732);
            this.Controls.Add(this.dtpEndingDate);
            this.Controls.Add(this.dtpStartingDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcessPay);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtBasePay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEndingDate);
            this.Controls.Add(this.lblStartinigDate);
            this.Controls.Add(this.lblBasePay);
            this.Controls.Add(this.lblName);
            this.Name = "JagSales";
            this.Text = "Jag Sales";
            ((System.ComponentModel.ISupportInitialize)(this.erpBasePay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBasePay;
        private System.Windows.Forms.Label lblStartinigDate;
        private System.Windows.Forms.Label lblEndingDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBasePay;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnProcessPay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.DateTimePicker dtpEndingDate;
        private System.Windows.Forms.ErrorProvider erpBasePay;
    }
}

