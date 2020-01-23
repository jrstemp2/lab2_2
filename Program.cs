using System;

namespace stempowskiLab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's work on squares and cubes!!");
            Console.WriteLine();
            string goAgain;

            do
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine();
                int num = int.Parse(input);

                while (num <= 0)
                {
                    Console.WriteLine("That is not a valid number.");
                    Console.Write("Please enter a number greater than or equal to 1: ");
                    input = Console.ReadLine();
                    num = int.Parse(input);
                }
                Console.WriteLine("Numbers" + "\t\t" + "Squared" + "\t\t" + "Cubed");
                Console.WriteLine("======" + "\t\t" + "======" + "\t\t" + "======");
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(String.Format("{0, 5} {1, 15} {2, 15}", i, (i * i), (i * i * i)));
                }
                Console.Write("\nWould you like to continue? (Yes/No)");
                goAgain = Console.ReadLine();
            } while (goAgain == "yes" || goAgain == "Yes");

            Console.WriteLine("Thank you for your time. Please press enter to exit the program.");
            Console.ReadLine();
        }
    }
}