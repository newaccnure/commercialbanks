using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace BankBankBank
{
	public partial class Adding_Deleting_Editing : Form
	{
		private List<Bank> inputBase;
        private string pathToBase;
		public Adding_Deleting_Editing(string path)
		{
			InitializeComponent();
            pathToBase = path;
            ControlFormBox.SelectedItem = "Неизвестно";
		}
		public static double Transform(string input)//Преобразование строки в тип double
		{
			double result;
			if (input.IndexOf('.') != -1)
			{
				input = input.Replace('.',',');
			}
			result = Convert.ToDouble(input);
			return result;
		}

		private void button1_Click(object sender, EventArgs e)//Сохранение базы данных и переход в главное меню 
		{
			if (File.Exists(pathToBase))
			{
				using (FileStream output = new FileStream(pathToBase, FileMode.Open))
				{
					var serializor = new BinaryFormatter();
					serializor.Serialize(output, inputBase);
				}
			}
			MainMenu main_menu = new MainMenu(pathToBase);
			Hide();
			main_menu.ShowDialog();
			Dispose();
		}

        private void button2_Click(object sender, EventArgs e)//Обработка данных и добавление банка в базу 
        {
            double percents;
            bool isFull = true;

            if (Namebox.Text == "")
            {
                Namelabel.BackColor = Color.Red;
                isFull = false;
            }
            else Namelabel.BackColor = Color.White;

            Regex regexp = new Regex(@"^[0-9]+([\,\.]{0,1}[0-9]+)?$");
            if (!regexp.IsMatch(Percentbox.Text) || Percentbox.Text == "0") {
				PercentLabel.BackColor = Color.Red;
				isFull = false;
			}
			else PercentLabel.BackColor = Color.White;
			
			if (Termbox.Value == 0)
			{
				TermLabel.BackColor = Color.Red;
				isFull = false;
			}
			else TermLabel.BackColor = Color.White;

			string Country = "";
			try {
				Country = Bank.TryConvertToCountry(CountryBox.Text);
				CountryLabel.BackColor = Color.White;
			}
			catch (ArgumentException){
				if (CountryBox.Text != "")
				{
					CountryLabel.BackColor = Color.Red;
					isFull = false;
				}
			}

			string City = "";
			try
			{
				City = Bank.TryConvertToCountry(CityBox.Text);
				CityLabel.BackColor = Color.White;
			}
			catch (ArgumentException)
			{
				if (CityBox.Text != "")
				{
					CityLabel.BackColor = Color.Red;
					isFull = false;
				}
			}
			
			if (isFull)
			{
				percents = Transform(Percentbox.Text);
				Bank bankToAdd = new Bank(Namebox.Text.Trim(), Country, City, 
                    StreetBox.Text.Trim(), ControlFormBox.Text, percents, Convert.ToInt32(Termbox.Value),
                    PosToAddbox.Checked, PosToGetbox.Checked, AddingPercrb.Checked);
				inputBase.Add(bankToAdd);
				string[] line = bankToAdd.ToString().Split('#');
				line = Bank.ConvertData(line);
				dataGridView1.Rows.Add(line);
			}
			else {
				MessageBox.Show("Убедитесь в правильности ввода данных");
			}
		}

		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void Adding_Editing_Load(object sender, EventArgs e)//Загрузка базы при открытии формы
		{
			inputBase = Bank.ReadBase(pathToBase);
            MyStream.Refresh(inputBase, dataGridView1);
            dataGridView1.ClearSelection();
		}

		private void button3_Click(object sender, EventArgs e)//Удаление банка из базы
		{
			if (dataGridView1.CurrentRow.Index != 0) {
				inputBase.RemoveAt(dataGridView1.CurrentRow.Index);
				dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
			}
			else MessageBox.Show("Для удаления выберите строку с банком");
		}

		private void Adding_Editing_FormClosed(object sender, FormClosedEventArgs e)//Сохранение базы при закрытии формы
		{
			if (File.Exists(pathToBase))
			{
				using (FileStream output = new FileStream(pathToBase, FileMode.Open))
				{
					var serializor = new BinaryFormatter();
					serializor.Serialize(output,inputBase);
				}
			}
		}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//Переход к редактированию
        {
            if (e.RowIndex != -1)
            {
                Bank editingBank = inputBase[e.RowIndex];
                Editing edit = new Editing(editingBank,e.RowIndex,dataGridView1);
                edit.ShowDialog();
            }
        }

        private void Namebox_TextChanged(object sender, EventArgs e)
        {
            while (Namebox.Text.Contains('#'))
            {
                Namebox.Text = Namebox.Text.Remove(Namebox.Text.IndexOf('#'), 1);
            }
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                inputBase = MyStream.Open(out pathToBase);
            }
            catch (Exception)
            {
                pathToBase = "dataBase.txt";
                MessageBox.Show("Неверный формат файла");
            }
            MyStream.Refresh(inputBase,dataGridView1);
        }

        private void asdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyStream.Save(inputBase);
        }
    }
}
