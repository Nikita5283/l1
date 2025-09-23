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
            if (res_is2digits) {
                Console.WriteLine("Число двузначное");
            } else
            {
                Console.WriteLine("Число не двузначное");
            }

            //1.7
            Console.Write("Введите границу диапазона: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую границу диапазона: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число для проверки вхождения в диапазон: ");
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
            if (res_range)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
                Console.WriteLine("Числа не равны");
            }

        }






    }


}