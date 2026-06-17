namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* პირველი დავალება
            Console.WriteLine("Enter number");

            string numStr = Console.ReadLine();

            bool isValid = int.TryParse(numStr, out int num);

            if (isValid)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} * {i} = {num * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            */

            /* მეორე დავალება
            Console.WriteLine("Enter height");

            string heightStr = Console.ReadLine();

            bool isValid = int.TryParse(heightStr, out int height);

            if (isValid)
            {
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            */

            /* მესამე დავალება 
            Console.WriteLine("Enter number");

            string numStr = Console.ReadLine();

            bool isValid = int.TryParse(numStr, out int num);

            if (isValid)
            {
                int sum = 0;

                for (int i = 2; i <= num; i += 2)
                {
                    sum += i;
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            */

            /* მეოთხე დავალება 
            Random rand = new Random();

            int secretNumber = rand.Next(1, 101);

            int guess = 0;

            while (guess != secretNumber)
            {
                Console.WriteLine("guess the number");

                string guessStr = Console.ReadLine();

                bool isValid = int.TryParse(guessStr, out guess);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low");
                }
            }

            Console.WriteLine("congratulations You guessed it!");
            */
        }
    }
}
