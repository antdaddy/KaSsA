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
    public partial class QuantityForm : Form
    {
        public string Barcode1 { get; internal set; }
        public string Quantity1 { get; internal set; }

        public int barcode1;
        public int quantity1;


        public QuantityForm()
        {
            InitializeComponent();
        }


        /*    private void qqvantityBox_TextChanged(object sender, EventArgs e)
            {
              //  if (!string.IsNullOrEmpty(qqvantityBox.Text))
            //    {
                    Quantity1 = qqvantityBox.Text;
                    int.TryParse(Quantity1, out quantity1);
                    Console.WriteLine("Значение переменной Quantity: " + Quantity1 + quantity1);
            //    }
             //   else
             //   {
             //       MessageBox.Show("Поле количество не может быть пустым.");
             //   }
            }
            */
        private void QuantityForm_Load(object sender, EventArgs e)
        {

        }

        /*  private void BarcodeBox_TextChanged(object sender, EventArgs e)
          {
             // if (!string.IsNullOrEmpty(BarcodeBox.Text))
             // {
                  Barcode1 = BarcodeBox.Text;
                  int.TryParse(Barcode1, out barcode1);
                  Console.WriteLine("Значение переменной Barcode: " + Barcode1 + barcode1);
            //  }
            //  else
            //  {
            //      MessageBox.Show("Поле штрих-код не может быть пустым.");
            //  }
          }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            //    if (string.IsNullOrEmpty(Barcode1) || string.IsNullOrEmpty(Quantity1))
            //     {
            //        MessageBox.Show("Поля Barcode и Quantity не могут быть пустыми.");
            //   }


            // Если поля не пустые, продолжаем выполнение кода
            //   Console.WriteLine("Значение переменной Barcode: " + Barcode1);
            //   Console.WriteLine("Значение переменной Quantity: " + Quantity1);

            // Устанавливаем результат диалогового окна
            this.DialogResult = DialogResult.OK;
            this.Close();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_Click(object sender, EventArgs e)
        {

        }

        private void BarcodeBox_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BarcodeBox.Text))
            {
                Barcode1 = BarcodeBox.Text;
                int.TryParse(Barcode1, out barcode1);
                Console.WriteLine("Значение переменной Barcode: " + Barcode1 + barcode1);
            }
            else
            {
                MessageBox.Show("Поле штрих-код не может быть пустым.");
            }
        }

        private void qqvantityBox_TextChanged_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(qqvantityBox.Text))
            {
                Quantity1 = qqvantityBox.Text;
                int.TryParse(Quantity1, out quantity1);
                Console.WriteLine("Значение переменной Quantity: " + Quantity1 + quantity1);
            }
            else
            {
                MessageBox.Show("Поле количество не может быть пустым.");
            }

        }
    }
}
