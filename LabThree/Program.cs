using System;

namespace LabThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "y";

            Console.Write("What is your name? ");
            string Name = Console.ReadLine();

            Console.WriteLine($"Hello {Name}");

            while (option == "y")
            {
                Console.Write("Can you give me a whole number between 1 and 100? ");
                string NumberS = Console.ReadLine();

                //Validate the inputes are numbers using TryParse.
                int NumberParse;

                bool NumberBool = int.TryParse(NumberS, out NumberParse);
                if (NumberParse > 100 || NumberParse < 0)
                {
                    Console.WriteLine("Your number was not between 1 and 100.");
                }
                else
                {

                

                    if (NumberBool == true)
                        {
                            if ((NumberParse % 2) == 0)
                            {
                                if (NumberParse > 60)
                                {
                                    Console.WriteLine($"{NumberParse} odd");
                                }
                                else if ((NumberParse >= 26) && (NumberParse <= 60))
                                {
                                    Console.WriteLine("Even");
                                }
                                else if ((NumberParse >= 2) && (NumberParse <= 25))
                                {
                                    Console.WriteLine("Even and less than 25");
                                }
                            }
                            else
                            {
                                if (NumberParse > 60)
                                {
                                    Console.WriteLine($"{NumberParse} Odd");
                                }
                                else
                                {
                                    Console.WriteLine("Odd");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Adam, you did not enter a number.");
                        }
                        Console.WriteLine("Would you like to continue? (y/n)");
                        option = Console.ReadLine();
                }
            }
        }
    }
}
