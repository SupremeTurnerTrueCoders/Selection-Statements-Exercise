using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number from 1-10");

            var r = new Random();
            var favNumber = r.Next(1, 10);

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is to low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is to High");
            }
            else
            {
                Console.WriteLine($"You guessed it!");
            }
            Console.WriteLine("what is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject!");
                    break;

                case "Science":
                    Console.WriteLine("Science is a tough subject!");
                    break;

                case "English":
                    Console.WriteLine("English is a tough subject!");
                    break;

                case "Social Studies":
                    Console.WriteLine("History is a tough subject!");
                    break;

                case "Gym":
                    Console.WriteLine("Gym is a tough subject!");
                    break;

                default:
                    Console.WriteLine("Math is a tough subject!");
                    break;

            }
        }
    }
}


