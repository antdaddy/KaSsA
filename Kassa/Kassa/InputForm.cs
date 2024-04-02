using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa
{ 
    public partial class InputForm : Form
    {
        public string Barcode { get; internal set; }
        public string Quantity { get; internal set; }

        public int barcode;
        public int quantity;



        public InputForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Quantity = QuantityBox.Text;
            int.TryParse(Quantity, out quantity);

        }


        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void BarcodeBox_TextChanged(object sender, EventArgs e)
        {
            Barcode = BarcodeBox.Text;
            int.TryParse(Barcode, out barcode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Barcode) || string.IsNullOrEmpty(Quantity))
            {
                MessageBox.Show("Поля Barcode и Quantity не могут быть пустыми.");
            }
            else
            {
                // Если поля не пустые, продолжаем выполнение кода
                //  Console.WriteLine("Значение переменной Barcode: " + Barcode);
                //    Console.WriteLine("Значение переменной Quantity: " + Quantity);

                // Устанавливаем результат диалогового окна
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }

}
