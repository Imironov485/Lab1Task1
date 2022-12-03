using AllTryParses;

namespace Lab1task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            byte firstValue = TP.ByteTryParse();
            Console.WriteLine("Введите втрое число:");
            byte secondValue = TP.ByteTryParse();
            Console.WriteLine("" +
                "Побитовое И чисел {0} {1} - {2}\n" +
                "Побитовое ИЛИ чисел {0} {1} - {3}\n" +
                "побитовое исключающее ИЛИ чисел {0} {1} - {4}",
                firstValue, secondValue, firstValue & secondValue, firstValue | secondValue, firstValue ^ secondValue);
        }
    }
}