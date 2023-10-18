namespace Ch8_FilesAndArrays
{
    partial class TwoDimArray
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
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnDisplaySales = new System.Windows.Forms.Button();
            this.txtProdNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(23, 50);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(274, 46);
            this.lstDisplay.TabIndex = 4;
            // 
            // btnDisplaySales
            // 
            this.btnDisplaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplaySales.Location = new System.Drawing.Point(176, 21);
            this.btnDisplaySales.Name = "btnDisplaySales";
            this.btnDisplaySales.Size = new System.Drawing.Size(121, 29);
            this.btnDisplaySales.TabIndex = 5;
            this.btnDisplaySales.Text = "Display Sales";
            this.btnDisplaySales.UseVisualStyleBackColor = true;
            this.btnDisplaySales.Click += new System.EventHandler(this.btnDisplaySales_Click);
            // 
            // txtProdNumber
            // 
            this.txtProdNumber.AcceptsReturn = true;
            this.txtProdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdNumber.Location = new System.Drawing.Point(89, 20);
            this.txtProdNumber.Name = "txtProdNumber";
            this.txtProdNumber.Size = new System.Drawing.Size(81, 24);
            this.txtProdNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product#:";
            // 
            // TwoDimArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdNumber);
            this.Controls.Add(this.btnDisplaySales);
            this.Controls.Add(this.lstDisplay);
            this.Name = "TwoDimArray";
            this.Text = "Two Dimensional Array";
            this.Load += new System.EventHandler(this.TwoDimArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnDisplaySales;
        private System.Windows.Forms.TextBox txtProdNumber;
        private System.Windows.Forms.Label label1;
    }
}