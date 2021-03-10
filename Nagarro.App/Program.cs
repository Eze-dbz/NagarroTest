using System;
using System.Collections.Generic;
using System.Linq;


namespace Nagarro.App
{
    class Program
    {
        static void Main(string[] args)
        {
            NagarroStringTest();
        }


        private static void NagarroStringTest()
        {
            try
            {
                string sentence = string.Empty;
                string response = string.Empty;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the sentence to parse:");
                    sentence = Console.ReadLine();
                    Console.WriteLine();
                    if (string.IsNullOrEmpty(sentence))
                    {
                        Console.WriteLine("Sentence should not be emtpy, enter any key to try again.");
                        Console.ReadKey();
                    }


                } while (string.IsNullOrEmpty(sentence));


                MyString myString = new MyString();

                string result = myString.CalculateString(sentence);

                Console.WriteLine($"Original sentence: {sentence }");
                Console.WriteLine();
                Console.WriteLine($"Result sentence: { result}");


                Console.WriteLine();
                Console.WriteLine("If you want to parse another sentence please enter Y or y, otherwise program will exit.");
                response = Console.ReadLine().ToLower();


                if (response == "y")
                    NagarroStringTest();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. \n \n" +
                    $"Console message:  {ex.Message}  \n \n" +
                    $"please enter a key to try again.");
                Console.ReadKey();

                NagarroStringTest();
            }
                      
        }


    }
}
