using AllTryParses;

namespace Lab1Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну прямоугольника:");
            double firstSide = TP.DoubleTryParse();
            Console.WriteLine("Введите ширину прямоугольника:");
            double secondSide = TP.DoubleTryParse();
            double S = firstSide * secondSide;
            Console.WriteLine("Площадь прямоугольника = {0}", S);
        }
    }
}