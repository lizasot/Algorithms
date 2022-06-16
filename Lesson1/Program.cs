using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        /// <summary>
        /// Ввод пользователем произвольного числа и вычисление его простоты
        /// </summary>
        static void Task1()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            int d = 0,
                i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }
            return;
        }

        /// <summary>
        /// Алгоритм из задачи
        /// </summary>
        /// <param name="inputArray">Массив N чисел</param>
        /// <returns></returns>
        static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) //О(f(n))
            {
                for (int j = 0; j < inputArray.Length; j++) //О(g(n))
                {
                    for (int k = 0; k < inputArray.Length; k++) //О(k(n))
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
            //O(f(n) * g(n) * k(n))
            //O(n^3)
            return sum;
        }

        static void Task2()
        {
            Console.WriteLine("Ответ: О(n^3)");
        }

        /// <summary>
        /// Вычисление числа Фибоначчи для индекса n
        /// </summary>
        /// <param name="n">Индекс числа Фибоначчи</param>
        /// <returns>Возвращает найденное число Фибоначчи</returns>
        static int Fi(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == -1)
                return 1;
            if (n > 0)
                return Fi(n - 1) + Fi(n - 2);
            else
                return Fi(n + 2) - Fi(n + 1);
        }
        static void Task3()
        {
            Console.Write("Введите целое число n, для которого будет вычислена последовательность чисел Фибоначчи: ");
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Строка введена неверно, повторите снова.");
            }

            Console.WriteLine("Fi: " + Fi(n));
        }

        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                int choice = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[1]");
                Console.ResetColor();
                Console.WriteLine(" Алгоритм вычисления простоты числа");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[2]");
                Console.ResetColor();
                Console.WriteLine(" Вывод результата подсчёта сложности функции");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[3]");
                Console.ResetColor();
                Console.WriteLine(" Вычислить число Фибоначчи для индекса n и вывести его");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[0]");
                Console.ResetColor();
                Console.WriteLine(" Выход из программы");

                Console.WriteLine("Введите номер задачи, которую хотите просмотреть:");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 0:
                        Console.WriteLine("Выход из программы ...");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Получено некорректное значение. Повторите ввод снова.");
                        break;

                }
                Console.WriteLine();
                Console.ReadKey(true);
            }
        }
    }
}