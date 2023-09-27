using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIREA_FIRST_LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FifthTask();

            void FirstTask()
            {
                bool positive = false;
                int negative = 0;


                Console.WriteLine("Введите последовательность целых чисел через пробел:");
                int[] arr = Console.ReadLine().Split(' ').
                    Select(x => int.Parse(x)).ToArray();

                foreach (int x in arr)
                {
                    if (x > 0 & !positive)
                    {
                        Console.WriteLine(x);
                        positive = true;
                        continue;
                    }

                    if (x < 0) 
                    {
                        negative = x;
                    }
                }

                if (!positive) 
                {
                    Console.WriteLine("Положительных чисел нет :(");
                }

                if (negative == 0)
                {
                    Console.WriteLine("Отрицательных чисел нет :(");
                }
                else 
                {
                    Console.WriteLine(negative);
                }

                Console.ReadLine();
            }

            void SecondTask() 
            {
                int answer = 0;

                Console.WriteLine("Введите цифру:");

                int digit = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите последовательность целых чисел через пробел:");

                int[] arr = Console.ReadLine().Split(' ').
                    Select(x => int.Parse(x)).ToArray();

                foreach (int x in arr) 
                {
                    if (digit == x % 10 & x>0)
                    {
                        answer = x;
                        break;
                    }
                    
                }

                Console.WriteLine(answer);

                Console.ReadLine();
            }

            void ThirdTask() 
            {
                String answer = null;

                Console.WriteLine("Введите длину строки для поиска:");

                int digit = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите последовательность строк через пробел:");

                string[] arr = Console.ReadLine().Split(' ').ToArray();

                foreach (string x in arr) 
                {
                    if (x.Length == digit & Char.IsDigit(x[0])) 
                    {
                        answer = x;
                    }
                }

                Console.WriteLine(answer ?? "Not found");
                Console.ReadLine();
            }

            void FourthTask() 
            {
                int counter = 0;

                string answer = null;

                Console.WriteLine("Введите символ:");

                string symbol = Console.ReadLine();

                Console.WriteLine("Введите последовательность строк через пробел:");

                string[] arr = Console.ReadLine().Split(' ').ToArray();

                foreach (string x in arr) 
                {
                    if (x.EndsWith(symbol)) 
                    {
                        answer = x;
                        counter++;
                    }
                }

                switch (counter) 
                {
                    case 0: Console.WriteLine(""); break;

                    case 1: Console.WriteLine(answer); break;

                    default: Console.WriteLine("Error"); break;
                }
                Console.ReadLine();
            }

            void FifthTask()
            {
                int counter = 0;

                Console.WriteLine("Введите символ:");

                string symbol = Console.ReadLine();

                Console.WriteLine("Введите последовательность строк через пробел:");

                string[] arr = Console.ReadLine().Split(' ').ToArray();

                foreach (string x in arr) 
                {
                    if (x.EndsWith(symbol) & x.StartsWith(symbol) & x.Length >1) 
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);
                Console.ReadLine(); 
            }
        }

        
    }
}
