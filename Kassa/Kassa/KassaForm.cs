using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa
{
    public partial class KassaForm : Form
    {
        public KassaForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Проверяем, что введенный символ не является цифрой
            {
                e.Handled = true; // Отклоняем ввод символа
            }
        }

  

        private void vvod_Click(object sender, EventArgs e)
        {
            //// Открываем диалоговое окно для ввода штрихкода и количества
            InputForm inputForm = new InputForm();
            if (inputForm.ShowDialog() == DialogResult.OK)
                
            {
                // Получаем введенные данные
                string barcode = inputForm.Barcode;
                string quantity = inputForm.Quantity;
            
                // Читаем данные из текстового файла
                string pathToFile = @"C:\Users\ant_daddy\OneDrive\Рабочий стол\save_me\Kassa\Kassa\db.txt";
                string[] lines = File.ReadAllLines(pathToFile);

                // Находим строку с данными о товаре по barcode
                string[] foundData = lines.FirstOrDefault(line => line.StartsWith(barcode))?.Split(',');

                if (foundData != null && foundData.Length >= 3) // Проверяем, что данные найдены и содержат необходимые поля
                {
                    string name = foundData[1];
                    decimal price = decimal.Parse(foundData[2]);

                    // Добавляем данные в DataGridView
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = name; // добавляем название в первую колонку
                    dataGridView1.Rows[rowIndex].Cells[1].Value = barcode; // добавляем штрихкод во вторую колонку
                    dataGridView1.Rows[rowIndex].Cells[2].Value = quantity; // добавляем количество в третью колонку
                    dataGridView1.Rows[rowIndex].Cells[3].Value = price * int.Parse(quantity); // добавляем цену * количество в четвертую колонку
                }
                else
                {
                    MessageBox.Show("Данные для штрихкода не найдены.");
                }
            }
            GetSum();
        }

        private void kolichestvo_Click(object sender, EventArgs e)
        {
            //// Открываем диалоговое окно для ввода штрихкода и количества
            QuantityForm inputForm = new QuantityForm();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                // Получаем введенные данные
                string barcode1 = inputForm.Barcode1;
                string quantity1 = inputForm.Quantity1;
                //   Console.WriteLine("Значение переменной barcode1: " + barcode1);
                // Console.WriteLine("Значение переменной quantity1: " + quantity1);

                // Проверяем совпадение штрих-кода и обновляем значения в таблице
                for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)
                {
                    // Проверяем, что значение ячейки не равно null
                    if (dataGridView1.Rows[rowIndex].Cells[1].Value != null)
                    {
                        string cellValue = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();

                        // Сравниваем значения в ячейке и barcode1

                        if (barcode1 == cellValue)
                        {
                            // Обновляем количество
                            dataGridView1.Rows[rowIndex].Cells[2].Value = quantity1;

                            // Перерасчитываем стоимость
                            /* int sum = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[3].Value);
                             int price = sum / dataGridView1.Rows[2].Value;
                             int quantity = Convert.ToInt32(quantity1);
                            */
                            int quantity = Convert.ToInt32(quantity1);
                            int price1 = Convert.ToInt32(Get_Price(barcode1));
                            int sum = quantity * price1;
                            dataGridView1.Rows[rowIndex].Cells[3].Value = sum;
                            // Console.WriteLine(dataGridView1.Rows[rowIndex]);
                        }
                    }
                }

            }
            GetSum();
        }

        private void Ochistka_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            // dataGridView1.Columns.Clear();
            GetSum();
        }
        public void GetSum()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                sum += Convert.ToInt32((row.Cells[3].Value));
                //  Console.WriteLine((int)row.Cells[3].Value);

            }
            label2.Text = sum.ToString();


        }

        public string Get_Price(string barcode)
        {
            string pathToFile = @"C:\Users\ant_daddy\OneDrive\Рабочий стол\save_me\Kassa\Kassa\db.txt"; ;
            string[] lines = File.ReadAllLines(pathToFile);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] substrings = lines[i].Split(',');
                if (substrings[0] == barcode)
                {
                    return substrings[2];
                }
            }

            return "0"; // Возвращаем "0" только если ни одна строка не соответствует условию
        }

        private void sposob_Click(object sender, EventArgs e)
        {
            (new SposobForm()).ShowDialog();
        }

        private void prodazha_Click(object sender, EventArgs e)
        {
            ExportToTxt();
            dataGridView1.Rows.Clear();
            GetSum();
        }
        private void ExportToTxt()
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value + "\t"); // Добавляем значение ячейки и табуляцию
                }

                sb.AppendLine(); // Переход на новую строку после обработки всех ячеек строки
            }
            sb.Append("ИТОГО " + label2.Text);

            // Сохраняем данные в текстовый файл
            string filePath = @"C:\Users\ant_daddy\OneDrive\Рабочий стол\save_me\Kassa\Kassa\Check.txt"; ;
            File.WriteAllText(filePath, sb.ToString());

            MessageBox.Show("Данные успешно экспортированы в файл Check.txt");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KassaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
