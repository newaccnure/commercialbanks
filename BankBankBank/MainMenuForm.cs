using System;
using System.Windows.Forms;

namespace BankBankBank
{
	public partial class MainMenuForm : Form
	{
        private string pathToBase;
		public MainMenuForm(string path)
		{
			InitializeComponent();
            pathToBase = path;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SearchForm search = new SearchForm(pathToBase);
			Hide();
			search.ShowDialog();
			Dispose();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Adding_Deleting_EditingForm add_ed = new Adding_Deleting_EditingForm(pathToBase);
			Hide();
			add_ed.ShowDialog();
			Dispose();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Наше приложение лучшее в мире.\nЭтого достаточно, чтобы им пользоваться");
		}
	}
}
