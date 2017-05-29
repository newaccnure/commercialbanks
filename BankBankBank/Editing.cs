using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BankBankBank
{
    public partial class Editing : Form
    {
        Bank EditingBank;
        int RowIndex;
        DataGridView Spreadsheet;

        public Editing(Bank editingBank,int rowIndex,DataGridView spreadsheet)
        {
            InitializeComponent();
            Spreadsheet = spreadsheet;
            EditingBank = editingBank;
            RowIndex = rowIndex;
            Namebox.Text = editingBank.Name;
            CountryBox.Text = editingBank.Country;
            CityBox.Text = editingBank.City;
            StreetBox.Text = editingBank.Address;
            ControlFormBox.SelectedItem = editingBank.ControlForm;
            PosToAddbox.Checked = editingBank.PosToAdd;
            Percentbox.Text = editingBank.Percent.ToString();
            PosToGetbox.Checked = editingBank.PosToGet;
            AddingPercrb.Checked = editingBank.AddingPerc;
            OnCardAddingBox.Checked = !editingBank.AddingPerc;
            Termbox.Value = editingBank.Term;
        }

        public static double Transform(string input)//Преобразование строки в тип double
        {
            double result;
            if (input.IndexOf('.') != -1)
            {
                input = input.Replace('.', ',');
            }
            result = Convert.ToDouble(input);
            return result;
        }

        private void Accept(object sender, EventArgs e)//Проверка ввода данных и внесение изменений
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
            if (!regexp.IsMatch(Percentbox.Text))
            {
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
            try
            {
                Country = Bank.TryConvertToCountry(CountryBox.Text);
                CountryLabel.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
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
                EditingBank = new Bank(Namebox.Text.Trim(), Country, City, StreetBox.Text.Trim(), 
                    ControlFormBox.Text, percents, Convert.ToInt32(Termbox.Value), 
                    PosToAddbox.Checked, PosToGetbox.Checked, AddingPercrb.Checked);
                string[] line = EditingBank.ToString().Split('#');
                line = Bank.ConvertData(line);
                Spreadsheet.Rows.RemoveAt(RowIndex);
                Spreadsheet.Rows.Add(line);
                Dispose();
            }
            else
            {
                MessageBox.Show("Убедитесь в правильности ввода данных");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Namebox_TextChanged(object sender, EventArgs e)
        {
            while (Namebox.Text.Contains('#'))
            {
                Namebox.Text = Namebox.Text.Remove(Namebox.Text.IndexOf('#'), 1);
            }
        }
    }
}
