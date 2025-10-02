using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l1
{
    internal class Class1
    {
        //1.1 Отбрасывание целой части числа
        public double Fraction(double x)
        {
            return x - Convert.ToInt32(x);
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

        //2.1 Модуль числа
        public int abs(int x)
        {
            if (x < 0)
            {
                return -1 * x;
            }
            else
            {
                return x;
            }
        }

        //2.3 35
        public bool is35(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                return false;
            } 
            else if (x % 3 == 0 || x % 5 == 0) 
            {
                return true;
            } else
            {
                return false;
            }
        }

        //2.5 Тройной максимум
        public int max3(int x, int y, int z)
        {
            if (x >= y && x >= z)
            {
                return x;
            }
            else if (y >= x && y >= z) {
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
            return nums;
        }

        //3.3 Четные числа
        public String chet(int x)
        {
            String even_nums = "";
            for (int i = 0; i <= x; i += 2)
            {
                even_nums += i + " ";
            }
            return even_nums;
        }

        //3.5 Длина числа
        public int numLen(long x)
        {
            int len = 0;

            while (x > 0)
            {
                x = Convert.ToInt64(x / 10);
                len += 1;
            }
            return len;
        }

        //3.7 Квадрат
        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                String line_stars = "";
                for (int j = 0; j < x; j++)
                {
                    line_stars += "*";
                }
                Console.WriteLine(line_stars);
            }
        }

        //3.9 Правый треугольник
        public void rightTriangle(int x)
        {
            for (int i = 0; i < x; i ++)
            {
                int spaces_num  = x - i;
                String line_stars = " ";
                for (int j = 0; j < spaces_num; j++) { line_stars += " "; }
                for (int k = 0; k < i; k ++) { line_stars += "*"; }
                Console.WriteLine(line_stars);
            }
        }

        //4.1 Поиск первого значения
        public int findFirst(int[] arr, int x)
        {
            int ind = 0;
            foreach (int num in arr) {
                if (num == x) {
                    return ind;
                    break;
                };
                ind++;
            }
            return -1;
        }

        //4.3 Поиск максимального по модулю
        public int maxAbs(int[] arr)
        {
            int max = 0;
            foreach (int num in arr)
            {
                if (Math.Abs(num) > Math.Abs(max))
                {
                    max = num;
                }
            }
            return max;
        }

        //4.5 Добавление массива в массив
        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] result = new int[arr.Length + ins.Length];

            int k = 0;

            // копируем часть arr до позиции
            for (int i = 0; i < pos; i++)
            {
                result[k++] = arr[i];
            }

            // вставляем ins
            for (int i = 0; i < ins.Length; i++)
            {
                result[k++] = ins[i];
            }

            // добавляем остаток arr
            for (int i = pos; i < arr.Length; i++)
            {
                result[k++] = arr[i];
            }

            return result;
        }


        //4.7 Реверс массива
        public int[] reverseBack(int[] arr)
        {
            int len_arr = arr.Length;
            int[] reverse_arr = new int[len_arr];
            int j = 0;
            for (int i = len_arr-1; i >= 0; i--)
            {
                reverse_arr[j++] = arr[i];
            }
            return reverse_arr;
        }

        //4.9 Индексы всех вхождений
        public int[] findAll(int[] arr, int x)
        {
            int[] inds = new int[arr.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    inds[j++] = i;
                }
            }
            return inds;
        }
    }
}
