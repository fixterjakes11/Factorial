using System;
using System.Numerics;
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Нажмите Enter для продолжения...\nИли другую,любую, кнопку для закрытия ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Print();
                }

                else
                {
                    break;
                }

            }
            
        }


        public static BigInteger Factorial(int n) 
        {
            var factorial = new BigInteger(1);  
            for (int i = 1; i <= n; i++)   // цикл для рассчета факториала
                factorial *= i;

            return factorial; // возвращает результат нахождения факториала
        }

        static void Print()
        {
            try
            {
                Console.WriteLine("Напишите число для нахождения факториала: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"факториал от числа {a}: {Factorial(a)}\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите число!!!");
            }
        }

    }
}
