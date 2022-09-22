using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class HomeWork1
    {
        static void Main(string[] args)
        {
            Task8();

            Console.ReadLine();
        }

        // <summary>
        // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        //a = 5; b = 7 -> max = 7
        //a = 2 b = 10 -> max = 10
        //a = -9 b = -3 -> max = -3
        // </summary>
        static void Task2()
        {
            Console.WriteLine("введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("max=" + a);
            }
            else
            {
                Console.WriteLine("max=" + b);
            }
        }

        //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        //2, 3, 7 -> 7
        //44 5 78 -> 78
        //22 3 9 -> 22
        static void Task4()
        {
            Console.WriteLine("введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("max=" + a);
                }
                else
                {
                    Console.WriteLine("max=" + c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("max=" + b);
                }
                else
                {
                    Console.WriteLine("max=" + c);
                }
            }
        }

        //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        //4 -> да
        //-3 -> нет
        //7 -> нет
        static void Task6()
        {
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a % 2 == 0 ? "да" : "нет");
        }

        //Задача 8: Напишите программу, которая на вход принимает число(N), а на выходе показывает все чётные числа от 1 до N.
        //5 -> 2, 4
        //8 -> 2, 4, 6, 8
        static void Task8()
        {
            Console.WriteLine("введите число");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    Console.Write(i < N - 1 ? ", " : "");
                }
            }
        }

        static void Task8a()
        {
            Console.WriteLine("введите число");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= N; i = i + 2)
            {
                Console.Write(i);
                Console.Write(i < N - 1 ? ", " : "");
            }
        }
    }
}
