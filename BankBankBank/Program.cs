﻿using System;
using System.Windows.Forms;

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
			Application.Run(new MainMenuForm("dataBase.txt"));
		}
	}
}
