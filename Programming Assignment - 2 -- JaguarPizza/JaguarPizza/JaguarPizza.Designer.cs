namespace JaguarPizza
{
    partial class JaguarPizza
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
            this.tabPizzaOrder = new System.Windows.Forms.TabControl();
            this.tbpProcessOrder = new System.Windows.Forms.TabPage();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.cbStudent = new System.Windows.Forms.CheckBox();
            this.grpCheckOut = new System.Windows.Forms.GroupBox();
            this.rdbPickUp = new System.Windows.Forms.RadioButton();
            this.rdbDelivery = new System.Windows.Forms.RadioButton();
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
            this.tbpReceipt = new System.Windows.Forms.TabPage();
            this.lvwReceipt = new System.Windows.Forms.ListView();
            this.colItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCostOfItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.tbpAddCustomers = new System.Windows.Forms.TabPage();
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ofdAddCustomer = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPizzaOrder.SuspendLayout();
            this.tbpProcessOrder.SuspendLayout();
            this.grpCheckOut.SuspendLayout();
            this.grpCrustType.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.tbpReceipt.SuspendLayout();
            this.tbpAddCustomers.SuspendLayout();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPizzaOrder
            // 
            this.tabPizzaOrder.Controls.Add(this.tbpProcessOrder);
            this.tabPizzaOrder.Controls.Add(this.tbpReceipt);
            this.tabPizzaOrder.Controls.Add(this.tbpAddCustomers);
            this.tabPizzaOrder.Location = new System.Drawing.Point(47, 54);
            this.tabPizzaOrder.Name = "tabPizzaOrder";
            this.tabPizzaOrder.SelectedIndex = 0;
            this.tabPizzaOrder.Size = new System.Drawing.Size(976, 847);
            this.tabPizzaOrder.TabIndex = 0;
            // 
            // tbpProcessOrder
            // 
            this.tbpProcessOrder.Controls.Add(this.btnProcessOrder);
            this.tbpProcessOrder.Controls.Add(this.cbStudent);
            this.tbpProcessOrder.Controls.Add(this.grpCheckOut);
            this.tbpProcessOrder.Controls.Add(this.lstToppings);
            this.tbpProcessOrder.Controls.Add(this.label2);
            this.tbpProcessOrder.Controls.Add(this.grpCrustType);
            this.tbpProcessOrder.Controls.Add(this.grpSize);
            this.tbpProcessOrder.Controls.Add(this.lblNoofPizzas);
            this.tbpProcessOrder.Controls.Add(this.hsbNoofPizzas);
            this.tbpProcessOrder.Controls.Add(this.label1);
            this.tbpProcessOrder.Controls.Add(this.lblOrderDetails);
            this.tbpProcessOrder.Controls.Add(this.cboCustomerName);
            this.tbpProcessOrder.Controls.Add(this.lblCustomer);
            this.tbpProcessOrder.Location = new System.Drawing.Point(8, 39);
            this.tbpProcessOrder.Name = "tbpProcessOrder";
            this.tbpProcessOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProcessOrder.Size = new System.Drawing.Size(960, 800);
            this.tbpProcessOrder.TabIndex = 0;
            this.tbpProcessOrder.Text = "Process an Order";
            this.tbpProcessOrder.UseVisualStyleBackColor = true;
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.Location = new System.Drawing.Point(594, 687);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(223, 49);
            this.btnProcessOrder.TabIndex = 12;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = true;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // cbStudent
            // 
            this.cbStudent.AutoSize = true;
            this.cbStudent.Location = new System.Drawing.Point(77, 698);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(118, 29);
            this.cbStudent.TabIndex = 11;
            this.cbStudent.Text = "Student";
            this.cbStudent.UseVisualStyleBackColor = true;
            // 
            // grpCheckOut
            // 
            this.grpCheckOut.Controls.Add(this.rdbPickUp);
            this.grpCheckOut.Controls.Add(this.rdbDelivery);
            this.grpCheckOut.Location = new System.Drawing.Point(65, 593);
            this.grpCheckOut.Name = "grpCheckOut";
            this.grpCheckOut.Size = new System.Drawing.Size(332, 74);
            this.grpCheckOut.TabIndex = 10;
            this.grpCheckOut.TabStop = false;
            this.grpCheckOut.Text = "CheckOut";
            // 
            // rdbPickUp
            // 
            this.rdbPickUp.AutoSize = true;
            this.rdbPickUp.Location = new System.Drawing.Point(203, 31);
            this.rdbPickUp.Name = "rdbPickUp";
            this.rdbPickUp.Size = new System.Drawing.Size(117, 29);
            this.rdbPickUp.TabIndex = 1;
            this.rdbPickUp.TabStop = true;
            this.rdbPickUp.Text = "Pick Up";
            this.rdbPickUp.UseVisualStyleBackColor = true;
            // 
            // rdbDelivery
            // 
            this.rdbDelivery.AutoSize = true;
            this.rdbDelivery.Location = new System.Drawing.Point(17, 31);
            this.rdbDelivery.Name = "rdbDelivery";
            this.rdbDelivery.Size = new System.Drawing.Size(121, 29);
            this.rdbDelivery.TabIndex = 0;
            this.rdbDelivery.TabStop = true;
            this.rdbDelivery.Text = "Delivery";
            this.rdbDelivery.UseVisualStyleBackColor = true;
            // 
            // lstToppings
            // 
            this.lstToppings.FormattingEnabled = true;
            this.lstToppings.ItemHeight = 25;
            this.lstToppings.Location = new System.Drawing.Point(176, 420);
            this.lstToppings.Name = "lstToppings";
            this.lstToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstToppings.Size = new System.Drawing.Size(261, 154);
            this.lstToppings.Sorted = true;
            this.lstToppings.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Toppings:";
            // 
            // grpCrustType
            // 
            this.grpCrustType.Controls.Add(this.rdbThin);
            this.grpCrustType.Controls.Add(this.rdbTraditional);
            this.grpCrustType.Controls.Add(this.rdbDeepDish);
            this.grpCrustType.Location = new System.Drawing.Point(55, 303);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(460, 94);
            this.grpCrustType.TabIndex = 7;
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
            this.grpSize.Location = new System.Drawing.Point(55, 209);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(509, 76);
            this.grpSize.TabIndex = 6;
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
            this.lblNoofPizzas.Location = new System.Drawing.Point(512, 129);
            this.lblNoofPizzas.Name = "lblNoofPizzas";
            this.lblNoofPizzas.Size = new System.Drawing.Size(100, 56);
            this.lblNoofPizzas.TabIndex = 5;
            // 
            // hsbNoofPizzas
            // 
            this.hsbNoofPizzas.LargeChange = 5;
            this.hsbNoofPizzas.Location = new System.Drawing.Point(228, 129);
            this.hsbNoofPizzas.Maximum = 24;
            this.hsbNoofPizzas.Name = "hsbNoofPizzas";
            this.hsbNoofPizzas.Size = new System.Drawing.Size(209, 34);
            this.hsbNoofPizzas.TabIndex = 4;
            this.hsbNoofPizzas.Value = 1;
            this.hsbNoofPizzas.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbNoofPizzas_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "No.of Pizzas:";
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Location = new System.Drawing.Point(31, 83);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(138, 25);
            this.lblOrderDetails.TabIndex = 2;
            this.lblOrderDetails.Text = "Order Details";
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(265, 23);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(186, 33);
            this.cboCustomerName.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(26, 23);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(212, 25);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Select the Customer:";
            // 
            // tbpReceipt
            // 
            this.tbpReceipt.Controls.Add(this.lvwReceipt);
            this.tbpReceipt.Controls.Add(this.label3);
            this.tbpReceipt.Location = new System.Drawing.Point(8, 39);
            this.tbpReceipt.Name = "tbpReceipt";
            this.tbpReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReceipt.Size = new System.Drawing.Size(960, 800);
            this.tbpReceipt.TabIndex = 1;
            this.tbpReceipt.Text = "Receipt";
            this.tbpReceipt.UseVisualStyleBackColor = true;
            // 
            // lvwReceipt
            // 
            this.lvwReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItems,
            this.colCostOfItems});
            this.lvwReceipt.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwReceipt.HideSelection = false;
            this.lvwReceipt.Location = new System.Drawing.Point(86, 145);
            this.lvwReceipt.Name = "lvwReceipt";
            this.lvwReceipt.Size = new System.Drawing.Size(750, 554);
            this.lvwReceipt.TabIndex = 1;
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
            this.colCostOfItems.Width = 215;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Receipt For Pizza Order:";
            // 
            // tbpAddCustomers
            // 
            this.tbpAddCustomers.Controls.Add(this.grp);
            this.tbpAddCustomers.Location = new System.Drawing.Point(8, 39);
            this.tbpAddCustomers.Name = "tbpAddCustomers";
            this.tbpAddCustomers.Size = new System.Drawing.Size(960, 800);
            this.tbpAddCustomers.TabIndex = 2;
            this.tbpAddCustomers.Text = "Add New Customers";
            this.tbpAddCustomers.UseVisualStyleBackColor = true;
            // 
            // grp
            // 
            this.grp.Controls.Add(this.btnClearInput);
            this.grp.Controls.Add(this.lblCustomerName);
            this.grp.Controls.Add(this.txtPhoneNumber);
            this.grp.Controls.Add(this.txtCustomerName);
            this.grp.Controls.Add(this.lblPhoneNumber);
            this.grp.Controls.Add(this.lblStreet);
            this.grp.Controls.Add(this.btnAddCustomer);
            this.grp.Controls.Add(this.txtStreetAddress);
            this.grp.Controls.Add(this.txtZipCode);
            this.grp.Controls.Add(this.label5);
            this.grp.Location = new System.Drawing.Point(172, 133);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(577, 434);
            this.grp.TabIndex = 12;
            this.grp.TabStop = false;
            this.grp.Text = "Add New Customer Details";
            // 
            // btnClearInput
            // 
            this.btnClearInput.AutoSize = true;
            this.btnClearInput.Location = new System.Drawing.Point(309, 307);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(75, 35);
            this.btnClearInput.TabIndex = 12;
            this.btnClearInput.Text = "Clear";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(52, 49);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(74, 25);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(251, 208);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(190, 31);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(251, 43);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(190, 31);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(51, 214);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(155, 25);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "PhoneNumber:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(51, 107);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(160, 25);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street Address:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoSize = true;
            this.btnAddCustomer.Location = new System.Drawing.Point(57, 307);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(158, 35);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(251, 101);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(190, 31);
            this.txtStreetAddress.TabIndex = 3;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(251, 157);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(190, 31);
            this.txtZipCode.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "ZipCode:";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(382, 954);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(567, 954);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ofdAddCustomer
            // 
            this.ofdAddCustomer.FileName = "ofdAddCustomer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(821, 974);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Programmed by: K.Vamsi Krishna Prasad";
            // 
            // JaguarPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 1082);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tabPizzaOrder);
            this.Name = "JaguarPizza";
            this.Text = "Jaguar Pizza";
            this.Load += new System.EventHandler(this.JaguarPizza_Load);
            this.tabPizzaOrder.ResumeLayout(false);
            this.tbpProcessOrder.ResumeLayout(false);
            this.tbpProcessOrder.PerformLayout();
            this.grpCheckOut.ResumeLayout(false);
            this.grpCheckOut.PerformLayout();
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.tbpReceipt.ResumeLayout(false);
            this.tbpReceipt.PerformLayout();
            this.tbpAddCustomers.ResumeLayout(false);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPizzaOrder;
        private System.Windows.Forms.TabPage tbpProcessOrder;
        private System.Windows.Forms.TabPage tbpReceipt;
        private System.Windows.Forms.TabPage tbpAddCustomers;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblNoofPizzas;
        private System.Windows.Forms.HScrollBar hsbNoofPizzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCrustType;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdbSuper;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbThin;
        private System.Windows.Forms.RadioButton rdbTraditional;
        private System.Windows.Forms.RadioButton rdbDeepDish;
        private System.Windows.Forms.ListBox lstToppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCheckOut;
        private System.Windows.Forms.RadioButton rdbPickUp;
        private System.Windows.Forms.RadioButton rdbDelivery;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.CheckBox cbStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lvwReceipt;
        private System.Windows.Forms.ColumnHeader colItems;
        private System.Windows.Forms.ColumnHeader colCostOfItems;
        private System.Windows.Forms.OpenFileDialog ofdAddCustomer;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Button btnClearInput;
    }
}

