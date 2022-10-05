﻿using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 1; i <= count; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (string name in names)
                Console.WriteLine(name);
        }
    }
}
