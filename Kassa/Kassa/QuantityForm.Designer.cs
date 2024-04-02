
namespace Kassa
{
    partial class QuantityForm
    {

        private System.ComponentModel.IContainer components = null;


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
            this.Quantity = new System.Windows.Forms.Label();
            this.qqvantityBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.BarcodeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(85, 158);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(129, 25);
            this.Quantity.TabIndex = 0;
            this.Quantity.Text = "Количество";
            this.Quantity.Click += new System.EventHandler(this.Quantity_Click);
            // 
            // qqvantityBox
            // 
            this.qqvantityBox.Location = new System.Drawing.Point(311, 158);
            this.qqvantityBox.Name = "qqvantityBox";
            this.qqvantityBox.Size = new System.Drawing.Size(100, 31);
            this.qqvantityBox.TabIndex = 1;
            this.qqvantityBox.TextChanged += new System.EventHandler(this.qqvantityBox_TextChanged_1);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(526, 158);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(119, 36);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(85, 94);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(117, 25);
            this.barcodeLabel.TabIndex = 3;
            this.barcodeLabel.Text = "Штрих-код";
            this.barcodeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Location = new System.Drawing.Point(311, 87);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(100, 31);
            this.BarcodeBox.TabIndex = 4;
            this.BarcodeBox.TextChanged += new System.EventHandler(this.BarcodeBox_TextChanged_1);
            // 
            // QuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BarcodeBox);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.qqvantityBox);
            this.Controls.Add(this.Quantity);
            this.Name = "QuantityForm";
            this.Text = "QuantityForm";
            this.Load += new System.EventHandler(this.QuantityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox qqvantityBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.TextBox BarcodeBox;
    }
}