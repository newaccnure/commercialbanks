using System;
using System.Windows.Forms;

namespace BankBankBank
{
    public class MyTextBox : TextBox
    {
        bool allowSpace = false;

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

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (Text == "Неизвестно")
            {
                Text = "";
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (Text == "")
            {
                Text = "Неизвестно";
            }
        }
    }
}
