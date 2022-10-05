using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbersByOccurrence = new Dictionary<int, int>();

            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbersByOccurrence.ContainsKey(number))
                    numbersByOccurrence.Add(number, 0);

                numbersByOccurrence[number]++;
            }

            foreach (var (number, occurrence) in numbersByOccurrence)
            {
                if (occurrence % 2 == 0)
                {
                    Console.WriteLine(number);

                    break;
                }
            }
        }
    }
}
