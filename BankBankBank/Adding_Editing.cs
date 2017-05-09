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
using System.Text.RegularExpressions;
namespace BankBankBank
{
	public partial class Adding_Editing : Form
	{
		private List<Bank> inputBase;
		public Adding_Editing()
		{
			InitializeComponent();
		}
		public static double Transform(string input) {
			double result;
			if (input.IndexOf('.') != -1)
			{
				input = input.Replace('.',',');
			}
			result = Convert.ToDouble(input);
			return result;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StreamWriter output = new StreamWriter("dataBase.txt");
			for (int i = 0; i < inputBase.Count(); i++) {
				output.WriteLine(inputBase[i]);
			}
			output.Close();
			MainMenu main_menu = new MainMenu();
			Hide();
			main_menu.ShowDialog();
			Dispose();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double percents;
			bool isFull = true;
			if (textBox1.Text == "")
			{
				label1.BackColor = Color.Red;
				isFull = false;
			}
			else label1.BackColor = Color.White;

			Regex regexp = new Regex(@"^[0-9]+([\,\.]{0,1}[0-9]+)?$");
			if (!regexp.IsMatch(textBox5.Text)) {
				label6.BackColor = Color.Red;
				isFull = false;
			}
			else label6.BackColor = Color.White;
			
			if (numericUpDown1.Value == 0)
			{
				label9.BackColor = Color.Red;
				isFull = false;
			}
			else label9.BackColor = Color.White;

			Regex regexp2 = new Regex(@"^[а-яА-Я]+( [а-яА-Я]+)?(\-[а-яА-Я]+)?$");
			string input = textBox2.Text.Trim();
			string Country="";
			if (regexp2.IsMatch(input))
			{
				label2.BackColor = Color.White;
				if (input.IndexOf("-") != -1)
				{
					Country = input.Substring(0, 1).ToUpper() + input.Substring(1, input.IndexOf("-")).ToLower() +
						input.Substring(input.IndexOf("-") + 1, 1).ToUpper() + input.Substring(input.IndexOf("-") + 2).ToLower();
				}
				else
				{
					Country = input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower();
				}
			}
			else if (input != "")
			{
				label2.BackColor = Color.Red;
				isFull = false;
			}

			string input2 = textBox3.Text.Trim();
			string City = "";
			if (regexp2.IsMatch(input2))
			{
				label3.BackColor = Color.White;
				if (input2.IndexOf("-") != -1)
				{
					City = input2.Substring(0, 1).ToUpper() + input2.Substring(1, input2.IndexOf("-")).ToLower() +
						input2.Substring(input2.IndexOf("-") + 1, 1).ToUpper() + input2.Substring(input2.IndexOf("-") + 2).ToLower();
				}
				else if (input2.IndexOf(" ") != -1)
				{
					City = input2.Substring(0, 1).ToUpper() + input2.Substring(1, input2.IndexOf(" ")).ToLower() +
						   input2.Substring(input2.IndexOf(" ") + 1, 1).ToUpper() + input2.Substring(input2.IndexOf(" ") + 2).ToLower();
				}
				else {
					City = input2.Substring(0, 1).ToUpper() + input2.Substring(1).ToLower();
				}
			}
			else if (input2!="")
			{
				label3.BackColor = Color.Red;
				isFull = false;
			}

			if (isFull)
			{
				percents = Transform(textBox5.Text);
				Bank bankToAdd = new Bank(textBox1.Text.Trim(), Country, City, textBox4.Text.Trim(), comboBox1.Text, percents,
					Convert.ToInt32(numericUpDown1.Value), checkBox1.Checked, checkBox2.Checked, radioButton1.Checked);
				inputBase.Add(bankToAdd);
				string[] line = bankToAdd.ToString().Split('/');
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

		private void Adding_Editing_Load(object sender, EventArgs e)
		{
			inputBase = Bank.ReadBase("dataBase.txt");
			for (int i = 0; i < inputBase.Count(); i++)  {
				string[] line = inputBase[i].ToString().Split('/');
				line = Bank.ConvertData(line);
				dataGridView1.Rows.Add(line);
			}
			dataGridView1.ClearSelection();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null) {
				inputBase.RemoveAt(dataGridView1.CurrentRow.Index);
				dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
			}
			else MessageBox.Show("Для удаления выберите строку с банком");
		}

		private void Adding_Editing_FormClosed(object sender, FormClosedEventArgs e)
		{
			StreamWriter output = new StreamWriter("dataBase.txt");
			for (int i = 0; i < inputBase.Count(); i++)
			{
				output.WriteLine(inputBase[i]);
			}
			output.Close();
		}

	}
}
