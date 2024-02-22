namespace JaguarPizza2
{
    partial class frmProcessAnOrder
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
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.cbStudent = new System.Windows.Forms.CheckBox();
            this.lstToppings = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCrustType = new System.Windows.Forms.GroupBox();
            this.rdbThin = new System.Windows.Forms.RadioButton();
            this.rdbTraditional = new System.Windows.Forms.RadioButton();
            this.rdbDeepDish = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdbSuper = new System.Windows.Forms.RadioButton();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.lblNoofPizzas = new System.Windows.Forms.Label();
            this.hsbNoofPizzas = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbDelivery = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ProcessMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpCrustType.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.ProcessMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.Location = new System.Drawing.Point(691, 604);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(223, 49);
            this.btnProcessOrder.TabIndex = 25;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = true;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // cbStudent
            // 
            this.cbStudent.AutoSize = true;
            this.cbStudent.Location = new System.Drawing.Point(176, 793);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(118, 29);
            this.cbStudent.TabIndex = 24;
            this.cbStudent.Text = "Student";
            this.cbStudent.UseVisualStyleBackColor = true;
            // 
            // lstToppings
            // 
            this.lstToppings.FormattingEnabled = true;
            this.lstToppings.ItemHeight = 25;
            this.lstToppings.Location = new System.Drawing.Point(275, 515);
            this.lstToppings.Name = "lstToppings";
            this.lstToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstToppings.Size = new System.Drawing.Size(261, 154);
            this.lstToppings.Sorted = true;
            this.lstToppings.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Toppings:";
            // 
            // grpCrustType
            // 
            this.grpCrustType.Controls.Add(this.rdbThin);
            this.grpCrustType.Controls.Add(this.rdbTraditional);
            this.grpCrustType.Controls.Add(this.rdbDeepDish);
            this.grpCrustType.Location = new System.Drawing.Point(154, 398);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(460, 94);
            this.grpCrustType.TabIndex = 20;
            this.grpCrustType.TabStop = false;
            this.grpCrustType.Text = "CrustType";
            // 
            // rdbThin
            // 
            this.rdbThin.AutoSize = true;
            this.rdbThin.Location = new System.Drawing.Point(358, 41);
            this.rdbThin.Name = "rdbThin";
            this.rdbThin.Size = new System.Drawing.Size(85, 29);
            this.rdbThin.TabIndex = 2;
            this.rdbThin.TabStop = true;
            this.rdbThin.Text = "Thin";
            this.rdbThin.UseVisualStyleBackColor = true;
            // 
            // rdbTraditional
            // 
            this.rdbTraditional.AutoSize = true;
            this.rdbTraditional.Location = new System.Drawing.Point(190, 41);
            this.rdbTraditional.Name = "rdbTraditional";
            this.rdbTraditional.Size = new System.Drawing.Size(144, 29);
            this.rdbTraditional.TabIndex = 1;
            this.rdbTraditional.TabStop = true;
            this.rdbTraditional.Text = "Traditional";
            this.rdbTraditional.UseVisualStyleBackColor = true;
            // 
            // rdbDeepDish
            // 
            this.rdbDeepDish.AutoSize = true;
            this.rdbDeepDish.Location = new System.Drawing.Point(27, 41);
            this.rdbDeepDish.Name = "rdbDeepDish";
            this.rdbDeepDish.Size = new System.Drawing.Size(143, 29);
            this.rdbDeepDish.TabIndex = 0;
            this.rdbDeepDish.TabStop = true;
            this.rdbDeepDish.Text = "Deep Dish";
            this.rdbDeepDish.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdbSuper);
            this.grpSize.Controls.Add(this.rdbLarge);
            this.grpSize.Controls.Add(this.rdbMedium);
            this.grpSize.Controls.Add(this.rdbSmall);
            this.grpSize.Location = new System.Drawing.Point(154, 304);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(509, 76);
            this.grpSize.TabIndex = 19;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rdbSuper
            // 
            this.rdbSuper.AutoSize = true;
            this.rdbSuper.Location = new System.Drawing.Point(386, 31);
            this.rdbSuper.Name = "rdbSuper";
            this.rdbSuper.Size = new System.Drawing.Size(100, 29);
            this.rdbSuper.TabIndex = 3;
            this.rdbSuper.TabStop = true;
            this.rdbSuper.Text = "Super";
            this.rdbSuper.UseVisualStyleBackColor = true;
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(272, 31);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(98, 29);
            this.rdbLarge.TabIndex = 2;
            this.rdbLarge.TabStop = true;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(140, 31);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(119, 29);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(27, 31);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(96, 29);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            // 
            // lblNoofPizzas
            // 
            this.lblNoofPizzas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoofPizzas.Location = new System.Drawing.Point(611, 224);
            this.lblNoofPizzas.Name = "lblNoofPizzas";
            this.lblNoofPizzas.Size = new System.Drawing.Size(100, 56);
            this.lblNoofPizzas.TabIndex = 18;
            // 
            // hsbNoofPizzas
            // 
            this.hsbNoofPizzas.LargeChange = 5;
            this.hsbNoofPizzas.Location = new System.Drawing.Point(327, 224);
            this.hsbNoofPizzas.Maximum = 24;
            this.hsbNoofPizzas.Name = "hsbNoofPizzas";
            this.hsbNoofPizzas.Size = new System.Drawing.Size(209, 34);
            this.hsbNoofPizzas.TabIndex = 17;
            this.hsbNoofPizzas.Value = 1;
            this.hsbNoofPizzas.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbNoofPizzas_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "No.of Pizzas:";
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Location = new System.Drawing.Point(130, 178);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(138, 25);
            this.lblOrderDetails.TabIndex = 15;
            this.lblOrderDetails.Text = "Order Details";
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(364, 118);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(186, 33);
            this.cboCustomerName.TabIndex = 14;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(125, 118);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(212, 25);
            this.lblCustomer.TabIndex = 13;
            this.lblCustomer.Text = "Select the Customer:";
            // 
            // cbDelivery
            // 
            this.cbDelivery.AutoSize = true;
            this.cbDelivery.Location = new System.Drawing.Point(176, 725);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(122, 29);
            this.cbDelivery.TabIndex = 26;
            this.cbDelivery.Text = "Delivery";
            this.cbDelivery.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 856);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Programmed by: K.Vamsi Krishna Prasad";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(691, 678);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(223, 49);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProcessMenu
            // 
            this.ProcessMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ProcessMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ProcessMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.ProcessMenu.Location = new System.Drawing.Point(0, 0);
            this.ProcessMenu.Name = "ProcessMenu";
            this.ProcessMenu.Size = new System.Drawing.Size(1068, 42);
            this.ProcessMenu.TabIndex = 29;
            this.ProcessMenu.Text = "menuStrip1";
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
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processOrderToolStripMenuItem,
            this.addCustomerToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(118, 38);
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
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(374, 44);
            this.addCustomerToolStripMenuItem.Text = "Main Menu";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(691, 751);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(223, 49);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmProcessAnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 906);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ProcessMenu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDelivery);
            this.Controls.Add(this.btnProcessOrder);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.lstToppings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.lblNoofPizzas);
            this.Controls.Add(this.hsbNoofPizzas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.cboCustomerName);
            this.Controls.Add(this.lblCustomer);
            this.Name = "frmProcessAnOrder";
            this.Text = "frmProcessAnOrder";
            this.Load += new System.EventHandler(this.frmProcessAnOrder_Load);
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.ProcessMenu.ResumeLayout(false);
            this.ProcessMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.CheckBox cbStudent;
        private System.Windows.Forms.ListBox lstToppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCrustType;
        private System.Windows.Forms.RadioButton rdbThin;
        private System.Windows.Forms.RadioButton rdbTraditional;
        private System.Windows.Forms.RadioButton rdbDeepDish;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdbSuper;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.Label lblNoofPizzas;
        private System.Windows.Forms.HScrollBar hsbNoofPizzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderDetails;
        public  System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.CheckBox cbDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip ProcessMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
    }
}