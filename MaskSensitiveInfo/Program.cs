using System;
using System.Collections.Generic;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Mask(string input)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    temp.Add(input[i].ToString());
                }
                else if (i != 0)
                {
                    temp.Add("*");
                    
                }
            }
            string output = String.Join("", temp);
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
