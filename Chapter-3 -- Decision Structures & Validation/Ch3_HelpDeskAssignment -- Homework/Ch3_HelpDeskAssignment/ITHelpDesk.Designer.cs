namespace Ch3_HelpDeskAssignment
{
    partial class ITHelpDesk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDptCode = new System.Windows.Forms.TextBox();
            this.txtFixedCost = new System.Windows.Forms.TextBox();
            this.txtAreaOfSupport = new System.Windows.Forms.TextBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.erpFixedCost = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpFixedCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fixed Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area of Support:";
            // 
            // txtDptCode
            // 
            this.txtDptCode.Location = new System.Drawing.Point(295, 58);
            this.txtDptCode.Name = "txtDptCode";
            this.txtDptCode.Size = new System.Drawing.Size(200, 31);
            this.txtDptCode.TabIndex = 5;
            // 
            // txtFixedCost
            // 
            this.txtFixedCost.Location = new System.Drawing.Point(295, 247);
            this.txtFixedCost.Name = "txtFixedCost";
            this.txtFixedCost.Size = new System.Drawing.Size(200, 31);
            this.txtFixedCost.TabIndex = 6;
            this.txtFixedCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtFixedCost_Validating);
            // 
            // txtAreaOfSupport
            // 
            this.txtAreaOfSupport.Location = new System.Drawing.Point(295, 306);
            this.txtAreaOfSupport.Name = "txtAreaOfSupport";
            this.txtAreaOfSupport.Size = new System.Drawing.Size(200, 31);
            this.txtAreaOfSupport.TabIndex = 7;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(295, 116);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(200, 31);
            this.dtpStartTime.TabIndex = 8;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(295, 194);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(200, 31);
            this.dtpEndTime.TabIndex = 9;
            // 
            // btnCompute
            // 
            this.btnCompute.AutoSize = true;
            this.btnCompute.Location = new System.Drawing.Point(260, 401);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(108, 35);
            this.btnCompute.TabIndex = 10;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(620, 58);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(497, 279);
            this.lstOutput.TabIndex = 11;
            // 
            // erpFixedCost
            // 
            this.erpFixedCost.ContainerControl = this;
            // 
            // ITHelpDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 577);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.txtAreaOfSupport);
            this.Controls.Add(this.txtFixedCost);
            this.Controls.Add(this.txtDptCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ITHelpDesk";
            this.Text = "IT Help Desk";
            ((System.ComponentModel.ISupportInitialize)(this.erpFixedCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDptCode;
        private System.Windows.Forms.TextBox txtFixedCost;
        private System.Windows.Forms.TextBox txtAreaOfSupport;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.ErrorProvider erpFixedCost;
    }
}

