using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BankBankBank
{
	public partial class Search : Form
	{
		private List<Bank> inputBase;
        private string pathToBase;
		public Search(string path)
		{
			InitializeComponent();
            pathToBase = path;
			ControlFormbox.SelectedItem = "Не имеет значения";
			CountryBox.SelectedItem = "Не имеет значения";
		}

		private void button1_Click(object sender, EventArgs e)//Переход в главное меню
		{
			MainMenu main_menu = new MainMenu(pathToBase);
			Hide();
			main_menu.ShowDialog();
			Dispose();
		} 

		private void trackBar1_Scroll(object sender, EventArgs e)//Связь с numericBox
		{
			SumNumericBox.Text = String.Format("{0}", SumTrackBar.Value * 100);
		} 

		private void numericTextBox1_TextChanged(object sender, EventArgs e)//Связь с trackBar
		{
			if (SumNumericBox.Text != "")
			{
				SumTrackBar.Value = Convert.ToInt32(SumNumericBox.Text) / 100;
				SumNumericBox.Text = String.Format("{0}", Convert.ToInt32(SumNumericBox.Text));
			}
			else SumTrackBar.Value = 0;
		} 

		private void button2_Click(object sender, EventArgs e) //Поиск лучшего банка, по критериям
		{
			double maximalProfit = 1;
			if (inputBase.Count() > 0)
			{
				int term = Convert.ToInt32(Termbox.Value);
				Bank result = new Bank();
				if (term != 0)
				{
					for (int i = 0; i < inputBase.Count(); i++)
					{
						double currentProfit = 1;
						if (inputBase[i].isSuitable(ControlFormbox.SelectedItem.ToString(),
                            CountryBox.SelectedItem.ToString(), PosToAddbox.Checked))
						{
							double percent = inputBase[i].Percent;
							if (inputBase[i].PosToGet)
							{
								currentProfit *= Math.Pow(1 + percent / 1200, Convert.ToInt32(Termbox.Value));
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
					if (result.Term!=0)
					{
						int profit = Convert.ToInt32((maximalProfit - 1) * Convert.ToDouble(SumNumericBox.Text));
						dataGridView2.Rows.Clear();
						string[] line = result.ToString().Split('#');
						line = Bank.ConvertData(line);
						dataGridView2.Rows.Add(line);
						label6.Visible = true;
						label6.Text = String.Format("Ваш доход составит:{0}",profit);
					}
					else MessageBox.Show("Соответствий не найдено");
				}
				else MessageBox.Show("Выберите срок для своего вклада");
			}
			else MessageBox.Show("База пуста");
		}

		private void Search_Load(object sender, EventArgs e) //Загрузка базы данных при открытии формы для поиска
		{
			inputBase = Bank.ReadBase(pathToBase);
			for (int i = 0; i < inputBase.Count(); i++)
			{
				string[] line = inputBase[i].ToString().Split('#');
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
					CountryBox.Items.Add(inputBase[i].Country);
				}
			}
		}

		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)//Запрет на самостоятельный ввод от пользователя
		{
			e.Handled = true;
		} 

		private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)//Запрет на самостоятельный ввод от пользователя
		{
			e.Handled = true;
		}

		private void comboBox1_KeyDown(object sender, KeyEventArgs e)//Запрет на самостоятельный ввод от пользователя
		{
			e.Handled = true;
		}
		
		private void comboBox2_KeyDown(object sender, KeyEventArgs e)//Запрет на самостоятельный ввод от пользователя
		{
			e.Handled = true;
		}

		private void button3_Click(object sender, EventArgs e)//Возврат к изначальной базе
		{
            MyStream.Refresh(inputBase, dataGridView2);
            label6.Visible = false;
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                inputBase = MyStream.Open(out pathToBase);
            }
            catch (Exception) {
                MessageBox.Show("Неверный формат файла");
            }
            MyStream.Refresh(inputBase, dataGridView2);
        }
        private void asdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyStream.Save(inputBase);
        }
    }
}
