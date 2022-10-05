using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> uniqueElements = new HashSet<string>();

            for (int i = 1; i <= count; i++)
            {
                string[] elements = Console.ReadLine().Split();

                foreach (string element in elements)
                    uniqueElements.Add(element);
            }

            Console.WriteLine(string.Join(' ', uniqueElements.OrderBy(x => x)));
        }
    }
}
