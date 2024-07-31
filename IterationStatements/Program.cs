namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            var myNumber = -1001;

            do
            {
                myNumber++;

                numbers.Add(myNumber);

            } while (myNumber < 1000);

            while (myNumber < 1000)
            {
                myNumber++;

                numbers.Add(myNumber);
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //LukeWarm Section: Create methods below
            //Write a method that will print to the console all numbers 1000 through - 1000

            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            for (var z = 3; z <= 999; z += 3)
            {
                Console.WriteLine(z);
            }
            //Write a method to accept two integers as parameterss and check whether they are equal or not
            int one = 0;

            int two = 0;

            if (Equals(one, two))
            {
                Console.WriteLine("one and two are equal to eachother");
            }

            else
            {
                Console.WriteLine("one and two are not equal to eachother");
            }

            //Write a method to check whether a given number is even or odd
            Console.Write("Enter a number: ");

            int number3 = int.Parse(Console.ReadLine());

            if (number3 % 6 == 0)
            {
                Console.WriteLine($"{number3} is even");
            }

            else
            {
                Console.WriteLine($"{number3} is odd");
            }
            //Write a method to check whether a given number is positive or negative
            if (number3 > 0)
            {
                Console.WriteLine("The number is positive");
            }

            else if (number3 < 0)
            {
                Console.WriteLine("The number is negative");
            }

            else
            {
                Console.WriteLine("The number is 0");
            }
            //Write a method to read the age of a candidate and determine whether they can vote.
            //Hint: Use Parse or the safer TryParse() for an extra challenge
            //Parse()
            //TryParse()
            int age;

            Console.Write("Enter the age of the candidate:  ");

            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("Candidate is old enough to vote");
                }

                else
                {
                    Console.WriteLine("Candidate is not old enough to vote");
                }
            }
            //Heatin Up Section:
            //Write a method to check if an integer(from the user) is in the range -10 to 10
            Console.Write("Enter a number to see if it is in the range of -10 and 10:  ");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int parsedNumber))
            {
                if ((parsedNumber) < -10)
                {
                    Console.WriteLine("The number is not within range");
                }

                else if ((parsedNumber) > 10)
                {
                    Console.WriteLine("The number is not within range");
                }

                else
                {
                    Console.WriteLine("The number is within range");
                }
            }
            //Write a method to display the multiplication table(from 1 to 12) of a given integer
            Console.Write("Enter a number between 1 and 12:  ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The multiplication table is for {number}:");

            for (int a = 1; a <= 12; a++)
            {
                int result = number * a;

                Console.WriteLine($"\t{a} * {number} = {result}");
            }

            //Call the methods to test them in the Main method below
        }
    }
}
