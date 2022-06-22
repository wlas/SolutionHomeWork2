using System;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");

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
            
            Console.WriteLine("\nЗадание 3:");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");

            Task3();

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

        #region Task2
        // Асимптотическую сложность функции составляет O(n^3)
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y;
                    }
                }

            }
            return sum;
        }
        #endregion

        #region Task3
        //Задание 3
        static void Task3()
        {
            Console.Write("Введите количество членов последовательности Фибоначчи: ");
            if(int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"\nРасчет чилсла {number} последовательности Фибоначчи с помощью цикла, равен: {FibonachiCycle(number)} \n");

                //Рассчет с помощью рекурсии
                //Массив для хранения рассчитанных чисел Фибоначчи
                ulong[] memory = new ulong[number + 1];
                memory[1] = 1;

                Console.WriteLine($"Расчет чилсла {number} последовательности Фибоначчи c помощью рекурсии, равен: {FibonachiRecursiya(number, memory)} \n");

                Console.WriteLine($"Вся последовательность чисел Фибоначчи до элемента №{number}\n");
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("{0,2:d} - {1}", i, memory[i]);
                }                    
            }
        }
        /// <summary>
        /// Расчет чилсла последовательности Фибоначчи в цикле
        /// </summary>
        /// <param name="n">Число для расчета</param>
        /// <returns>Возвращает число последовательности Фибоначчи</returns>
        private static ulong FibonachiCycle(int n)
        {

            ulong x1 = 1; //Рассчитываемый член последовательности
            ulong x0 = 1; //Предыдущий член последовательности

            for (int i = 2; i < n; i++)
            {
                x1 = x0 + x1;
                x0 = x1 - x0;
            }
            return x1;
        }
        /// <summary>
        /// Расчет чилсла последовательности Фибоначчи с помощью рекурсии
        /// Вычисление происходит по формуле: F(n) = F(n-1) + F(n-2)
        /// </summary>
        /// <param name="n">Число для расчета</param>
        /// <returns>Возвращает число последовательности Фибоначчи</returns>
        static ulong FibonachiRecursiya(int n)
        {
            if (n > 1)
                return (ulong)(FibonachiRecursiya(n - 1) + FibonachiRecursiya(n - 2));
            else
                return (ulong)n;
        }


        private static ulong FibonachiRecursiya(int n, ulong[] memory)
        {
            if (n <= 1) return (ulong)n;

            //Если в массиве памяти данный элемент уже вычислен, то вернем его, иначе пойдем по рекурсии
            if (memory[n] != 0)
                return memory[n];
            else
            {
                memory[n] = FibonachiRecursiya(n - 1, memory) + FibonachiRecursiya(n - 2, memory);
                return memory[n];
            }
        }
        #endregion
    }
}
