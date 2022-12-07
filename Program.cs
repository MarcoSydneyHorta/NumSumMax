using System;

namespace NumSumMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers separated by space: "); // 24 34 2 10 15 40
            string[] numbers = Console.ReadLine().Split(" ");
            Console.Write("Enter the max number: "); // Number greater than or equal to the sum of two numbers
            int maxNumber = int.Parse(Console.ReadLine());
            int tam = numbers.Length;
            int[] intNumbers = Array.ConvertAll(numbers, st => int.Parse(st));
            int max = 0;
            int maxt = 0;
            int[] calcMem = new int[2]; 

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    if (intNumbers[i] + intNumbers[j] <= max || i != j)
                    {
                        maxt = intNumbers[i] + intNumbers[j];
                        if (maxt > max && maxt <= maxNumber)
                        {
                            calcMem[0] = intNumbers[i];
                            calcMem[1] = intNumbers[j];
                            max = maxt;
                        }
                        if (max > maxNumber) break;
                    }
                }
            }
            if (max != 0)
            {
                Console.Write("The maximun number is: " + max + " resulted by the numbers " + calcMem[0] + " and " + calcMem[1]);
            }
            else
            {
                Console.Write("There is no maximum number");
            }

        }
    }
}
