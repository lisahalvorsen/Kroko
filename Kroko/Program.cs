namespace Kroko;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        
        do
        {
            Random rand = new Random();
            int randomNumber1 = rand.Next(1, 11);
            int randomNumber2 = rand.Next(1, 11);

            Console.WriteLine($"{randomNumber1} _ {randomNumber2}");
            Console.WriteLine("Type in '<', '>' or '='");
            string userInput = Console.ReadLine();

            if (userInput == "<" || userInput == ">" || userInput == "=")
            {
                if ((randomNumber1 > randomNumber2 && userInput == ">") ||
                    (randomNumber1 < randomNumber2 && userInput == "<") ||
                    (randomNumber1 == randomNumber2 && userInput == "="))
                {
                    points++;
                    Console.WriteLine("Good job! The answer was correct :D");
                    Console.WriteLine($"Your score: {points} points"); 
                }
                else
                {
                    points--;
                    Console.WriteLine("I'm sorry, that was the wrong answer. No points for you :(");
                    Console.WriteLine($"Your score: {points} points");
                }
            }
            else
            {
                break;
            }
        } while (true);
        Console.WriteLine("Game over!");
    }
}