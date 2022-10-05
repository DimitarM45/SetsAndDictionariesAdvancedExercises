using System;
using System.Linq;
using System.Collections.Generic;

namespace SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] setLengths = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();

            for (int i = 1; i <= setLengths[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }

            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 1; i <= setLengths[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondSet.Add(number);
            }

            HashSet<int> intersectedSet = firstSet.Intersect(secondSet).ToHashSet();

            Console.WriteLine(string.Join(' ', intersectedSet));
        }
    }
}
