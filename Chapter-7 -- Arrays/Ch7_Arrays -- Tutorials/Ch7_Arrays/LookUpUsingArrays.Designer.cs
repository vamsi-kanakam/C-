namespace Ch7_Arrays
{
    partial class LookUpUsingArrays
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnDisplayUnitSold = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUnitSold = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(40, 83);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(78, 25);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(205, 83);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 31);
            this.txtMonth.TabIndex = 1;
            // 
            // btnDisplayUnitSold
            // 
            this.btnDisplayUnitSold.Location = new System.Drawing.Point(76, 161);
            this.btnDisplayUnitSold.Name = "btnDisplayUnitSold";
            this.btnDisplayUnitSold.Size = new System.Drawing.Size(188, 45);
            this.btnDisplayUnitSold.TabIndex = 2;
            this.btnDisplayUnitSold.Text = "Display Unit Sold";
            this.btnDisplayUnitSold.UseVisualStyleBackColor = true;
            this.btnDisplayUnitSold.Click += new System.EventHandler(this.btnDisplayUnitSold_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Units Sold:";
            // 
            // lblUnitSold
            // 
            this.lblUnitSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnitSold.Location = new System.Drawing.Point(174, 266);
            this.lblUnitSold.Name = "lblUnitSold";
            this.lblUnitSold.Size = new System.Drawing.Size(77, 40);
            this.lblUnitSold.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(440, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LookUpUsingArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblUnitSold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisplayUnitSold);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblMonth);
            this.Name = "LookUpUsingArrays";
            this.Text = "LookUpUsingArrays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnDisplayUnitSold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUnitSold;
        private System.Windows.Forms.Button btnClear;
    }
}