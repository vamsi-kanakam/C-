namespace Week13Sundaes_wed
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculateOrder = new System.Windows.Forms.Button();
            this.cbWippedCream = new System.Windows.Forms.CheckBox();
            this.cbNuts = new System.Windows.Forms.CheckBox();
            this.lvwSundaes = new System.Windows.Forms.ListView();
            this.colIceCream = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoOfScoops = new System.Windows.Forms.Label();
            this.hsbScoops = new System.Windows.Forms.HScrollBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearInputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Type of Sundae:";
            // 
            // btnCalculateOrder
            // 
            this.btnCalculateOrder.AutoSize = true;
            this.btnCalculateOrder.Location = new System.Drawing.Point(43, 583);
            this.btnCalculateOrder.Name = "btnCalculateOrder";
            this.btnCalculateOrder.Size = new System.Drawing.Size(220, 56);
            this.btnCalculateOrder.TabIndex = 14;
            this.btnCalculateOrder.Text = "Calculate Order";
            this.btnCalculateOrder.UseVisualStyleBackColor = true;
            this.btnCalculateOrder.Click += new System.EventHandler(this.btnCalculateOrder_Click);
            // 
            // cbWippedCream
            // 
            this.cbWippedCream.AutoSize = true;
            this.cbWippedCream.Location = new System.Drawing.Point(43, 504);
            this.cbWippedCream.Name = "cbWippedCream";
            this.cbWippedCream.Size = new System.Drawing.Size(198, 29);
            this.cbWippedCream.TabIndex = 13;
            this.cbWippedCream.Text = "Whipped Cream";
            this.cbWippedCream.UseVisualStyleBackColor = true;
            // 
            // cbNuts
            // 
            this.cbNuts.AutoSize = true;
            this.cbNuts.Location = new System.Drawing.Point(43, 448);
            this.cbNuts.Name = "cbNuts";
            this.cbNuts.Size = new System.Drawing.Size(88, 29);
            this.cbNuts.TabIndex = 12;
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
            this.lvwSundaes.Location = new System.Drawing.Point(27, 158);
            this.lvwSundaes.Name = "lvwSundaes";
            this.lvwSundaes.Size = new System.Drawing.Size(600, 284);
            this.lvwSundaes.TabIndex = 11;
            this.lvwSundaes.UseCompatibleStateImageBehavior = false;
            this.lvwSundaes.View = System.Windows.Forms.View.Details;
            // 
            // colIceCream
            // 
            this.colIceCream.Text = "Ice Cream";
            this.colIceCream.Width = 175;
            // 
            // colPrices
            // 
            this.colPrices.Text = "Prices";
            this.colPrices.Width = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of Scoops:";
            // 
            // lblNoOfScoops
            // 
            this.lblNoOfScoops.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoOfScoops.Location = new System.Drawing.Point(477, 95);
            this.lblNoOfScoops.Name = "lblNoOfScoops";
            this.lblNoOfScoops.Size = new System.Drawing.Size(86, 43);
            this.lblNoOfScoops.TabIndex = 10;
            // 
            // hsbScoops
            // 
            this.hsbScoops.LargeChange = 2;
            this.hsbScoops.Location = new System.Drawing.Point(220, 95);
            this.hsbScoops.Maximum = 5;
            this.hsbScoops.Minimum = 1;
            this.hsbScoops.Name = "hsbScoops";
            this.hsbScoops.Size = new System.Drawing.Size(237, 34);
            this.hsbScoops.TabIndex = 9;
            this.hsbScoops.Value = 1;
            this.hsbScoops.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbScoops_Scroll);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(446, 594);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 35);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(309, 594);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 35);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // MainMenu
            // 
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 40);
            this.MainMenu.TabIndex = 18;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 44);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearInputsToolStripMenuItem,
            this.processOrdersToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // clearInputsToolStripMenuItem
            // 
            this.clearInputsToolStripMenuItem.Name = "clearInputsToolStripMenuItem";
            this.clearInputsToolStripMenuItem.Size = new System.Drawing.Size(304, 44);
            this.clearInputsToolStripMenuItem.Text = "&Clear Inputs";
            this.clearInputsToolStripMenuItem.Click += new System.EventHandler(this.clearInputsToolStripMenuItem_Click);
            // 
            // processOrdersToolStripMenuItem
            // 
            this.processOrdersToolStripMenuItem.Name = "processOrdersToolStripMenuItem";
            this.processOrdersToolStripMenuItem.Size = new System.Drawing.Size(304, 44);
            this.processOrdersToolStripMenuItem.Text = "&Process Orders";
            this.processOrdersToolStripMenuItem.Click += new System.EventHandler(this.processOrdersToolStripMenuItem_Click);
            // 
            // frmSundaes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculateOrder);
            this.Controls.Add(this.cbWippedCream);
            this.Controls.Add(this.cbNuts);
            this.Controls.Add(this.lvwSundaes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoOfScoops);
            this.Controls.Add(this.hsbScoops);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "frmSundaes";
            this.Text = "Ice Cream Order";
            this.Load += new System.EventHandler(this.frmSundaes_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculateOrder;
        private System.Windows.Forms.CheckBox cbWippedCream;
        private System.Windows.Forms.CheckBox cbNuts;
        private System.Windows.Forms.ListView lvwSundaes;
        private System.Windows.Forms.ColumnHeader colIceCream;
        private System.Windows.Forms.ColumnHeader colPrices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoOfScoops;
        private System.Windows.Forms.HScrollBar hsbScoops;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearInputsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processOrdersToolStripMenuItem;
    }
}

