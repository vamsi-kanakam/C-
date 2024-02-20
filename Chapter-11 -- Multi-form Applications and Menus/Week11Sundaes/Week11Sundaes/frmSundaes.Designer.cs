namespace Week11Sundaes
{
    partial class frmSundaes
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
            this.hsbScoops = new System.Windows.Forms.HScrollBar();
            this.lblNoOfScoops = new System.Windows.Forms.Label();
            this.tabInputs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculateOrder = new System.Windows.Forms.Button();
            this.cbWippedCream = new System.Windows.Forms.CheckBox();
            this.cbNuts = new System.Windows.Forms.CheckBox();
            this.lvwSundaes = new System.Windows.Forms.ListView();
            this.colIceCream = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabReceipt = new System.Windows.Forms.TabPage();
            this.lvwReceipt = new System.Windows.Forms.ListView();
            this.colItemsPurchased = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCostofItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabInputs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Scoops:";
            // 
            // hsbScoops
            // 
            this.hsbScoops.LargeChange = 2;
            this.hsbScoops.Location = new System.Drawing.Point(204, 14);
            this.hsbScoops.Maximum = 5;
            this.hsbScoops.Minimum = 1;
            this.hsbScoops.Name = "hsbScoops";
            this.hsbScoops.Size = new System.Drawing.Size(237, 34);
            this.hsbScoops.TabIndex = 1;
            this.hsbScoops.Value = 1;
            this.hsbScoops.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbScoops_Scroll);
            // 
            // lblNoOfScoops
            // 
            this.lblNoOfScoops.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoOfScoops.Location = new System.Drawing.Point(461, 14);
            this.lblNoOfScoops.Name = "lblNoOfScoops";
            this.lblNoOfScoops.Size = new System.Drawing.Size(86, 43);
            this.lblNoOfScoops.TabIndex = 2;
            // 
            // tabInputs
            // 
            this.tabInputs.Controls.Add(this.tabPage1);
            this.tabInputs.Controls.Add(this.tabReceipt);
            this.tabInputs.Location = new System.Drawing.Point(40, 28);
            this.tabInputs.Name = "tabInputs";
            this.tabInputs.SelectedIndex = 0;
            this.tabInputs.Size = new System.Drawing.Size(682, 586);
            this.tabInputs.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnCalculateOrder);
            this.tabPage1.Controls.Add(this.cbWippedCream);
            this.tabPage1.Controls.Add(this.cbNuts);
            this.tabPage1.Controls.Add(this.lvwSundaes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblNoOfScoops);
            this.tabPage1.Controls.Add(this.hsbScoops);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Selection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type of Sundae:";
            // 
            // btnCalculateOrder
            // 
            this.btnCalculateOrder.AutoSize = true;
            this.btnCalculateOrder.Location = new System.Drawing.Point(342, 423);
            this.btnCalculateOrder.Name = "btnCalculateOrder";
            this.btnCalculateOrder.Size = new System.Drawing.Size(220, 56);
            this.btnCalculateOrder.TabIndex = 6;
            this.btnCalculateOrder.Text = "Calculate Order";
            this.btnCalculateOrder.UseVisualStyleBackColor = true;
            this.btnCalculateOrder.Click += new System.EventHandler(this.btnCalculateOrder_Click);
            // 
            // cbWippedCream
            // 
            this.cbWippedCream.AutoSize = true;
            this.cbWippedCream.Location = new System.Drawing.Point(27, 423);
            this.cbWippedCream.Name = "cbWippedCream";
            this.cbWippedCream.Size = new System.Drawing.Size(198, 29);
            this.cbWippedCream.TabIndex = 5;
            this.cbWippedCream.Text = "Whipped Cream";
            this.cbWippedCream.UseVisualStyleBackColor = true;
            // 
            // cbNuts
            // 
            this.cbNuts.AutoSize = true;
            this.cbNuts.Location = new System.Drawing.Point(27, 367);
            this.cbNuts.Name = "cbNuts";
            this.cbNuts.Size = new System.Drawing.Size(88, 29);
            this.cbNuts.TabIndex = 4;
            this.cbNuts.Text = "Nuts";
            this.cbNuts.UseVisualStyleBackColor = true;
            // 
            // lvwSundaes
            // 
            this.lvwSundaes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIceCream,
            this.colPrices});
            this.lvwSundaes.FullRowSelect = true;
            this.lvwSundaes.HideSelection = false;
            this.lvwSundaes.Location = new System.Drawing.Point(11, 77);
            this.lvwSundaes.Name = "lvwSundaes";
            this.lvwSundaes.Size = new System.Drawing.Size(600, 284);
            this.lvwSundaes.TabIndex = 3;
            this.lvwSundaes.UseCompatibleStateImageBehavior = false;
            this.lvwSundaes.View = System.Windows.Forms.View.Details;
            // 
            // colIceCream
            // 
            this.colIceCream.Text = "Ice Cream";
            this.colIceCream.Width = 121;
            // 
            // colPrices
            // 
            this.colPrices.Text = "Prices";
            this.colPrices.Width = 128;
            // 
            // tabReceipt
            // 
            this.tabReceipt.Controls.Add(this.lvwReceipt);
            this.tabReceipt.Controls.Add(this.label3);
            this.tabReceipt.Location = new System.Drawing.Point(8, 39);
            this.tabReceipt.Name = "tabReceipt";
            this.tabReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceipt.Size = new System.Drawing.Size(666, 539);
            this.tabReceipt.TabIndex = 1;
            this.tabReceipt.Text = "Receipt";
            this.tabReceipt.UseVisualStyleBackColor = true;
            // 
            // lvwReceipt
            // 
            this.lvwReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemsPurchased,
            this.colCostofItems});
            this.lvwReceipt.FullRowSelect = true;
            this.lvwReceipt.HideSelection = false;
            this.lvwReceipt.Location = new System.Drawing.Point(54, 139);
            this.lvwReceipt.Name = "lvwReceipt";
            this.lvwReceipt.Size = new System.Drawing.Size(548, 342);
            this.lvwReceipt.TabIndex = 1;
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
            this.label3.Location = new System.Drawing.Point(49, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Receipt for Sundae Order:";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(483, 639);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(620, 639);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSundaes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tabInputs);
            this.Name = "frmSundaes";
            this.Text = "Ice Cream Orders";
            this.Load += new System.EventHandler(this.frmSundaes_Load);
            this.tabInputs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabReceipt.ResumeLayout(false);
            this.tabReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hsbScoops;
        private System.Windows.Forms.Label lblNoOfScoops;
        private System.Windows.Forms.TabControl tabInputs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbNuts;
        private System.Windows.Forms.ListView lvwSundaes;
        private System.Windows.Forms.TabPage tabReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculateOrder;
        private System.Windows.Forms.CheckBox cbWippedCream;
        private System.Windows.Forms.ColumnHeader colIceCream;
        private System.Windows.Forms.ColumnHeader colPrices;
        private System.Windows.Forms.ListView lvwReceipt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader colItemsPurchased;
        private System.Windows.Forms.ColumnHeader colCostofItems;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

