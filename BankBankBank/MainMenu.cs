using System;
using System.Windows.Forms;

namespace BankBankBank
{
	public partial class MainMenu : Form
	{
        private string pathToBase;
		public MainMenu(string path)
		{
			InitializeComponent();
            pathToBase = path;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Search search = new Search(pathToBase);
			Hide();
			search.ShowDialog();
			Dispose();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Adding_Deleting_Editing add_ed = new Adding_Deleting_Editing(pathToBase);
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
