using AllTryParses;

namespace Lab1Task2
{
    internal class Program
    {
        public static void PrintStars(int value)
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int amountStrings = TP.IntTryParse();
            Console.WriteLine();
            for(int i = 1; i <= amountStrings; i++)
            {
                PrintStars(i);
            }
        }
    }
}