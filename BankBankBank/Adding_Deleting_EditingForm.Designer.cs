namespace BankBankBank
{
	partial class Adding_Deleting_EditingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adding_Deleting_EditingForm));
            this.MainMenubutton = new System.Windows.Forms.Button();
            this.Addingbutton = new System.Windows.Forms.Button();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.ControlFormBox = new System.Windows.Forms.ComboBox();
            this.ControlFormLabel = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.PosToAddbox = new System.Windows.Forms.CheckBox();
            this.PosToAddLabel = new System.Windows.Forms.Label();
            this.Termbox = new System.Windows.Forms.NumericUpDown();
            this.TermLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.PosToGetLabel = new System.Windows.Forms.Label();
            this.PosToGetbox = new System.Windows.Forms.CheckBox();
            this.AddingPercLabel = new System.Windows.Forms.Label();
            this.AddingPercrb = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Percentbox = new BankBankBank.NumericTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CountryBox = new BankBankBank.MyTextBox();
            this.CityBox = new BankBankBank.MyTextBox();
            this.StreetBox = new BankBankBank.MyTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Termbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenubutton
            // 
            this.MainMenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenubutton.Location = new System.Drawing.Point(884, 614);
            this.MainMenubutton.Name = "MainMenubutton";
            this.MainMenubutton.Size = new System.Drawing.Size(221, 76);
            this.MainMenubutton.TabIndex = 13;
            this.MainMenubutton.Text = "Главное меню";
            this.MainMenubutton.UseVisualStyleBackColor = true;
            this.MainMenubutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addingbutton
            // 
            this.Addingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addingbutton.Location = new System.Drawing.Point(130, 614);
            this.Addingbutton.Name = "Addingbutton";
            this.Addingbutton.Size = new System.Drawing.Size(221, 76);
            this.Addingbutton.TabIndex = 11;
            this.Addingbutton.Text = "Добавить новый банк";
            this.toolTip1.SetToolTip(this.Addingbutton, "Заполните поля с информацией\r\nдля добавления банка в список банков.");
            this.Addingbutton.UseVisualStyleBackColor = true;
            this.Addingbutton.Click += new System.EventHandler(this.Addingbutton_Click);
            // 
            // Namebox
            // 
            this.Namebox.Location = new System.Drawing.Point(28, 78);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(134, 22);
            this.Namebox.TabIndex = 0;
            this.Namebox.TextChanged += new System.EventHandler(this.Namebox_TextChanged);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namelabel.Location = new System.Drawing.Point(28, 43);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(140, 20);
            this.Namelabel.TabIndex = 4;
            this.Namelabel.Text = "*Наименование";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(219, 43);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(71, 20);
            this.CountryLabel.TabIndex = 6;
            this.CountryLabel.Text = "Страна";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(381, 43);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(61, 20);
            this.CityLabel.TabIndex = 7;
            this.CityLabel.Text = "Город";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetLabel.Location = new System.Drawing.Point(540, 43);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(60, 20);
            this.StreetLabel.TabIndex = 10;
            this.StreetLabel.Text = "Улица";
            // 
            // ControlFormBox
            // 
            this.ControlFormBox.FormattingEnabled = true;
            this.ControlFormBox.Items.AddRange(new object[] {
            "Акционерная",
            "Кооперативная",
            "Государственная",
            "Муниципальная",
            "Межгосударственная",
            "Неизвестно"});
            this.ControlFormBox.Location = new System.Drawing.Point(671, 76);
            this.ControlFormBox.Name = "ControlFormBox";
            this.ControlFormBox.Size = new System.Drawing.Size(182, 24);
            this.ControlFormBox.TabIndex = 4;
            this.ControlFormBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // ControlFormLabel
            // 
            this.ControlFormLabel.AutoSize = true;
            this.ControlFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlFormLabel.Location = new System.Drawing.Point(667, 43);
            this.ControlFormLabel.Name = "ControlFormLabel";
            this.ControlFormLabel.Size = new System.Drawing.Size(199, 20);
            this.ControlFormLabel.TabIndex = 12;
            this.ControlFormLabel.Text = "Форма собственности";
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentLabel.Location = new System.Drawing.Point(12, 122);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(190, 40);
            this.PercentLabel.TabIndex = 13;
            this.PercentLabel.Text = "*Процентная ставка, \r\n         годовых";
            // 
            // PosToAddbox
            // 
            this.PosToAddbox.AutoSize = true;
            this.PosToAddbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToAddbox.Location = new System.Drawing.Point(884, 76);
            this.PosToAddbox.Name = "PosToAddbox";
            this.PosToAddbox.Size = new System.Drawing.Size(72, 24);
            this.PosToAddbox.TabIndex = 5;
            this.PosToAddbox.Text = "Есть";
            this.PosToAddbox.UseVisualStyleBackColor = true;
            // 
            // PosToAddLabel
            // 
            this.PosToAddLabel.AutoSize = true;
            this.PosToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToAddLabel.Location = new System.Drawing.Point(880, 43);
            this.PosToAddLabel.Name = "PosToAddLabel";
            this.PosToAddLabel.Size = new System.Drawing.Size(228, 20);
            this.PosToAddLabel.TabIndex = 18;
            this.PosToAddLabel.Text = "Возможность пополнения";
            // 
            // Termbox
            // 
            this.Termbox.Location = new System.Drawing.Point(198, 170);
            this.Termbox.Name = "Termbox";
            this.Termbox.Size = new System.Drawing.Size(120, 22);
            this.Termbox.TabIndex = 7;
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermLabel.Location = new System.Drawing.Point(219, 131);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(56, 20);
            this.TermLabel.TabIndex = 20;
            this.TermLabel.Text = "*Срок";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column7,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(28, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 361);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Наименование";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Страна";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Город";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Адрес";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Форма собственности";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ставка, годовых";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Срок";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Возможность пополнения";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 90;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Возможность частичного снятия";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Начисление процентов";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebutton.Location = new System.Drawing.Point(494, 614);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(252, 76);
            this.Deletebutton.TabIndex = 12;
            this.Deletebutton.Text = "Удалить выбранный банк";
            this.toolTip1.SetToolTip(this.Deletebutton, "Для удаления выберите одну из ячеек\r\nбанка, который хотите удалить.\r\n");
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // PosToGetLabel
            // 
            this.PosToGetLabel.AutoSize = true;
            this.PosToGetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToGetLabel.Location = new System.Drawing.Point(338, 122);
            this.PosToGetLabel.Name = "PosToGetLabel";
            this.PosToGetLabel.Size = new System.Drawing.Size(170, 40);
            this.PosToGetLabel.TabIndex = 23;
            this.PosToGetLabel.Text = "Возможность \r\nчастичного снятия";
            // 
            // PosToGetbox
            // 
            this.PosToGetbox.AutoSize = true;
            this.PosToGetbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToGetbox.Location = new System.Drawing.Point(342, 168);
            this.PosToGetbox.Name = "PosToGetbox";
            this.PosToGetbox.Size = new System.Drawing.Size(72, 24);
            this.PosToGetbox.TabIndex = 8;
            this.PosToGetbox.Text = "Есть";
            this.PosToGetbox.UseVisualStyleBackColor = true;
            // 
            // AddingPercLabel
            // 
            this.AddingPercLabel.AutoSize = true;
            this.AddingPercLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddingPercLabel.Location = new System.Drawing.Point(540, 120);
            this.AddingPercLabel.Name = "AddingPercLabel";
            this.AddingPercLabel.Size = new System.Drawing.Size(206, 20);
            this.AddingPercLabel.TabIndex = 25;
            this.AddingPercLabel.Text = "Начисление процентов";
            // 
            // AddingPercrb
            // 
            this.AddingPercrb.AutoSize = true;
            this.AddingPercrb.Checked = true;
            this.AddingPercrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddingPercrb.Location = new System.Drawing.Point(544, 143);
            this.AddingPercrb.Name = "AddingPercrb";
            this.AddingPercrb.Size = new System.Drawing.Size(170, 24);
            this.AddingPercrb.TabIndex = 9;
            this.AddingPercrb.TabStop = true;
            this.AddingPercrb.Text = "на текущий счет";
            this.AddingPercrb.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(544, 171);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "на карту";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Percentbox
            // 
            this.Percentbox.AllowSpace = false;
            this.Percentbox.Location = new System.Drawing.Point(32, 168);
            this.Percentbox.Name = "Percentbox";
            this.Percentbox.Size = new System.Drawing.Size(130, 22);
            this.Percentbox.TabIndex = 6;
            this.Percentbox.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankBankBank.Properties.Resources.Help;
            this.pictureBox1.Location = new System.Drawing.Point(1144, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 47);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Для редактирования, дважды нажмите на банк в списке. ");
            // 
            // CountryBox
            // 
            this.CountryBox.AllowSpace = false;
            this.CountryBox.Location = new System.Drawing.Point(198, 78);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(120, 22);
            this.CountryBox.TabIndex = 1;
            this.CountryBox.Text = "Неизвестно";
            // 
            // CityBox
            // 
            this.CityBox.AllowSpace = false;
            this.CityBox.Location = new System.Drawing.Point(342, 78);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(138, 22);
            this.CityBox.TabIndex = 2;
            this.CityBox.Text = "Неизвестно";
            // 
            // StreetBox
            // 
            this.StreetBox.AllowSpace = false;
            this.StreetBox.Location = new System.Drawing.Point(518, 78);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(106, 22);
            this.StreetBox.TabIndex = 3;
            this.StreetBox.Text = "Неизвестно";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenItem,
            this.SaveItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenItem
            // 
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.Size = new System.Drawing.Size(79, 24);
            this.OpenItem.Text = "Открыть";
            this.OpenItem.Click += new System.EventHandler(this.OpenItem_Click);
            // 
            // SaveItem
            // 
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.Size = new System.Drawing.Size(95, 24);
            this.SaveItem.Text = "Сохранить";
            this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // Adding_Deleting_EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1240, 719);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.Percentbox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.AddingPercrb);
            this.Controls.Add(this.AddingPercLabel);
            this.Controls.Add(this.PosToGetbox);
            this.Controls.Add(this.PosToGetLabel);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TermLabel);
            this.Controls.Add(this.Termbox);
            this.Controls.Add(this.PosToAddLabel);
            this.Controls.Add(this.PosToAddbox);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.ControlFormLabel);
            this.Controls.Add(this.ControlFormBox);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.Addingbutton);
            this.Controls.Add(this.MainMenubutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1258, 766);
            this.MinimumSize = new System.Drawing.Size(1258, 766);
            this.Name = "Adding_Deleting_EditingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение банков";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Adding_Editing_FormClosed);
            this.Load += new System.EventHandler(this.Adding_Editing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Termbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button MainMenubutton;
		private System.Windows.Forms.Button Addingbutton;
		private System.Windows.Forms.TextBox Namebox;
		private System.Windows.Forms.Label Namelabel;
		private System.Windows.Forms.Label CountryLabel;
		private System.Windows.Forms.Label CityLabel;
		private System.Windows.Forms.Label StreetLabel;
		private System.Windows.Forms.ComboBox ControlFormBox;
		private System.Windows.Forms.Label ControlFormLabel;
		private System.Windows.Forms.Label PercentLabel;
		private System.Windows.Forms.CheckBox PosToAddbox;
		private System.Windows.Forms.Label PosToAddLabel;
		private System.Windows.Forms.NumericUpDown Termbox;
		private System.Windows.Forms.Label TermLabel;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.Label PosToGetLabel;
		private System.Windows.Forms.CheckBox PosToGetbox;
		private System.Windows.Forms.Label AddingPercLabel;
		private System.Windows.Forms.RadioButton AddingPercrb;
		private System.Windows.Forms.RadioButton radioButton2;
		private NumericTextBox Percentbox;
		private System.Windows.Forms.ToolTip toolTip1;
		private MyTextBox CountryBox;
		private MyTextBox CityBox;
		private MyTextBox StreetBox;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}