namespace BankBankBank
{
	partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SumNumericBox = new BankBankBank.NumericTextBox();
            this.SumTrackBar = new System.Windows.Forms.TrackBar();
            this.SumLabel = new System.Windows.Forms.Label();
            this.ControlFormbox = new System.Windows.Forms.ComboBox();
            this.ControlFormLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.TermLabel = new System.Windows.Forms.Label();
            this.Termbox = new System.Windows.Forms.NumericUpDown();
            this.PosToAddLabel = new System.Windows.Forms.Label();
            this.PosToAddbox = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnToBaseButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SumTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Termbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuButton.Location = new System.Drawing.Point(820, 589);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(221, 76);
            this.MainMenuButton.TabIndex = 9;
            this.MainMenuButton.Text = "Главное меню";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(175, 588);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(221, 76);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Поиск";
            this.toolTip1.SetToolTip(this.SearchButton, "Введите срок, сумму и выберите критерии, \r\nпо которым будет происходить поиск.\r\n");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SumNumericBox
            // 
            this.SumNumericBox.AllowSpace = false;
            this.SumNumericBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SumNumericBox.Location = new System.Drawing.Point(17, 153);
            this.SumNumericBox.Name = "SumNumericBox";
            this.SumNumericBox.Size = new System.Drawing.Size(89, 22);
            this.SumNumericBox.TabIndex = 1;
            this.SumNumericBox.Text = "0";
            this.SumNumericBox.TextChanged += new System.EventHandler(this.numericTextBox1_TextChanged);
            // 
            // SumTrackBar
            // 
            this.SumTrackBar.AllowDrop = true;
            this.SumTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SumTrackBar.Location = new System.Drawing.Point(12, 91);
            this.SumTrackBar.Maximum = 10000;
            this.SumTrackBar.Name = "SumTrackBar";
            this.SumTrackBar.Size = new System.Drawing.Size(140, 56);
            this.SumTrackBar.TabIndex = 0;
            this.SumTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SumTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // SumLabel
            // 
            this.SumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLabel.Location = new System.Drawing.Point(13, 39);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(63, 20);
            this.SumLabel.TabIndex = 4;
            this.SumLabel.Text = "Сумма";
            // 
            // ControlFormbox
            // 
            this.ControlFormbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ControlFormbox.FormattingEnabled = true;
            this.ControlFormbox.Items.AddRange(new object[] {
            "Акционерная",
            "Кооперативная",
            "Государственная",
            "Муниципальная",
            "Межгосударственная",
            "Не имеет значения"});
            this.ControlFormbox.Location = new System.Drawing.Point(359, 90);
            this.ControlFormbox.Name = "ControlFormbox";
            this.ControlFormbox.Size = new System.Drawing.Size(196, 24);
            this.ControlFormbox.TabIndex = 3;
            this.ControlFormbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.ControlFormbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // ControlFormLabel
            // 
            this.ControlFormLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ControlFormLabel.AutoSize = true;
            this.ControlFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlFormLabel.Location = new System.Drawing.Point(355, 39);
            this.ControlFormLabel.Name = "ControlFormLabel";
            this.ControlFormLabel.Size = new System.Drawing.Size(199, 20);
            this.ControlFormLabel.TabIndex = 6;
            this.ControlFormLabel.Text = "Форма собственности";
            // 
            // CountryLabel
            // 
            this.CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(641, 39);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(71, 20);
            this.CountryLabel.TabIndex = 7;
            this.CountryLabel.Text = "Страна\r\n";
            // 
            // CountryBox
            // 
            this.CountryBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Items.AddRange(new object[] {
            "Не имеет значения"});
            this.CountryBox.Location = new System.Drawing.Point(572, 89);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(212, 24);
            this.CountryBox.TabIndex = 4;
            this.CountryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox2_KeyDown);
            this.CountryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // TermLabel
            // 
            this.TermLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TermLabel.AutoSize = true;
            this.TermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermLabel.Location = new System.Drawing.Point(171, 39);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(152, 20);
            this.TermLabel.TabIndex = 9;
            this.TermLabel.Text = "*Срок(в месяцах)";
            // 
            // Termbox
            // 
            this.Termbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Termbox.Location = new System.Drawing.Point(187, 91);
            this.Termbox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Termbox.Name = "Termbox";
            this.Termbox.Size = new System.Drawing.Size(120, 22);
            this.Termbox.TabIndex = 2;
            // 
            // PosToAddLabel
            // 
            this.PosToAddLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PosToAddLabel.AutoSize = true;
            this.PosToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToAddLabel.Location = new System.Drawing.Point(796, 39);
            this.PosToAddLabel.Name = "PosToAddLabel";
            this.PosToAddLabel.Size = new System.Drawing.Size(228, 20);
            this.PosToAddLabel.TabIndex = 12;
            this.PosToAddLabel.Text = "Возможность пополнения";
            // 
            // PosToAddbox
            // 
            this.PosToAddbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PosToAddbox.AutoSize = true;
            this.PosToAddbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToAddbox.Location = new System.Drawing.Point(800, 88);
            this.PosToAddbox.Name = "PosToAddbox";
            this.PosToAddbox.Size = new System.Drawing.Size(72, 24);
            this.PosToAddbox.TabIndex = 5;
            this.PosToAddbox.Text = "Есть";
            this.PosToAddbox.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column7,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(17, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1190, 361);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Город";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Форма собственности";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Ставка, годовых";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Срок";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Возможность пополнения";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 90;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 24;
            // 
            // ReturnToBaseButton
            // 
            this.ReturnToBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToBaseButton.Location = new System.Drawing.Point(502, 589);
            this.ReturnToBaseButton.Name = "ReturnToBaseButton";
            this.ReturnToBaseButton.Size = new System.Drawing.Size(210, 75);
            this.ReturnToBaseButton.TabIndex = 8;
            this.ReturnToBaseButton.Text = "Вернуться к списку банков";
            this.toolTip1.SetToolTip(this.ReturnToBaseButton, "Нажмите, чтобы перейти \r\nк изначальному списку банков");
            this.ReturnToBaseButton.UseVisualStyleBackColor = true;
            this.ReturnToBaseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.asdToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.asdToolStripMenuItem.Text = "Открыть";
            this.asdToolStripMenuItem.Click += new System.EventHandler(this.asdToolStripMenuItem_Click);
            // 
            // asdToolStripMenuItem1
            // 
            this.asdToolStripMenuItem1.Name = "asdToolStripMenuItem1";
            this.asdToolStripMenuItem1.Size = new System.Drawing.Size(95, 24);
            this.asdToolStripMenuItem1.Text = "Сохранить";
            this.asdToolStripMenuItem1.Click += new System.EventHandler(this.asdToolStripMenuItem1_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.ReturnToBaseButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.PosToAddbox);
            this.Controls.Add(this.PosToAddLabel);
            this.Controls.Add(this.Termbox);
            this.Controls.Add(this.TermLabel);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.ControlFormLabel);
            this.Controls.Add(this.ControlFormbox);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.SumTrackBar);
            this.Controls.Add(this.SumNumericBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск банка";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SumTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Termbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button MainMenuButton;
		private System.Windows.Forms.Button SearchButton;
		private NumericTextBox SumNumericBox;
		private System.Windows.Forms.TrackBar SumTrackBar;
		private System.Windows.Forms.Label SumLabel;
		private System.Windows.Forms.ComboBox ControlFormbox;
		private System.Windows.Forms.Label ControlFormLabel;
		private System.Windows.Forms.Label CountryLabel;
		private System.Windows.Forms.ComboBox CountryBox;
		private System.Windows.Forms.Label TermLabel;
		private System.Windows.Forms.NumericUpDown Termbox;
		private System.Windows.Forms.Label PosToAddLabel;
		private System.Windows.Forms.CheckBox PosToAddbox;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button ReturnToBaseButton;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}