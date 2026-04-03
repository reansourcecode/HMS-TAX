using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_TAX.UserDefined
{
    public static class InputValidator
    {
        public static void AllowDecimal(object sender, KeyPressEventArgs e, int decimalPlaces = 2, bool allowNegative = false)
        {
            if (!(sender is TextBox textBox)) return;

            char ch = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(ch)) return;

            // Allow digits
            if (char.IsDigit(ch)) return;

            // Allow negative sign
            if (allowNegative && ch == '-')
            {
                if (textBox.SelectionStart != 0 || textBox.Text.Contains("-"))
                    e.Handled = true;

                return;
            }

            // Allow decimal point
            if (ch == '.')
            {
                // Only one dot
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            // Block everything else
            e.Handled = true;

            // Limit decimal places
            if (textBox.Text.Contains("."))
            {
                int index = textBox.Text.IndexOf('.');
                string decimals = textBox.Text.Substring(index + 1);

                if (decimals.Length >= decimalPlaces && textBox.SelectionStart > index)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
