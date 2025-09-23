using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l1
{
    internal class Class1
    {
        //1.1 Отбрасывание дробной части числа
        public double Fraction(double x)
        {
            return Convert.ToInt32(x);
        }

        //1.3 Преобразование буквы в число
        public int CharToNum(char x)
        {
            int x_int = Convert.ToInt32(x);
            return x_int - 48;

        }

        //1.5 Проверка числа на двузначность
        public bool is2Digits(int x)
        {
            if (x > 9 && x < 100) {
                return true;
            } else
            {
                return false;   
            }
        }

        //1.7 Проверка числа на вхождение в заданный диапазон
        public bool isInRange(int a, int b, int num)
        {
            int border1 = Math.Min(a, b);
            int border2 = Math.Max(a, b);
            if (num >= a && num <= b)
            {
                return true;
            } else
            {
                return false;
            }
        }

        //1.9 Проверка на равенство 3 чисел
        public bool isEqual(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
