using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIREA_FIRST_LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstPositiveLastNegative();

            void FirstPositiveLastNegative()
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
        }

        
    }
}
