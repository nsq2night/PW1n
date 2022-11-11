using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_arsen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                float a;
                float b;
                Console.WriteLine("Введите номер операции");
                int muberofoperation = int.Parse(Console.ReadLine());

                if (muberofoperation == 1)
                {
                    Console.Write("1 число:");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("2 число:");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Сумма 1 числа и 2 числа = {a + b}");

                }
                if (muberofoperation == 2)
                {
                    Console.Write("1 число:");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("2 число:");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Вычитание 1 числа из 2 числа = {a + b}");


                }
                if (muberofoperation == 3)
                {
                    Console.Write("1 число:");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("2 число:");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Умножение 2 чисел = {a * b}");


                }
                if (muberofoperation == 4)
                {
                    Console.Write("1 число:");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("2 число:");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Деление 1 числа на 2 число = {a / b}");


                }
                if (muberofoperation == 5)
                {
                    Console.Write("1 число:");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("2 число:");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Возведение 1 числа в степень = {Math.Pow(a, b)}");


                }
                if (muberofoperation == 6)
                {
                    Console.Write("1 число:");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("2 число:");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine($" 1 число ставим в кв. корень = {Math.Sqrt(a)}");

                }
                if (muberofoperation == 7)
                {
                    Console.Write("1 число:");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("2 число:");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Находим 1% от 1 числа = {a / 100}");


                }
                if (muberofoperation == 8)
                {
                    Console.Write("1 число:");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("2 число:");
                    b = float.Parse(Console.ReadLine());
                    Console.Write($"Находим факториал числа");
                    int an = 1;
                    float n = a;
                    for (int i = 1; i <= n; i++)
                        an *= i;
                    Console.WriteLine($"Результат {an}");
                }
                if (muberofoperation == 9)
                {
                    Console.Write("Работа закончена");
                    done = true;
                }
            }
        }
    }
}
