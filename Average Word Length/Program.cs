using System;
using System.Collections.Generic;
using System.Collections;

namespace Average_Word_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your sentence or a paragraph: ");
            string input = Console.ReadLine();     //Input passed
            
           //Calulating the total letters in the paragraph
            float total = input.Replace(" ", "").Length;
            //Calculating the total words in the paragraph
            float G = input.Split(" ").GetLength(0);
            //Rounding off the result to the nearest integral value
            Console.WriteLine(MathF.Round(total/G));
            Console.ReadKey()
            
            

        }
    }
}
