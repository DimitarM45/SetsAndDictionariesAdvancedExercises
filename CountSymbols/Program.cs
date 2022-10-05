using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> charsByOccurrence = new Dictionary<char, int>();

            foreach (char symbol in text)
            {
                if (!charsByOccurrence.ContainsKey(symbol))
                    charsByOccurrence.Add(symbol, 0);

                charsByOccurrence[symbol]++;
            }

            charsByOccurrence = charsByOccurrence.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var (symbol, occurrence) in charsByOccurrence)
                Console.WriteLine($"{symbol}: {occurrence} time/s");
        }
    }
}
