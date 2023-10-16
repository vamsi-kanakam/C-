namespace Ch6_GUIcontrols
{
    partial class TheaterTickets
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
            this.hsbNumOfTickets = new System.Windows.Forms.HScrollBar();
            this.lblNumOfTickets = new System.Windows.Forms.Label();
            this.chkMember = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSec1 = new System.Windows.Forms.RadioButton();
            this.rdbSec2 = new System.Windows.Forms.RadioButton();
            this.rdbSec3 = new System.Windows.Forms.RadioButton();
            this.rdbSec4 = new System.Windows.Forms.RadioButton();
            this.rdbDefault = new System.Windows.Forms.RadioButton();
            this.btnComputePrice = new System.Windows.Forms.Button();
            this.lblAmtDue = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboShow = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "# of Tickets:";
            // 
            // hsbNumOfTickets
            // 
            this.hsbNumOfTickets.LargeChange = 1;
            this.hsbNumOfTickets.Location = new System.Drawing.Point(208, 52);
            this.hsbNumOfTickets.Maximum = 10;
            this.hsbNumOfTickets.Name = "hsbNumOfTickets";
            this.hsbNumOfTickets.Size = new System.Drawing.Size(149, 34);
            this.hsbNumOfTickets.TabIndex = 1;
            this.hsbNumOfTickets.ValueChanged += new System.EventHandler(this.hsbNumOfTickets_ValueChanged);
            // 
            // lblNumOfTickets
            // 
            this.lblNumOfTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfTickets.Location = new System.Drawing.Point(390, 41);
            this.lblNumOfTickets.Name = "lblNumOfTickets";
            this.lblNumOfTickets.Size = new System.Drawing.Size(65, 55);
            this.lblNumOfTickets.TabIndex = 2;
            // 
            // chkMember
            // 
            this.chkMember.AutoSize = true;
            this.chkMember.Location = new System.Drawing.Point(452, 175);
            this.chkMember.Name = "chkMember";
            this.chkMember.Size = new System.Drawing.Size(134, 29);
            this.chkMember.TabIndex = 4;
            this.chkMember.Text = "Member?";
            this.chkMember.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDefault);
            this.groupBox1.Controls.Add(this.rdbSec4);
            this.groupBox1.Controls.Add(this.rdbSec3);
            this.groupBox1.Controls.Add(this.rdbSec2);
            this.groupBox1.Controls.Add(this.rdbSec1);
            this.groupBox1.Location = new System.Drawing.Point(43, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section#";
            // 
            // rdbSec1
            // 
            this.rdbSec1.AutoSize = true;
            this.rdbSec1.Location = new System.Drawing.Point(13, 31);
            this.rdbSec1.Name = "rdbSec1";
            this.rdbSec1.Size = new System.Drawing.Size(55, 29);
            this.rdbSec1.TabIndex = 0;
            this.rdbSec1.TabStop = true;
            this.rdbSec1.Text = "1";
            this.rdbSec1.UseVisualStyleBackColor = true;
            // 
            // rdbSec2
            // 
            this.rdbSec2.AutoSize = true;
            this.rdbSec2.Location = new System.Drawing.Point(96, 30);
            this.rdbSec2.Name = "rdbSec2";
            this.rdbSec2.Size = new System.Drawing.Size(55, 29);
            this.rdbSec2.TabIndex = 1;
            this.rdbSec2.TabStop = true;
            this.rdbSec2.Text = "2";
            this.rdbSec2.UseVisualStyleBackColor = true;
            // 
            // rdbSec3
            // 
            this.rdbSec3.AutoSize = true;
            this.rdbSec3.Location = new System.Drawing.Point(177, 30);
            this.rdbSec3.Name = "rdbSec3";
            this.rdbSec3.Size = new System.Drawing.Size(55, 29);
            this.rdbSec3.TabIndex = 6;
            this.rdbSec3.TabStop = true;
            this.rdbSec3.Text = "3";
            this.rdbSec3.UseVisualStyleBackColor = true;
            // 
            // rdbSec4
            // 
            this.rdbSec4.AutoSize = true;
            this.rdbSec4.Location = new System.Drawing.Point(248, 31);
            this.rdbSec4.Name = "rdbSec4";
            this.rdbSec4.Size = new System.Drawing.Size(55, 29);
            this.rdbSec4.TabIndex = 6;
            this.rdbSec4.TabStop = true;
            this.rdbSec4.Text = "4";
            this.rdbSec4.UseVisualStyleBackColor = true;
            // 
            // rdbDefault
            // 
            this.rdbDefault.AutoSize = true;
            this.rdbDefault.Location = new System.Drawing.Point(316, 30);
            this.rdbDefault.Name = "rdbDefault";
            this.rdbDefault.Size = new System.Drawing.Size(55, 29);
            this.rdbDefault.TabIndex = 7;
            this.rdbDefault.TabStop = true;
            this.rdbDefault.Text = "0";
            this.rdbDefault.UseVisualStyleBackColor = true;
            this.rdbDefault.Visible = false;
            // 
            // btnComputePrice
            // 
            this.btnComputePrice.AutoSize = true;
            this.btnComputePrice.Location = new System.Drawing.Point(56, 240);
            this.btnComputePrice.Name = "btnComputePrice";
            this.btnComputePrice.Size = new System.Drawing.Size(163, 35);
            this.btnComputePrice.TabIndex = 6;
            this.btnComputePrice.Text = "Compute Price";
            this.btnComputePrice.UseVisualStyleBackColor = true;
            this.btnComputePrice.Click += new System.EventHandler(this.btnComputePrice_Click);
            // 
            // lblAmtDue
            // 
            this.lblAmtDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmtDue.Location = new System.Drawing.Point(238, 240);
            this.lblAmtDue.Name = "lblAmtDue";
            this.lblAmtDue.Size = new System.Drawing.Size(84, 45);
            this.lblAmtDue.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(472, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboShow
            // 
            this.cboShow.FormattingEnabled = true;
            this.cboShow.Location = new System.Drawing.Point(56, 315);
            this.cboShow.Name = "cboShow";
            this.cboShow.Size = new System.Drawing.Size(195, 33);
            this.cboShow.TabIndex = 8;
            this.cboShow.SelectedIndexChanged += new System.EventHandler(this.cboShow_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(311, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Write Sales";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(311, 397);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(521, 129);
            this.lstOutput.TabIndex = 10;
            // 
            // TheaterTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(932, 582);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboShow);
            this.Controls.Add(this.lblAmtDue);
            this.Controls.Add(this.btnComputePrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMember);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNumOfTickets);
            this.Controls.Add(this.hsbNumOfTickets);
            this.Controls.Add(this.label1);
            this.Name = "TheaterTickets";
            this.Text = "Theater Tickets";
            this.Load += new System.EventHandler(this.TheaterTickets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hsbNumOfTickets;
        private System.Windows.Forms.Label lblNumOfTickets;
        private System.Windows.Forms.CheckBox chkMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDefault;
        private System.Windows.Forms.RadioButton rdbSec4;
        private System.Windows.Forms.RadioButton rdbSec3;
        private System.Windows.Forms.RadioButton rdbSec2;
        private System.Windows.Forms.RadioButton rdbSec1;
        private System.Windows.Forms.Button btnComputePrice;
        private System.Windows.Forms.Label lblAmtDue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

