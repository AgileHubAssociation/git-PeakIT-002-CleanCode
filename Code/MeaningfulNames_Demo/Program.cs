using System;
using System.Collections.Generic;

namespace MeaningfulNames_Demo
{
    class Program
    {
        public static double ComputeAverage(List<int> numbers)
        {
            double sum = 0;
            int count = 0;
            foreach (int number in numbers)
            {
                sum += number;
                count++;
            }
            if (count == 0)
            {
                return 0;
            }
            else
            {
                return sum / count;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ComputeAverage(new List<int>()));
            Console.WriteLine(ComputeAverage(new List<int> { 1, 2, 3, 4, 5 }));
            Console.WriteLine(ComputeAverage(new List<int> { 10, -2, -13, 4, 9 }));
        }
    }
}
