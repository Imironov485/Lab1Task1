using AllTryParses;

namespace Lab1Task3
{
    internal class Program
    {
        public static void PrintStars(int value, int spaces)
        {
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < value; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Сколько будет строк?:");
            int amountStrings = TP.IntTryParse();
            int amountSpaces = amountStrings - 1;
            int value = 1;
            for(int i = 1; i <= amountStrings; i++)
            {
                PrintStars(value, amountSpaces);
                value += 2;
                amountSpaces--;
            }
        }
    }
}