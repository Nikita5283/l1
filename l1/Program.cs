using System;

namespace l1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1_obj = new Class1();

            //Вызовы методов
            //1.1 
            Console.Write("Введите вещественное число: ");
            double fr_num = Convert.ToDouble(Console.ReadLine());
            int res_fraction = Convert.ToInt32(class1_obj.Fraction(fr_num));
            Console.WriteLine("Целая часть числа: " + res_fraction);

            //1.3
            Console.Write("Введите цифру: ");
            char ch = Convert.ToChar(Console.ReadLine());
            int res_char_to_num = Convert.ToInt32(class1_obj.CharToNum(ch));
            Console.WriteLine("Цифра в int формате: " + res_char_to_num);

            //1.5
            Console.Write("Введите целое число: ");
            int num2d = Convert.ToInt32(Console.ReadLine());
            bool res_is2digits = Convert.ToBoolean(class1_obj.is2Digits(num2d));
            if (res_is2digits)
            {
                Console.WriteLine("Число двузначное");
            }
            else
            {
                Console.WriteLine("Число не двузначное");
            }

            //1.7
            Console.Write("Введите границу диапазона(целое число): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую границу диапазона(целое число): ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число для проверки вхождения в диапазон: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool res_range = Convert.ToBoolean(class1_obj.isInRange(a, b, num));
            if (res_range)
            {
                Console.WriteLine("Число входит в заданный диапазон");
            }
            else
            {
                Console.WriteLine("Число не входит в заданный диапазон");
            }

            //1.9
            Console.Write("Введите первое целое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье целое число: ");
            int z = Convert.ToInt32(Console.ReadLine());

            bool res_equal = Convert.ToBoolean(class1_obj.isInRange(x, y, z));
            if (res_equal)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
                Console.WriteLine("Числа не равны");
            }

            //2.1
            Console.Write("Введите делимое(целое число): ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите делитель(целое число): ");
            int divider = Convert.ToInt32(Console.ReadLine());

            int res_safe_div = Convert.ToInt32(class1_obj.safeDiv(dividend, divider));
            if (res_safe_div == 0)
            {
                Console.WriteLine(res_safe_div);
            }
            else
            {
                Console.WriteLine("Частное: " + res_safe_div);
            }

            //2.3
            Console.Write("Введите целое число для проверки на делимость на 3 и на 5: ");
            int num35 = Convert.ToInt32(Console.ReadLine());

            bool res_35 = Convert.ToBoolean(class1_obj.is35(num35));
            if (res_35)
            {
                Console.WriteLine("Число " + num35 + " делится или на 3 или на 5");
            }
            else
            {
                Console.WriteLine("Число " + num35 + " делится на 3 и на 5 одновременно");
            }

            //2.5
            Console.Write("Введите первое целое число для выявления максимального из 3 чисел: ");
            int num_max1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число для выявления максимального из 3 чисел: ");
            int num_max2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье целое число для выявления максимального из 3 чисел: ");
            int num_max3 = Convert.ToInt32(Console.ReadLine());

            int res_max3 = Convert.ToInt32(class1_obj.max3(num_max1, num_max2, num_max3));
            Console.WriteLine(res_max3);

            //2.7
            Console.Write("Введите первое целое число для вычисления суммы: ");
            int num_sum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число для вычисления суммы: ");
            int num_sum2 = Convert.ToInt32(Console.ReadLine());

            int res_sum2 = Convert.ToInt32(class1_obj.sum2(num_sum1, num_sum2));
            Console.WriteLine("Результат: " + res_sum2);

            //2.9
            Console.Write("Введите номер дня недели, где 1 - это понедельник, а 7 – воскресенье: ");
            int day_num = Convert.ToInt32(Console.ReadLine());

            string day_week = Convert.ToString(class1_obj.day(day_num));
            Console.WriteLine(day_week);

            //3.1
            Console.Write("Введите целое число до которого нужно вывести числа от нуля: ");
            int num_listnums = Convert.ToInt32(Console.ReadLine());

            string listnums = Convert.ToString(class1_obj.listNums(num_listnums));
            Console.WriteLine(listnums);

            //3.3
            Console.Write("Введите целое число до которого нужно вывести все четные числа: ");
            int num_even = Convert.ToInt32(Console.ReadLine());

            string res_even = Convert.ToString(class1_obj.chet(num_even));
            Console.WriteLine(res_even);

            //3.5
            Console.Write("Введите целое число для подсчета в нем знаков: ");
            long num_len = Convert.ToInt64(Console.ReadLine());

            int res_lennum = Convert.ToInt32(class1_obj.numLen(num_len));
            Console.WriteLine(res_lennum);

            //3.7
            Console.Write("Введите целое число n для вывода квадрата из '*' размером nxn: ");
            int size_square = Convert.ToInt32(Console.ReadLine());

            class1_obj.square(size_square);

            //3.9
            Console.Write("Введите целое число n для вывода треугольника из '*', прижатого к правой стороне экрана, размером nxn: ");
            int size_triangle = Convert.ToInt32(Console.ReadLine());

            class1_obj.rightTriangle(size_triangle);
        }






    }


}