namespace Ch8_FilesAndArrays
{
    partial class PassingArrays
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
            this.btnDisplayAboveAvg = new System.Windows.Forms.Button();
            this.btnDisplayPercent = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDisplayAboveAvg
            // 
            this.btnDisplayAboveAvg.Location = new System.Drawing.Point(234, 8);
            this.btnDisplayAboveAvg.Name = "btnDisplayAboveAvg";
            this.btnDisplayAboveAvg.Size = new System.Drawing.Size(113, 29);
            this.btnDisplayAboveAvg.TabIndex = 12;
            this.btnDisplayAboveAvg.Text = "Display Above Avg";
            this.btnDisplayAboveAvg.UseVisualStyleBackColor = true;
            this.btnDisplayAboveAvg.Click += new System.EventHandler(this.btnDisplayAboveAvg_Click);
            // 
            // btnDisplayPercent
            // 
            this.btnDisplayPercent.BackColor = System.Drawing.Color.Silver;
            this.btnDisplayPercent.Location = new System.Drawing.Point(124, 6);
            this.btnDisplayPercent.Name = "btnDisplayPercent";
            this.btnDisplayPercent.Size = new System.Drawing.Size(104, 32);
            this.btnDisplayPercent.TabIndex = 11;
            this.btnDisplayPercent.Text = "Display Percent";
            this.btnDisplayPercent.UseVisualStyleBackColor = false;
            this.btnDisplayPercent.Click += new System.EventHandler(this.btnDisplayPercent_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(12, 46);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(335, 88);
            this.lstDisplay.TabIndex = 10;
            // 
            // PassingArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 146);
            this.Controls.Add(this.btnDisplayAboveAvg);
            this.Controls.Add(this.btnDisplayPercent);
            this.Controls.Add(this.lstDisplay);
            this.Name = "PassingArrays";
            this.Text = "Passing Arrays";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayAboveAvg;
        internal System.Windows.Forms.Button btnDisplayPercent;
        internal System.Windows.Forms.ListBox lstDisplay;
    }
}