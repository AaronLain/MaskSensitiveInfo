using System;
using System.Collections.Generic;


namespace MaskSensitiveInfo
{
    class Program
    {
        static void Mask(string input)
        {
            string temp1 = input[^4..^0];  // get the last four letters of the input and save them
            List<string> temp2 = new List<string>();
            int len = input.Length - 4;  // set the length to be four less than the original input 

            for (int i = 0; i < len; i++) // creates an array of asterisks that will be added to the final four letters 
            {
                temp2.Add("*"); 
            }

            string temp3 = string.Join("", temp2.ToArray()); // converts List<string> to string
            string output = String.Concat(temp3, temp1); // adds the two strings (asterisks first) to create the output

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
