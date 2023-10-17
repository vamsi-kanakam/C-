namespace Week8HomeWork
{
    partial class frmIceCreamSundae
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
            this.lstBoxSundaeType = new System.Windows.Forms.ListBox();
            this.lblNoOfScoops = new System.Windows.Forms.Label();
            this.hsbScoops = new System.Windows.Forms.HScrollBar();
            this.lblScoopsDisplay = new System.Windows.Forms.Label();
            this.grpIceCreamFlavour = new System.Windows.Forms.GroupBox();
            this.rdbStrawberry = new System.Windows.Forms.RadioButton();
            this.rdbChocolate = new System.Windows.Forms.RadioButton();
            this.rdbVanilla = new System.Windows.Forms.RadioButton();
            this.cbNuts = new System.Windows.Forms.CheckBox();
            this.btnComputePrice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.grpIceCreamFlavour.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sundae Type:";
            // 
            // lstBoxSundaeType
            // 
            this.lstBoxSundaeType.FormattingEnabled = true;
            this.lstBoxSundaeType.ItemHeight = 25;
            this.lstBoxSundaeType.Items.AddRange(new object[] {
            "Custard",
            "Ice Cream",
            "Sorbet",
            "Yogurt"});
            this.lstBoxSundaeType.Location = new System.Drawing.Point(240, 51);
            this.lstBoxSundaeType.Name = "lstBoxSundaeType";
            this.lstBoxSundaeType.Size = new System.Drawing.Size(179, 54);
            this.lstBoxSundaeType.Sorted = true;
            this.lstBoxSundaeType.TabIndex = 1;
            this.lstBoxSundaeType.Validating += new System.ComponentModel.CancelEventHandler(this.lstBoxSundaeType_Validating);
            // 
            // lblNoOfScoops
            // 
            this.lblNoOfScoops.AutoSize = true;
            this.lblNoOfScoops.Location = new System.Drawing.Point(50, 153);
            this.lblNoOfScoops.Name = "lblNoOfScoops";
            this.lblNoOfScoops.Size = new System.Drawing.Size(132, 25);
            this.lblNoOfScoops.TabIndex = 2;
            this.lblNoOfScoops.Text = "# of Scoops:";
            // 
            // hsbScoops
            // 
            this.hsbScoops.LargeChange = 1;
            this.hsbScoops.Location = new System.Drawing.Point(239, 143);
            this.hsbScoops.Maximum = 3;
            this.hsbScoops.Minimum = 1;
            this.hsbScoops.Name = "hsbScoops";
            this.hsbScoops.Size = new System.Drawing.Size(179, 34);
            this.hsbScoops.TabIndex = 3;
            this.hsbScoops.Value = 1;
            this.hsbScoops.ValueChanged += new System.EventHandler(this.hsbScoops_ValueChanged);
            // 
            // lblScoopsDisplay
            // 
            this.lblScoopsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoopsDisplay.Location = new System.Drawing.Point(440, 132);
            this.lblScoopsDisplay.Name = "lblScoopsDisplay";
            this.lblScoopsDisplay.Size = new System.Drawing.Size(53, 46);
            this.lblScoopsDisplay.TabIndex = 4;
            // 
            // grpIceCreamFlavour
            // 
            this.grpIceCreamFlavour.Controls.Add(this.rdbStrawberry);
            this.grpIceCreamFlavour.Controls.Add(this.rdbChocolate);
            this.grpIceCreamFlavour.Controls.Add(this.rdbVanilla);
            this.grpIceCreamFlavour.Location = new System.Drawing.Point(55, 213);
            this.grpIceCreamFlavour.Name = "grpIceCreamFlavour";
            this.grpIceCreamFlavour.Size = new System.Drawing.Size(549, 64);
            this.grpIceCreamFlavour.TabIndex = 6;
            this.grpIceCreamFlavour.TabStop = false;
            this.grpIceCreamFlavour.Text = "Ice Cream Flavour";
            // 
            // rdbStrawberry
            // 
            this.rdbStrawberry.AutoSize = true;
            this.rdbStrawberry.Location = new System.Drawing.Point(288, 28);
            this.rdbStrawberry.Name = "rdbStrawberry";
            this.rdbStrawberry.Size = new System.Drawing.Size(146, 29);
            this.rdbStrawberry.TabIndex = 2;
            this.rdbStrawberry.TabStop = true;
            this.rdbStrawberry.Text = "Strawberry";
            this.rdbStrawberry.UseVisualStyleBackColor = true;
            // 
            // rdbChocolate
            // 
            this.rdbChocolate.AutoSize = true;
            this.rdbChocolate.Location = new System.Drawing.Point(133, 28);
            this.rdbChocolate.Name = "rdbChocolate";
            this.rdbChocolate.Size = new System.Drawing.Size(140, 29);
            this.rdbChocolate.TabIndex = 1;
            this.rdbChocolate.TabStop = true;
            this.rdbChocolate.Text = "Chocolate";
            this.rdbChocolate.UseVisualStyleBackColor = true;
            // 
            // rdbVanilla
            // 
            this.rdbVanilla.AutoSize = true;
            this.rdbVanilla.Checked = true;
            this.rdbVanilla.Location = new System.Drawing.Point(18, 29);
            this.rdbVanilla.Name = "rdbVanilla";
            this.rdbVanilla.Size = new System.Drawing.Size(108, 29);
            this.rdbVanilla.TabIndex = 0;
            this.rdbVanilla.TabStop = true;
            this.rdbVanilla.Text = "Vanilla";
            this.rdbVanilla.UseVisualStyleBackColor = true;
            // 
            // cbNuts
            // 
            this.cbNuts.AutoSize = true;
            this.cbNuts.Location = new System.Drawing.Point(55, 307);
            this.cbNuts.Name = "cbNuts";
            this.cbNuts.Size = new System.Drawing.Size(132, 29);
            this.cbNuts.TabIndex = 7;
            this.cbNuts.Text = "Add Nuts";
            this.cbNuts.UseVisualStyleBackColor = true;
            // 
            // btnComputePrice
            // 
            this.btnComputePrice.AutoSize = true;
            this.btnComputePrice.Location = new System.Drawing.Point(50, 382);
            this.btnComputePrice.Name = "btnComputePrice";
            this.btnComputePrice.Size = new System.Drawing.Size(163, 35);
            this.btnComputePrice.TabIndex = 8;
            this.btnComputePrice.Text = "Compute Price";
            this.btnComputePrice.UseVisualStyleBackColor = true;
            this.btnComputePrice.Click += new System.EventHandler(this.btnComputePrice_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.CausesValidation = false;
            this.btnClear.Location = new System.Drawing.Point(253, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.CausesValidation = false;
            this.btnExit.Location = new System.Drawing.Point(373, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(644, 51);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(438, 354);
            this.lstOutput.TabIndex = 11;
            // 
            // frmIceCreamSundae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnComputePrice);
            this.Controls.Add(this.cbNuts);
            this.Controls.Add(this.grpIceCreamFlavour);
            this.Controls.Add(this.lblScoopsDisplay);
            this.Controls.Add(this.hsbScoops);
            this.Controls.Add(this.lblNoOfScoops);
            this.Controls.Add(this.lstBoxSundaeType);
            this.Controls.Add(this.label1);
            this.Name = "frmIceCreamSundae";
            this.Text = "Ice Cream Sundae";
            this.grpIceCreamFlavour.ResumeLayout(false);
            this.grpIceCreamFlavour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxSundaeType;
        private System.Windows.Forms.Label lblNoOfScoops;
        private System.Windows.Forms.HScrollBar hsbScoops;
        private System.Windows.Forms.Label lblScoopsDisplay;
        private System.Windows.Forms.GroupBox grpIceCreamFlavour;
        private System.Windows.Forms.RadioButton rdbChocolate;
        private System.Windows.Forms.RadioButton rdbVanilla;
        private System.Windows.Forms.RadioButton rdbStrawberry;
        private System.Windows.Forms.CheckBox cbNuts;
        private System.Windows.Forms.Button btnComputePrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

