using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static string CowConter(int n)
        {
            //выделяем последнюю цифру и последние 2 цифры
            int lastDigit = n % 10;
            int last2Digit = n % 100;
            string result = "";
            string str;

            // определяем окончания для слова коров*

            if (((last2Digit >= 11) & (last2Digit <= 19)) || ((lastDigit >= 5) & (lastDigit <= 9)))
                result = "коров";
            else
                if (lastDigit == 1)
                result = "корова";
            else
                    if (lastDigit == 0)
                result = "коров";
            else
                         if ((lastDigit >= 2) & (lastDigit <= 4))
                result = "коровы";

            //присваеваем результату значение
            str = string.Format("{0} {1}", n, result);
            return str;
        }
    }
}
