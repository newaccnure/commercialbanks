using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BankBankBank
{
	public partial class Search : Form
	{
		private List<Bank> inputBase;

		public Search()
		{
			InitializeComponent();
			comboBox1.SelectedItem = "Не имеет значения";
			comboBox2.SelectedItem = "Не имеет значения";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MainMenu main_menu = new MainMenu();
			Hide();
			main_menu.ShowDialog();
			Dispose();
		} //Переход в главное меню

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			numericTextBox1.Text = String.Format("{0}", trackBar1.Value * 100);
		} //Связь с numericBox

		private void numericTextBox1_TextChanged(object sender, EventArgs e)
		{
			if (numericTextBox1.Text != "")
			{
				trackBar1.Value = Convert.ToInt32(numericTextBox1.Text) / 100;
				numericTextBox1.Text = String.Format("{0}", Convert.ToInt32(numericTextBox1.Text));
			}
			else trackBar1.Value = 0;
		} //Связь с trackBar

		private void button2_Click(object sender, EventArgs e) //Поиск лучшего банка, по критериям
		{
			double maximalProfit = 1;
			if (inputBase.Count() > 0)
			{
				int term = Convert.ToInt32(numericUpDown1.Value);
				Bank result = new Bank();
				if (term != 0)
				{
					for (int i = 0; i < inputBase.Count(); i++)
					{
						double currentProfit = 1;
						if (inputBase[i].isSuitable(comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString(), checkBox1.Checked))
						{
							double percent = inputBase[i].Percent;
							if (inputBase[i].PosToGet)
							{
								currentProfit *= Math.Pow(1 + percent / 1200, Convert.ToInt32(numericUpDown1.Value));
							}
							else {
								for (int j = 0; j < term / inputBase[i].Term; j++)
								{
									currentProfit *= Math.Pow(1 + percent / 1200, inputBase[i].Term);
								}
							}
							if (maximalProfit < currentProfit)
							{
								maximalProfit = currentProfit;
								result = inputBase[i];
							}
						}
					}
					//int sum = Convert.ToInt32(maximalProfit * Convert.ToInt32(numericTextBox1.Text));
					//Bank noResult = new Bank();
					if (result.Term!=0)
					{
						int profit = Convert.ToInt32((maximalProfit - 1) * Convert.ToDouble(numericTextBox1.Text));
						dataGridView2.Rows.Clear();
						string[] line = result.ToString().Split('/');
						line = Bank.ConvertData(line);
						dataGridView2.Rows.Add(line);
						MessageBox.Show(profit.ToString());
					}
					else MessageBox.Show("Соответствий не найдено");
				}
				else MessageBox.Show("Выберите срок для своего вклада");
			}
			else MessageBox.Show("База пуста");
		}

		private void Search_Load(object sender, EventArgs e) //Загрузка базы данных при открытии формы для поиска
		{
			inputBase = Bank.ReadBase("dataBase.txt");
			for (int i = 0; i < inputBase.Count(); i++)
			{
				string[] line = inputBase[i].ToString().Split('/');
				line = Bank.ConvertData(line);
				dataGridView2.Rows.Add(line);
			}
			dataGridView2.ClearSelection();
			List<string> textOfBox = new List<string>();
			for (int i = 0; i < inputBase.Count(); i++) {	//Нахождение списка стран
				bool wasFound = false;
				int index = 0;
				while (index < textOfBox.Count() && !wasFound) {
					if (inputBase[i].Country == textOfBox[index]) {
						wasFound = true;
					}
					index++;
				}
				if (!wasFound && inputBase[i].Country != "Неизвестно") {
					textOfBox.Add(inputBase[i].Country);
					comboBox2.Items.Add(inputBase[i].Country);
				}
			}
		}

		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		} //Запрет на самостоятельный ввод от пользователя

		private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		} //Запрет на самостоятельный ввод от пользователя

		private void comboBox1_KeyDown(object sender, KeyEventArgs e)
		{
			e.Handled = true;
		}//Запрет на самостоятельный ввод от пользователя

		private void comboBox2_KeyDown(object sender, KeyEventArgs e)
		{
			e.Handled = true;
		}//Запрет на самостоятельный ввод от пользователя
	}
}
