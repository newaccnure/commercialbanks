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
using System.Runtime.Serialization.Formatters.Binary;

namespace BankBankBank
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
			MyTextBox m = new MyTextBox();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Search search = new Search();
			Hide();
			search.ShowDialog();
			Dispose();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Adding_Deleting_Editing add_ed = new Adding_Deleting_Editing();
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
