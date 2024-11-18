
namespace Assignment_3_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to character counter. Please input your text");
            string inputString = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What character do you want to count");
            char charToCount = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int characterCount = CountCharacterOccurences(inputString, charToCount);

            Console.WriteLine($"The character {charToCount} appears {characterCount}");
        }

        static int CountCharacterOccurences(string input, char character)
        {
            int count = 0;

            foreach (char c in input)
            {

                if (c == character)

                {
                    count++;
                }

            }

            return count;

        }

    }
}
