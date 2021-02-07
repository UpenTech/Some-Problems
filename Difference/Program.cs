using System;
using System.Collections.Generic;
using System.Threading;



namespace Difference
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                //Pig Latin
                Console.Write("Enter your sentence: ");
                string Input = Console.ReadLine();
                List<string> Words = new List<string>(); //Creating a List to add the individual words
                int i = 0;
                string res = "" ;
                 //Pickinfg out individual Words
                do
                {
                    Words.Add(Input.Remove(Input.IndexOf(" ")));
                    Input = Input.Substring(Input.IndexOf(" ") + 1);
                    i++;
                    
                } while (Input.Contains(" "));
                Words.Add(Input);

                //Reengineering to sentences from the words 
                for (int j = 0; j < Words.Count; j++)
                {
                    Words[j] = Words[j].Substring(1) + Words[j][0] + "ay";
                    res = res + " " + Words[j];              
                }
                Console.WriteLine(res.Substring(1));
                Console.ReadKey();
                
            }//Catching Exceptions (if any)
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            //Git testing ... Ridiculous comment
        
        }
       
    }    
}


