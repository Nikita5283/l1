using System;
using System.Security.Cryptography.X509Certificates;

namespace l1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1_obj = new Class1();

            //Вызовы методов
            ////1.1 
            //Console.WriteLine("1.1");
            //Console.Write("Введите вещественное число: ");
            //double fr_num = Convert.ToDouble(Console.ReadLine());
            //double res_fraction = Convert.ToDouble(class1_obj.Fraction(fr_num));
            //Console.WriteLine("Дробная часть числа: " + res_fraction);

            ////1.3
            //Console.WriteLine("1.3");
            //Console.Write("Введите цифру: ");
            //char ch = Convert.ToChar(Console.ReadLine());
            //int res_char_to_num = Convert.ToInt32(class1_obj.CharToNum(ch));
            //Console.WriteLine("Цифра в int формате: " + res_char_to_num);

            ////1.5
            //Console.WriteLine("1.5");
            //Console.Write("Введите целое число: ");
            //int num2d = Convert.ToInt32(Console.ReadLine());
            //bool res_is2digits = Convert.ToBoolean(class1_obj.is2Digits(num2d));
            //if (res_is2digits)
            //{
            //    Console.WriteLine("Число двузначное");
            //}
            //else
            //{
            //    Console.WriteLine("Число не двузначное");
            //}

            ////1.7
            //Console.WriteLine("1.7");
            //Console.Write("Введите границу диапазона(целое число): ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите вторую границу диапазона(целое число): ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите целое число для проверки вхождения в диапазон: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //bool res_range = Convert.ToBoolean(class1_obj.isInRange(a, b, num));
            //if (res_range)
            //{
            //    Console.WriteLine("Число входит в заданный диапазон");
            //}
            //else
            //{
            //    Console.WriteLine("Число не входит в заданный диапазон");
            //}

            ////1.9
            //Console.WriteLine("1.9");
            //Console.Write("Введите первое целое число: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите второе целое число: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите третье целое число: ");
            //int z = Convert.ToInt32(Console.ReadLine());

            //bool res_equal = Convert.ToBoolean(class1_obj.isEqual(x, y, z));
            //if (res_equal)
            //{
            //    Console.WriteLine("Числа равны");
            //}
            //else
            //{
            //    Console.WriteLine("Числа не равны");
            //}

            ////2.1
            //Console.WriteLine("2.1");
            //Console.Write("Введите целое число для получения его модуля: ");
            //int num_abs = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(class1_obj.abs(num_abs));

            //2.3
            Console.WriteLine("2.3");
            Console.Write("Введите целое число для проверки на делимость на 3 и на 5: ");
            int num35 = Convert.ToInt32(Console.ReadLine());

            bool res_35 = Convert.ToBoolean(class1_obj.is35(num35));
            Console.WriteLine(res_35);

            //2.5
            Console.WriteLine("2.5");
            Console.Write("Введите первое целое число для выявления максимального из 3 чисел: ");
            int num_max1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число для выявления максимального из 3 чисел: ");
            int num_max2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье целое число для выявления максимального из 3 чисел: ");
            int num_max3 = Convert.ToInt32(Console.ReadLine());

            int res_max3 = Convert.ToInt32(class1_obj.max3(num_max1, num_max2, num_max3));
            Console.WriteLine(res_max3);

            //2.7
            Console.WriteLine("2.7");
            Console.Write("Введите первое целое число для вычисления суммы: ");
            int num_sum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число для вычисления суммы: ");
            int num_sum2 = Convert.ToInt32(Console.ReadLine());

            int res_sum2 = Convert.ToInt32(class1_obj.sum2(num_sum1, num_sum2));
            Console.WriteLine("Результат: " + res_sum2);

            //2.9
            Console.WriteLine("2.9");
            Console.Write("Введите номер дня недели, где 1 - это понедельник, а 7 – воскресенье: ");
            int day_num = Convert.ToInt32(Console.ReadLine());

            string day_week = Convert.ToString(class1_obj.day(day_num));
            Console.WriteLine(day_week);

            //3.1
            Console.WriteLine("3.1");
            Console.Write("Введите целое число до которого нужно вывести числа от нуля: ");
            int num_listnums = Convert.ToInt32(Console.ReadLine());

            string listnums = Convert.ToString(class1_obj.listNums(num_listnums));
            Console.WriteLine(listnums);

            //3.3
            Console.WriteLine("3.3");
            Console.Write("Введите целое число до которого нужно вывести все четные числа: ");
            int num_even = Convert.ToInt32(Console.ReadLine());

            string res_even = Convert.ToString(class1_obj.chet(num_even));
            Console.WriteLine(res_even);

            //3.5
            Console.WriteLine("3.5");
            Console.Write("Введите целое число для подсчета в нем знаков: ");
            long num_len = Convert.ToInt64(Console.ReadLine());

            int res_lennum = Convert.ToInt32(class1_obj.numLen(num_len));
            Console.WriteLine(res_lennum);

            //3.7
            Console.WriteLine("3.7");
            Console.Write("Введите натуральное число n для вывода квадрата из '*' размером nxn: ");
            int size_square = Convert.ToInt32(Console.ReadLine());

            class1_obj.square(size_square);

            //3.9
            Console.WriteLine("3.9");
            Console.Write("Введите натуральное число n для вывода треугольника из '*', прижатого к правой стороне экрана, размером nxn: ");
            int size_triangle = Convert.ToInt32(Console.ReadLine());

            class1_obj.rightTriangle(size_triangle);

            //4.1
            Console.WriteLine("4.1");
            Console.WriteLine("Сгенерированный массив: ");

            int[] nums = new int[7];
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(100);
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Введите целое число для нахождения его индекса в сгенерированном массиве: ");
            int desired_num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(class1_obj.findFirst(nums, desired_num));

            //4.3
            Console.WriteLine("4.3");
            Console.WriteLine("Сгенерированный массив: ");

            int[] nums2 = new int[7];
            Random random2 = new Random();
            for (int i = 0; i < nums2.Length; i++)
            {
                nums2[i] = random2.Next(-10, 5);
                Console.Write(nums2[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Максимальное по модулю число в массиве: " + class1_obj.maxAbs(nums2));

            //4.5
            Console.WriteLine("4.5");
            Console.WriteLine("Массив arr: ");

            int[] arr = new int[7];
            Random random3 = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random3.Next(20);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Массив ins: ");

            int[] ins = new int[7];
            Random random4 = new Random();
            for (int i = 0; i < ins.Length; i++)
            {
                ins[i] = random4.Next(-10, 5);
                Console.Write(ins[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Введите индекс, для вставки элементов массива ins в массив arr: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            int[] ins_arr = class1_obj.add(arr, ins, pos);
            foreach (int n in ins_arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //4.7
            Console.WriteLine("4.7");
            Console.WriteLine("Сгенерированный массив: ");
            int[] nums3 = new int[7];
            Random random5 = new Random();
            for (int i = 0; i < nums3.Length; i++)
            {
                nums3[i] = random5.Next(-10, 5);
                Console.Write(nums3[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Перевернутый массив: ");
            int[] reverse_arr = class1_obj.reverseBack(nums3);
            foreach (int n in reverse_arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //4.9
            Console.WriteLine("4.9");
            Console.WriteLine("Сгенерированный массив: ");
            int[] nums4 = new int[20];
            Random random6 = new Random();
            for (int i = 0; i < nums4.Length; i++)
            {
                nums4[i] = random6.Next(20);
                Console.Write(nums4[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Введите целое число, чтобы узнать индексы его вхождения: ");
            int numm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Массив индексов вхождений введенного числа: ");
            int[] inds_arr = class1_obj.findAll(nums4, numm);
            foreach (int n2 in inds_arr)
            {
                Console.Write(n2 + " ");
            }
            Console.WriteLine();
        }






    }


}