using System;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            if(long.TryParse(Console.ReadLine(),out long n))
            {
                if (Task1(n))
                {
                    Console.WriteLine("Простое число.");
                }
                else
                {
                    Console.WriteLine("Не простое число.");
                }
            }

            Console.ReadKey(true);
        }
        #region Task1
        //Первое задание
        static bool Task1(long n)
        {
            int i = 2;
            int d = 0;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
