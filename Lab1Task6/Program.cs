using AllTryParses;

namespace Lab1Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону треугольника:");
            double firstSide = TP.DoubleTryParse();
            Console.WriteLine("Введите вторую сторону треугольника:");
            double secondSide = TP.DoubleTryParse();
            Console.WriteLine("Введите трутью сторону треугольника:");
            double thirdSide = TP.DoubleTryParse();
            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
            {
                Console.WriteLine("Треугольник не существует");
                return;
            }
            double p = (firstSide + secondSide + thirdSide) / 2;
            double S = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            Console.WriteLine("Площать треугольника = {0}", S);
        }
    }
}