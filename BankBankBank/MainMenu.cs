using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankBankBank
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
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
			Adding_Editing add_ed = new Adding_Editing();
			Hide();
			add_ed.ShowDialog();
			Dispose();
		}
	}
}
