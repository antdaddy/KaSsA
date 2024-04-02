
namespace Kassa
{
    partial class InputForm
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
            this.barcode_label = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.BarcodeBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barcode_label
            // 
            this.barcode_label.AutoSize = true;
            this.barcode_label.Location = new System.Drawing.Point(64, 99);
            this.barcode_label.Name = "barcode_label";
            this.barcode_label.Size = new System.Drawing.Size(198, 25);
            this.barcode_label.TabIndex = 0;
            this.barcode_label.Text = "Введите штрихкод";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(64, 254);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(129, 25);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "Количество";
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Location = new System.Drawing.Point(282, 96);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(142, 31);
            this.BarcodeBox.TabIndex = 2;
            this.BarcodeBox.TextChanged += new System.EventHandler(this.BarcodeBox_TextChanged);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(282, 248);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(134, 31);
            this.QuantityBox.TabIndex = 3;
            this.QuantityBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 117);
            this.button1.TabIndex = 4;
            this.button1.Text = "ВВОД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.BarcodeBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.barcode_label);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label barcode_label;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox BarcodeBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Button button1;
    }
}