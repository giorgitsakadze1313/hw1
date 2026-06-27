namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* პირველი დავალება
            int[][] jagged =
                [
              [20,60],
              [50,60,70,80]
                ];

            foreach (var line in jagged)
            {
                int sum = 0;

                foreach (var item in line)
                {
                    sum += item;
                }

                Console.WriteLine(sum / line.Length);
            */

            /* მეორე დავალება
            Random random = new Random();

            int[] passcodes = new int[10];

            for (int i = 0; i < passcodes.Length; i++)
            {
                passcodes[i] = random.Next(1000, 9999);
            }

            Console.WriteLine("Enter passcode");
            string userInput = Console.ReadLine();

            bool isCorrect = false;

            foreach (var item in passcodes)
            {
                if (item.ToString() == userInput)
                {
                    isCorrect = true;
                }
            }

            Console.WriteLine(isCorrect ? "Correct" : "Wrong");
            */

            /* მესამე დავალება
            int[] numbers = { 10, 20, -30, 40, 50, -60, 70, 80, -90 };

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];

                if (numbers[i] > max)
                    max = numbers[i];
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            */

            /* მეოთხე დავალება
            string[] names = { "John", "George", "Alice" };

            foreach (var item in names)
            {
                foreach (var symbol in item)
                {
                    Console.WriteLine(symbol);
                }
            }
            */

        }
    }
    }

