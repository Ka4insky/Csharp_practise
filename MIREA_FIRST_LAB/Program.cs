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

            NinthTask();

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

                Console.WriteLine(counter + " строк");
                Console.ReadLine(); 
            }

            void SixthTask()
            {
                float average = 0;

                int counter = 0;

                Console.WriteLine("Введите последовательность целых чисел через пробел:");

                float[] arr = Console.ReadLine().Split(' ').
                    Select(x => float.Parse(x)).ToArray();

                foreach (float x in arr) 
                {
                    if (x > 9 & x < 100) 
                    {
                        average += x;
                        counter++;
                    }
                }

                Console.WriteLine("Кол-во чисел подходящих под условия:" + counter);

                if (counter != 0)
                {
                    Console.WriteLine("Среднее арифметическое " + average / counter);
                }
                else 
                {
                    Console.WriteLine(average);
                }

                Console.ReadLine();
            }

            void SeventhTask() 
            {
                String answer = "";

                Console.WriteLine("Введите длину строки для поиска:");

                int digit = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите последовательность строк через пробел:");

                string[] arr = Console.ReadLine().Split(' ').ToArray();

                foreach (string x in arr) 
                {
                    if (x.Length == digit & answer == "") 
                    {
                        answer = x;
                    }

                    if (x.Length == digit & answer != "") 
                    {
                        for (int i = 0; i < digit; i++) 
                        {
                            if (x[i] > answer[i])
                            {
                                answer = x;
                                break;
                            }
                            else if (x[i] < answer[i])
                            {
                                break;
                            }
                        }
                    }
                }

                Console.WriteLine(answer);
                Console.ReadLine();
            }

            void EighthTask() 
            {
                int sum = 0;

                Console.WriteLine("Введите последовательность строк через пробел:");

                string[] arr = Console.ReadLine().Split(' ').ToArray();

                foreach (string x in arr) 
                {
                    sum += x.Length;
                }

                Console.WriteLine("Сумма длинн строк = " + sum);
                Console.ReadLine();
            }

            void NinthTask() 
            {
                Console.WriteLine("Введите целое число:");

                int length = int.Parse(Console.ReadLine());

                bool FoundNumber = false;

                List<int> numbers = new List<int>();

                Console.WriteLine("Введите последовательность целых чисел через пробел:");

                int[] arr = Console.ReadLine().Split(' ').
                    Select(x => int.Parse(x)).ToArray();

                foreach (int x in arr) 
                {
                    if (x > length) FoundNumber = true;

                    if (FoundNumber & (x % 2 == 1) & (x > 0)) 
                    {
                        numbers.Add(x);
                    }

                    FoundNumber = false;
                }

               numbers.Reverse(); 

                foreach (int x in numbers) 
                {
                    Console.Write(x.ToString() + " ");
                }

                Console.ReadLine();
            }
        }

        
    }
}
