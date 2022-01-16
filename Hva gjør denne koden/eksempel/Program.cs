using System;

namespace eksempel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var range = 250;
            var counts = new int[range];
            int totalLetters = 0;
            string text = "something";

            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine(); string.Empty;
                foreach (var character in text.ToUpper())
                {
                    totalLetters++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + counts[i]);
                        var precentage = 100 * (double)counts[i] / totalLetters;
                        string output = character + " - " + precentage.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output); 
                    }
                }
            }
        }


    }
}
