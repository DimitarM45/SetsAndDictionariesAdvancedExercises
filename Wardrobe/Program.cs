using System;
using System.Collections.Generic;

namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 1; i <= count; i++)
            {
                string[] clothesInfo = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = clothesInfo[0];

                if (!clothes.ContainsKey(color))
                    clothes.Add(color, new Dictionary<string, int>());

                for (int j = 1; j < clothesInfo.Length; j++)
                {
                    string item = clothesInfo[j];

                    if (!clothes[color].ContainsKey(item))
                        clothes[color].Add(item, 0);

                    clothes[color][item]++;
                }
            }

            string[] itemToFind = Console.ReadLine().Split();

            foreach (var (color, clothesList) in clothes)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var (item, occurrence) in clothesList)
                {
                    if (color == itemToFind[0] && item == itemToFind[1])
                            Console.WriteLine($"* {item} - {occurrence} (found!)");

                    else
                        Console.WriteLine($"* {item} - {occurrence}");
                }
            }
        }
    }
}
