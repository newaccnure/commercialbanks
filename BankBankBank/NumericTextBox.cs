using System;
using System.Windows.Forms;

namespace BankBankBank
{
    public class NumericTextBox : TextBox
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

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            string keyInput = e.KeyChar.ToString();

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (Text.Length > 5 && e.KeyChar != '\b')
            {
                Text = "1000000";
                e.Handled = true;
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (Text.Length == 0)
            {
                Text = "0";
            }
        }
    }
}
