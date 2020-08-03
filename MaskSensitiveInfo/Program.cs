using System;
using System.Collections.Generic;
using System.Linq;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Mask(string input)
        {
            string temp1 = input[^4..^0];
            List<string> temp2 = new List<string>();
            int len = input.Length - 4;
            for (int i = 0; i < len; i++)
            {
                temp2.Add("*");
            }
            string temp3 = string.Join("", temp2.ToArray());
            string output = String.Concat(temp3, temp1);
            Console.WriteLine($"{output}");
        }
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Give me a secret to hide:");
                input = Console.ReadLine();
                Mask(input);

            } while (input != "exit" && input != "");
        }
    }
}
