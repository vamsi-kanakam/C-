namespace Ch6_GUIcontrols
{
    partial class PizzaOrder
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
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.btnComputePrice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.rdbDefault = new System.Windows.Forms.RadioButton();
            this.lstToppings = new System.Windows.Forms.ListBox();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdbDefault);
            this.grpSize.Controls.Add(this.rdbLarge);
            this.grpSize.Controls.Add(this.rdbMedium);
            this.grpSize.Controls.Add(this.rdbSmall);
            this.grpSize.Location = new System.Drawing.Point(27, 28);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(545, 73);
            this.grpSize.TabIndex = 0;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(26, 30);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(96, 29);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(143, 30);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(119, 29);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(287, 30);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(98, 29);
            this.rdbLarge.TabIndex = 1;
            this.rdbLarge.TabStop = true;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            // 
            // btnComputePrice
            // 
            this.btnComputePrice.AutoSize = true;
            this.btnComputePrice.Location = new System.Drawing.Point(338, 172);
            this.btnComputePrice.Name = "btnComputePrice";
            this.btnComputePrice.Size = new System.Drawing.Size(163, 35);
            this.btnComputePrice.TabIndex = 2;
            this.btnComputePrice.Text = "Compute Price";
            this.btnComputePrice.UseVisualStyleBackColor = true;
            this.btnComputePrice.Click += new System.EventHandler(this.btnComputePrice_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(547, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(338, 252);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(406, 204);
            this.lstOutput.TabIndex = 4;
            // 
            // rdbDefault
            // 
            this.rdbDefault.AutoSize = true;
            this.rdbDefault.Location = new System.Drawing.Point(410, 30);
            this.rdbDefault.Name = "rdbDefault";
            this.rdbDefault.Size = new System.Drawing.Size(111, 29);
            this.rdbDefault.TabIndex = 2;
            this.rdbDefault.TabStop = true;
            this.rdbDefault.Text = "Default";
            this.rdbDefault.UseVisualStyleBackColor = true;
            this.rdbDefault.Visible = false;
            // 
            // lstToppings
            // 
            this.lstToppings.FormattingEnabled = true;
            this.lstToppings.ItemHeight = 25;
            this.lstToppings.Location = new System.Drawing.Point(27, 172);
            this.lstToppings.Name = "lstToppings";
            this.lstToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstToppings.Size = new System.Drawing.Size(216, 204);
            this.lstToppings.TabIndex = 5;
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.lstToppings);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnComputePrice);
            this.Controls.Add(this.grpSize);
            this.Name = "PizzaOrder";
            this.Text = "PizzaOrder";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.Button btnComputePrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.RadioButton rdbDefault;
        private System.Windows.Forms.ListBox lstToppings;
    }
}