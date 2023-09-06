namespace Ch_IntroProgramming
{
    partial class IceCreamCost
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
            this.lblScoop = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtScoops = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblCst = new System.Windows.Forms.Label();
            this.btnComputeCost = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScoop
            // 
            this.lblScoop.AutoSize = true;
            this.lblScoop.Location = new System.Drawing.Point(33, 36);
            this.lblScoop.Name = "lblScoop";
            this.lblScoop.Size = new System.Drawing.Size(68, 13);
            this.lblScoop.TabIndex = 0;
            this.lblScoop.Text = "# of Scoops:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(45, 84);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // txtScoops
            // 
            this.txtScoops.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoops.Location = new System.Drawing.Point(118, 33);
            this.txtScoops.Name = "txtScoops";
            this.txtScoops.Size = new System.Drawing.Size(100, 22);
            this.txtScoops.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(118, 81);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // lblCst
            // 
            this.lblCst.AutoEllipsis = true;
            this.lblCst.AutoSize = true;
            this.lblCst.Location = new System.Drawing.Point(270, 68);
            this.lblCst.Name = "lblCst";
            this.lblCst.Size = new System.Drawing.Size(31, 13);
            this.lblCst.TabIndex = 4;
            this.lblCst.Text = "Cost:";
            // 
            // btnComputeCost
            // 
            this.btnComputeCost.Location = new System.Drawing.Point(39, 161);
            this.btnComputeCost.Name = "btnComputeCost";
            this.btnComputeCost.Size = new System.Drawing.Size(75, 23);
            this.btnComputeCost.TabIndex = 6;
            this.btnComputeCost.Text = "Compute Cost";
            this.btnComputeCost.UseVisualStyleBackColor = true;
            this.btnComputeCost.Click += new System.EventHandler(this.btnComputeCost_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(154, 161);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(273, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCost.Location = new System.Drawing.Point(304, 66);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(2, 15);
            this.lblCost.TabIndex = 9;
            // 
            // IceCreamCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnComputeCost);
            this.Controls.Add(this.lblCst);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtScoops);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblScoop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IceCreamCost";
            this.Text = "Ice Cream Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScoop;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtScoops;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblCst;
        private System.Windows.Forms.Button btnComputeCost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCost;
    }
}

