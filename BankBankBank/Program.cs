using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace BankBankBank
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainMenu());
		}
	}
	public class NumericTextBox : TextBox
	{
		bool allowSpace = false;
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			string keyInput = e.KeyChar.ToString();

			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar!=',')
			{
				e.Handled = true;
			}
			else if (Text.Length > 4)
			{
				Text = "0";
				e.Handled = true;
			}
		}
		protected override void OnLeave(EventArgs e)
		{
			base.OnLeave(e);
			if (Text.Length == 0)
			{
				Text = "0";
			}
		}
		public int IntValue
		{
			get
			{
				return Int32.Parse(this.Text);
			}
		}
		public decimal DecimalValue
		{
			get
			{
				return Decimal.Parse(this.Text);
			}
		}
		public bool AllowSpace
		{
			set
			{
				this.allowSpace = value;
			}

			get
			{
				return this.allowSpace;
			}
		}
	}

	public class Bank
	{
		public string Name;
		public string Country;
		public string City;
		public string Address;
		public string ControlForm;
		public double Percent;
		public int Term;
		public bool PosToAdd;
		public bool PosToGet;
		public bool AddingPerc;
		public Bank() { }
		public Bank(string name, string country, string city, string address, string control,
			double perc, int term, bool pos, bool posToGet, bool addingPerc)
		{
			Name = name;
			Country = country;
			City = city;
			Address = address;
			ControlForm = control;
			Percent = perc;
			Term = term;
			PosToAdd = pos;
			PosToGet = posToGet;
			AddingPerc = addingPerc;
		}

		public static List<Bank> ReadBase(string path)
		{
			List<Bank> result = new List<Bank>();
			string[] line = File.ReadAllLines(path);
			for (int i = 0; i < line.Length; i++)
			{
				string[] input = line[i].Split('/');
				result.Add( new Bank(input[0], input[1], input[2], input[3], input[4], Convert.ToDouble(input[5]),
					Convert.ToInt32(input[6]), Convert.ToBoolean(input[7]),Convert.ToBoolean(input[8]), Convert.ToBoolean(input[9])));
			}
			return result;
		}

		public static void AddBank(Bank bankToAdd) {
			StreamWriter output = File.AppendText("dataBase.txt");
			output.WriteLine(bankToAdd);
			output.Close();
		}

		public override string ToString()
		{
			return String.Format("{0}/{1}/{2}/{3}/{4}/{5}/{6}/{7}/{8}/{9}", Name, Country, City,
				Address, ControlForm, Percent, Term, PosToAdd, PosToGet, AddingPerc);
		}
		public static string ConvertBoolData(string data) {
			if (data == "True")
			{
				return "Есть";
			}
			else return "Нет";
		}//Преобразование boolean в строку
		public static string[] ConvertData(string[] data) {
			data[7] = ConvertBoolData(data[7]);
			data[8] = ConvertBoolData(data[8]);
			if (data[9] == "True")
			{
				data[9] = "На текущий счет";
			}
			else data[9] = "На карту";
			return data;
		}//Преобразование данных
		public bool isSuitable(string control, string country, bool pos) {
			return ((ControlForm == control || control == "Не имеет значения" || control == "")
							&& (Country == country || country == "Не имеет значения" || country == "")
							&& (PosToAdd == pos));
		}//Проверка данных банка при поиске
		public static string TryConvertToCountry(string input)
		{
			input = input.Trim();
			while (input.Contains("  "))
			{
				input = input.Replace("  ", " ");
			}
			Regex checkCountry = new Regex((@"^[а-яА-Я]+(\s?\-?\s?[а-яА-Я]+){0,2}$"));
			if (checkCountry.IsMatch(input))
			{
				char[] letters = input.ToCharArray();
				letters[0] = Char.ToUpper(letters[0]);
				for (int i = 1; i < letters.Length; i++)
				{
					if (letters[i - 1] == ' ' || letters[i - 1] == '-')
					{
						letters[i] = Char.ToUpper(letters[i]);
					}
					else letters[i] = Char.ToLower(letters[i]);
				}
				string result2 = new string(letters);
				return result2;
			}
			else throw new ArgumentException();
		}//Преобразование строки в страну
	}
}
