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

        //2.1 Безопасное деление
        public double safeDiv(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            } else
            {
                return x / y;
            }
        }

        //2.3 35
        public bool is35(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                return false;
            } else {
                return true;
            }
        }

        //2.5 Тройной максимум
        public int max3(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                return x;
            }
            else if (y > x && y > z) {
                return y;
            } else
            {
                return z;
            }
        }

        //2.7 Двойная сумма
        public int sum2(int x, int y)
        {
            int sum = x + y;
            if (sum >= 10 && sum <= 19)
            {
                return 20;
            } else
            {
                return sum;
            }
        }

        //2.9 День недели
        public String day(int x)
        {
            switch (x)
            {
                case 1: return "Понедельник"; break;
                case 2: return "Вторник"; break;
                case 3: return "Среда"; break;
                case 4: return "Четверг"; break;
                case 5: return "Пятница"; break;
                case 6: return "Суббота"; break;
                case 7: return "Воскресенье"; break;
                default: return "Это не день недели"; break;
            }
        }

        //3.1 Числа подряд
        public String listNums(int x)
        {
            String nums = "";
            for (int i = 0; i <= x; i++)
            {
                nums += i + " ";
            }
        }
    }
}
