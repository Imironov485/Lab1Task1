using AllTryParses;

namespace Lab1Task4
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
            for (int j = 1; j <= amountStrings; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    PrintStars(value, amountSpaces);
                    value += 2;
                    amountSpaces--;
                }
                value = 1;
                amountSpaces = amountStrings - 1;
            }
        }
    }
}