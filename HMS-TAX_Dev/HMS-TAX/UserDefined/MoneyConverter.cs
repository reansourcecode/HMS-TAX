using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_TAX.UserDefined
{
    public static class MoneyConverter
    {
        public static string ToWords(decimal amount)
        {
            if (amount == 0)
                return "Zero Dollars";

            long dollars = (long)Math.Floor(amount);
            int cents = (int)((amount - dollars) * 100);

            string result = $"{NumberToWords(dollars)} Dollar{(dollars > 1 ? "s" : "")}";

            if (cents > 0)
            {
                result += $" and {NumberToWords(cents)} Cent{(cents > 1 ? "s" : "")}";
            }

            return result;
        }

        private static string NumberToWords(long number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "Minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += NumberToWords(number / 1000000000) + " Billion ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                string[] unitsMap = {
                "Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
                "Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen",
                "Eighteen","Nineteen"
            };

                string[] tensMap = {
                "Zero","Ten","Twenty","Thirty","Forty","Fifty","Sixty","Seventy","Eighty","Ninety"
            };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words.Trim();
        }
    }
}
