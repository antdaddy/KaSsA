
namespace Kassa
{
    partial class KassaForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prodazha = new System.Windows.Forms.Button();
            this.sposob = new System.Windows.Forms.Button();
            this.Ochistka = new System.Windows.Forms.Button();
            this.kolichestvo = new System.Windows.Forms.Button();
            this.vvod = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.65079F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.34921F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1261, 664);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prodazha);
            this.groupBox1.Controls.Add(this.sposob);
            this.groupBox1.Controls.Add(this.Ochistka);
            this.groupBox1.Controls.Add(this.kolichestvo);
            this.groupBox1.Controls.Add(this.vvod);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(994, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 552);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // prodazha
            // 
            this.prodazha.Location = new System.Drawing.Point(-3, 442);
            this.prodazha.Name = "prodazha";
            this.prodazha.Size = new System.Drawing.Size(266, 78);
            this.prodazha.TabIndex = 4;
            this.prodazha.Text = "ПРОДАЖА ТОВАРА";
            this.prodazha.UseVisualStyleBackColor = true;
            this.prodazha.Click += new System.EventHandler(this.prodazha_Click);
            // 
            // sposob
            // 
            this.sposob.Location = new System.Drawing.Point(-3, 348);
            this.sposob.Name = "sposob";
            this.sposob.Size = new System.Drawing.Size(266, 78);
            this.sposob.TabIndex = 3;
            this.sposob.Text = "СПОСОБ ОПЛАТЫ";
            this.sposob.UseVisualStyleBackColor = true;
            this.sposob.Click += new System.EventHandler(this.sposob_Click);
            // 
            // Ochistka
            // 
            this.Ochistka.Location = new System.Drawing.Point(-3, 249);
            this.Ochistka.Name = "Ochistka";
            this.Ochistka.Size = new System.Drawing.Size(266, 78);
            this.Ochistka.TabIndex = 2;
            this.Ochistka.Text = "ОЧИСТИТЬ ЛЕНТУ";
            this.Ochistka.UseVisualStyleBackColor = true;
            this.Ochistka.Click += new System.EventHandler(this.Ochistka_Click);
            // 
            // kolichestvo
            // 
            this.kolichestvo.Location = new System.Drawing.Point(-3, 152);
            this.kolichestvo.Name = "kolichestvo";
            this.kolichestvo.Size = new System.Drawing.Size(266, 78);
            this.kolichestvo.TabIndex = 1;
            this.kolichestvo.Text = "ИЗМЕН. КОЛИЧЕСТВО";
            this.kolichestvo.UseVisualStyleBackColor = true;
            this.kolichestvo.Click += new System.EventHandler(this.kolichestvo_Click);
            // 
            // vvod
            // 
            this.vvod.Location = new System.Drawing.Point(0, 52);
            this.vvod.Name = "vvod";
            this.vvod.Size = new System.Drawing.Size(266, 78);
            this.vvod.TabIndex = 0;
            this.vvod.Text = "ВВОД ТОВАРА";
            this.vvod.UseVisualStyleBackColor = true;
            this.vvod.Click += new System.EventHandler(this.vvod_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.barcode,
            this.quantity,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(985, 549);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Штрих-код";
            this.barcode.MinimumWidth = 10;
            this.barcode.Name = "barcode";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Количество";
            this.quantity.MinimumWidth = 10;
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.MinimumWidth = 10;
            this.price.Name = "price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 561);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(182, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ИТОГО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KassaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KassaForm";
            this.Text = "KassaForm";
            this.Load += new System.EventHandler(this.KassaForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button prodazha;
        private System.Windows.Forms.Button sposob;
        private System.Windows.Forms.Button Ochistka;
        private System.Windows.Forms.Button kolichestvo;
        private System.Windows.Forms.Button vvod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
       
    }
}