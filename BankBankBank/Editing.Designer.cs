namespace BankBankBank
{
    partial class Editing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editing));
            this.StreetBox = new BankBankBank.MyTextBox();
            this.CityBox = new BankBankBank.MyTextBox();
            this.CountryBox = new BankBankBank.MyTextBox();
            this.Percentbox = new BankBankBank.NumericTextBox();
            this.OnCardAddingBox = new System.Windows.Forms.RadioButton();
            this.AddingPercrb = new System.Windows.Forms.RadioButton();
            this.AddingPercLabel = new System.Windows.Forms.Label();
            this.PosToGetbox = new System.Windows.Forms.CheckBox();
            this.PosToGetLabel = new System.Windows.Forms.Label();
            this.TermLabel = new System.Windows.Forms.Label();
            this.Termbox = new System.Windows.Forms.NumericUpDown();
            this.PosToAddLabel = new System.Windows.Forms.Label();
            this.PosToAddbox = new System.Windows.Forms.CheckBox();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.ControlFormLabel = new System.Windows.Forms.Label();
            this.ControlFormBox = new System.Windows.Forms.ComboBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AcceptBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Termbox)).BeginInit();
            this.SuspendLayout();
            // 
            // StreetBox
            // 
            this.StreetBox.AllowSpace = false;
            this.StreetBox.Location = new System.Drawing.Point(696, 82);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(136, 22);
            this.StreetBox.TabIndex = 29;
            this.StreetBox.Text = "Неизвестно";
            // 
            // CityBox
            // 
            this.CityBox.AllowSpace = false;
            this.CityBox.Location = new System.Drawing.Point(474, 82);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(138, 22);
            this.CityBox.TabIndex = 28;
            this.CityBox.Text = "Неизвестно";
            // 
            // CountryBox
            // 
            this.CountryBox.AllowSpace = false;
            this.CountryBox.Location = new System.Drawing.Point(255, 82);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(120, 22);
            this.CountryBox.TabIndex = 27;
            this.CountryBox.Text = "Неизвестно";
            // 
            // Percentbox
            // 
            this.Percentbox.AllowSpace = false;
            this.Percentbox.Location = new System.Drawing.Point(571, 180);
            this.Percentbox.Name = "Percentbox";
            this.Percentbox.Size = new System.Drawing.Size(130, 22);
            this.Percentbox.TabIndex = 34;
            this.Percentbox.Text = "0";
            // 
            // OnCardAddingBox
            // 
            this.OnCardAddingBox.AutoSize = true;
            this.OnCardAddingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OnCardAddingBox.Location = new System.Drawing.Point(255, 292);
            this.OnCardAddingBox.Name = "OnCardAddingBox";
            this.OnCardAddingBox.Size = new System.Drawing.Size(102, 24);
            this.OnCardAddingBox.TabIndex = 40;
            this.OnCardAddingBox.Text = "на карту";
            this.OnCardAddingBox.UseVisualStyleBackColor = true;
            // 
            // AddingPercrb
            // 
            this.AddingPercrb.AutoSize = true;
            this.AddingPercrb.Checked = true;
            this.AddingPercrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddingPercrb.Location = new System.Drawing.Point(255, 262);
            this.AddingPercrb.Name = "AddingPercrb";
            this.AddingPercrb.Size = new System.Drawing.Size(170, 24);
            this.AddingPercrb.TabIndex = 38;
            this.AddingPercrb.TabStop = true;
            this.AddingPercrb.Text = "на текущий счет";
            this.AddingPercrb.UseVisualStyleBackColor = true;
            // 
            // AddingPercLabel
            // 
            this.AddingPercLabel.AutoSize = true;
            this.AddingPercLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddingPercLabel.Location = new System.Drawing.Point(251, 239);
            this.AddingPercLabel.Name = "AddingPercLabel";
            this.AddingPercLabel.Size = new System.Drawing.Size(206, 20);
            this.AddingPercLabel.TabIndex = 46;
            this.AddingPercLabel.Text = "Начисление процентов";
            // 
            // PosToGetbox
            // 
            this.PosToGetbox.AutoSize = true;
            this.PosToGetbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToGetbox.Location = new System.Drawing.Point(29, 292);
            this.PosToGetbox.Name = "PosToGetbox";
            this.PosToGetbox.Size = new System.Drawing.Size(72, 24);
            this.PosToGetbox.TabIndex = 37;
            this.PosToGetbox.Text = "Есть";
            this.PosToGetbox.UseVisualStyleBackColor = true;
            // 
            // PosToGetLabel
            // 
            this.PosToGetLabel.AutoSize = true;
            this.PosToGetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToGetLabel.Location = new System.Drawing.Point(25, 239);
            this.PosToGetLabel.Name = "PosToGetLabel";
            this.PosToGetLabel.Size = new System.Drawing.Size(170, 40);
            this.PosToGetLabel.TabIndex = 45;
            this.PosToGetLabel.Text = "Возможность \r\nчастичного снятия";
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TermLabel.Location = new System.Drawing.Point(567, 239);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(56, 20);
            this.TermLabel.TabIndex = 44;
            this.TermLabel.Text = "*Срок";
            // 
            // Termbox
            // 
            this.Termbox.Location = new System.Drawing.Point(571, 265);
            this.Termbox.Name = "Termbox";
            this.Termbox.Size = new System.Drawing.Size(120, 22);
            this.Termbox.TabIndex = 36;
            // 
            // PosToAddLabel
            // 
            this.PosToAddLabel.AutoSize = true;
            this.PosToAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToAddLabel.Location = new System.Drawing.Point(251, 134);
            this.PosToAddLabel.Name = "PosToAddLabel";
            this.PosToAddLabel.Size = new System.Drawing.Size(228, 20);
            this.PosToAddLabel.TabIndex = 43;
            this.PosToAddLabel.Text = "Возможность пополнения";
            // 
            // PosToAddbox
            // 
            this.PosToAddbox.AutoSize = true;
            this.PosToAddbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PosToAddbox.Location = new System.Drawing.Point(255, 180);
            this.PosToAddbox.Name = "PosToAddbox";
            this.PosToAddbox.Size = new System.Drawing.Size(72, 24);
            this.PosToAddbox.TabIndex = 32;
            this.PosToAddbox.Text = "Есть";
            this.PosToAddbox.UseVisualStyleBackColor = true;
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentLabel.Location = new System.Drawing.Point(567, 125);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(190, 40);
            this.PercentLabel.TabIndex = 42;
            this.PercentLabel.Text = "*Процентная ставка, \r\n         годовых";
            // 
            // ControlFormLabel
            // 
            this.ControlFormLabel.AutoSize = true;
            this.ControlFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlFormLabel.Location = new System.Drawing.Point(25, 134);
            this.ControlFormLabel.Name = "ControlFormLabel";
            this.ControlFormLabel.Size = new System.Drawing.Size(170, 20);
            this.ControlFormLabel.TabIndex = 41;
            this.ControlFormLabel.Text = "Форма управления";
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
            this.ControlFormBox.Location = new System.Drawing.Point(29, 178);
            this.ControlFormBox.Name = "ControlFormBox";
            this.ControlFormBox.Size = new System.Drawing.Size(182, 24);
            this.ControlFormBox.TabIndex = 30;
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetLabel.Location = new System.Drawing.Point(692, 37);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(60, 20);
            this.StreetLabel.TabIndex = 39;
            this.StreetLabel.Text = "Улица";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(470, 37);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(61, 20);
            this.CityLabel.TabIndex = 35;
            this.CityLabel.Text = "Город";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(251, 37);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(71, 20);
            this.CountryLabel.TabIndex = 33;
            this.CountryLabel.Text = "Страна";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namelabel.Location = new System.Drawing.Point(25, 37);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(140, 20);
            this.Namelabel.TabIndex = 31;
            this.Namelabel.Text = "*Наименование";
            // 
            // Namebox
            // 
            this.Namebox.Location = new System.Drawing.Point(29, 82);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(134, 22);
            this.Namebox.TabIndex = 26;
            this.Namebox.TextChanged += new System.EventHandler(this.Namebox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(571, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 72);
            this.button1.TabIndex = 47;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AcceptBox
            // 
            this.AcceptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptBox.Location = new System.Drawing.Point(187, 370);
            this.AcceptBox.Name = "AcceptBox";
            this.AcceptBox.Size = new System.Drawing.Size(188, 72);
            this.AcceptBox.TabIndex = 48;
            this.AcceptBox.Text = "Подтвердить";
            this.AcceptBox.UseVisualStyleBackColor = true;
            this.AcceptBox.Click += new System.EventHandler(this.Accept);
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(900, 493);
            this.Controls.Add(this.AcceptBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.Percentbox);
            this.Controls.Add(this.OnCardAddingBox);
            this.Controls.Add(this.AddingPercrb);
            this.Controls.Add(this.AddingPercLabel);
            this.Controls.Add(this.PosToGetbox);
            this.Controls.Add(this.PosToGetLabel);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(918, 540);
            this.MinimumSize = new System.Drawing.Size(918, 540);
            this.Name = "Editing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.Termbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox StreetBox;
        private MyTextBox CityBox;
        private MyTextBox CountryBox;
        private NumericTextBox Percentbox;
        private System.Windows.Forms.RadioButton OnCardAddingBox;
        private System.Windows.Forms.RadioButton AddingPercrb;
        private System.Windows.Forms.Label AddingPercLabel;
        private System.Windows.Forms.CheckBox PosToGetbox;
        private System.Windows.Forms.Label PosToGetLabel;
        private System.Windows.Forms.Label TermLabel;
        private System.Windows.Forms.NumericUpDown Termbox;
        private System.Windows.Forms.Label PosToAddLabel;
        private System.Windows.Forms.CheckBox PosToAddbox;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Label ControlFormLabel;
        private System.Windows.Forms.ComboBox ControlFormBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AcceptBox;
    }
}