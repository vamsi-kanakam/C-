namespace JaguarPizza2
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
            this.colItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCostOfItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceiptMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceiptMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwReceipt
            // 
            this.lvwReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItems,
            this.colCostOfItems});
            this.lvwReceipt.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwReceipt.HideSelection = false;
            this.lvwReceipt.Location = new System.Drawing.Point(156, 180);
            this.lvwReceipt.Name = "lvwReceipt";
            this.lvwReceipt.Size = new System.Drawing.Size(750, 554);
            this.lvwReceipt.TabIndex = 3;
            this.lvwReceipt.UseCompatibleStateImageBehavior = false;
            this.lvwReceipt.View = System.Windows.Forms.View.Details;
            // 
            // colItems
            // 
            this.colItems.Text = "Items Ordered";
            this.colItems.Width = 219;
            // 
            // colCostOfItems
            // 
            this.colCostOfItems.Text = "Cost of Items";
            this.colCostOfItems.Width = 395;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receipt For Pizza Order:";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(531, 807);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 55);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(335, 807);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 55);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 888);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Programmed by: K.Vamsi Krishna Prasad";
            // 
            // ReceiptMenu
            // 
            this.ReceiptMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ReceiptMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ReceiptMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.ReceiptMenu.Location = new System.Drawing.Point(0, 0);
            this.ReceiptMenu.Name = "ReceiptMenu";
            this.ReceiptMenu.Size = new System.Drawing.Size(1079, 40);
            this.ReceiptMenu.TabIndex = 30;
            this.ReceiptMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processOrderToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // processOrderToolStripMenuItem
            // 
            this.processOrderToolStripMenuItem.Name = "processOrderToolStripMenuItem";
            this.processOrderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.processOrderToolStripMenuItem.Size = new System.Drawing.Size(374, 44);
            this.processOrderToolStripMenuItem.Text = "Process Order";
            this.processOrderToolStripMenuItem.Click += new System.EventHandler(this.processOrderToolStripMenuItem_Click);
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 939);
            this.Controls.Add(this.ReceiptMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvwReceipt);
            this.Controls.Add(this.label3);
            this.Name = "frmReceipt";
            this.Text = "frmReceipt";
            this.ReceiptMenu.ResumeLayout(false);
            this.ReceiptMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvwReceipt;
        private System.Windows.Forms.ColumnHeader colItems;
        private System.Windows.Forms.ColumnHeader colCostOfItems;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip ReceiptMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processOrderToolStripMenuItem;
    }
}