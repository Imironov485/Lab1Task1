using AllTryParses;

namespace Lab1task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите крайнее число");
            int endValue = TP.IntTryParse();
            int summ = 0;
            for (int i = 1; i < endValue; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summ += i;
                }
            }
            Console.WriteLine("Сумма всех чисел, кратных 3 или 5 и меньше чем {0} = {1}", endValue, summ);
        }
    }
}