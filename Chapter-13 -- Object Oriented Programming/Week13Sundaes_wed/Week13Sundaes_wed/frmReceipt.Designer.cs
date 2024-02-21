namespace Week13Sundaes_wed
{
    partial class frmReceipt
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
            this.lvwReceipt = new System.Windows.Forms.ListView();
            this.colItemsPurchased = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCostofItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwReceipt
            // 
            this.lvwReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemsPurchased,
            this.colCostofItems});
            this.lvwReceipt.FullRowSelect = true;
            this.lvwReceipt.HideSelection = false;
            this.lvwReceipt.Location = new System.Drawing.Point(22, 101);
            this.lvwReceipt.Name = "lvwReceipt";
            this.lvwReceipt.Size = new System.Drawing.Size(548, 342);
            this.lvwReceipt.TabIndex = 3;
            this.lvwReceipt.UseCompatibleStateImageBehavior = false;
            this.lvwReceipt.View = System.Windows.Forms.View.Details;
            // 
            // colItemsPurchased
            // 
            this.colItemsPurchased.Text = "Items Purchased";
            this.colItemsPurchased.Width = 188;
            // 
            // colCostofItems
            // 
            this.colCostofItems.Text = "Cost of Items";
            this.colCostofItems.Width = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receipt for Sundae Order:";
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.lvwReceipt);
            this.Controls.Add(this.label3);
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvwReceipt;
        private System.Windows.Forms.ColumnHeader colItemsPurchased;
        private System.Windows.Forms.ColumnHeader colCostofItems;
        private System.Windows.Forms.Label label3;
    }
}