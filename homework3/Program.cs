namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* პირველი დავალება
            Console.WriteLine("enter username");
            string username = Console.ReadLine();


            Console.WriteLine("enter password");
            string password = Console.ReadLine();

            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("welcome");
            }
            else
            {
                Console.WriteLine("access denied");
            */

            /* მეორე დავალება
            Console.WriteLine("Enter first number");
            string firstStr = Console.ReadLine();
            bool validFirst = int.TryParse(firstStr, out int first);

            Console.WriteLine("Enter operator (+ - * /)");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number");
            string secondStr = Console.ReadLine();
            bool validSecond = int.TryParse(secondStr, out int second);

            if (validFirst && validSecond)
            {
                switch (op)
                {
                    case "+":
                        Console.WriteLine(first + second);
                        break;


                    case "-":
                        Console.WriteLine(first - second);
                        break;

                    case "*":
                        Console.WriteLine(first * second);
                        break;

                    case "/":
                        Console.WriteLine(first / second);

                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            */

            /* მესამე დავალება
            Console.WriteLine("Enter age");


            string ageStr = Console.ReadLine();
            bool isValid = byte.TryParse(ageStr, out byte age);

            if (isValid && age <= 12)
            {
                Console.WriteLine("ბავშვი");
            }
            else if (isValid && age <= 19)
            {
                Console.WriteLine("თინეიჯერი");
            }
            else if (isValid && age <= 64)
            {
                Console.WriteLine("ზრდასრული");
            }
            else if (isValid)
            {
                Console.WriteLine("პენსიონერი");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            */
        }
        }
    }
