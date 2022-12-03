namespace AllTryParses
{
    public static class TP
    {
        public static int IntTryParse()
        {
            int result = 0;
            bool tr = true;
            while (tr)
            {
                bool successful = int.TryParse(Console.ReadLine(), out result);
                if (!successful)
                {
                    Console.WriteLine("Введите число!\nПопробуйте снова:");
                }
                else
                {
                    if(result < 0)
                    {
                        Console.WriteLine("Вы ввели отрицательное значение, пожалуйста, введите положительное значение!");
                    }
                    else
                    {
                        tr = false;
                    }
                }
            }

            return result;
        }

        public static double DoubleTryParse()
        {
            double result = 0;
            bool tr = true;
            while (tr)
            {
                bool successful = double.TryParse(Console.ReadLine(), out result);
                if (!successful)
                {
                    Console.WriteLine("Введите число!\nПопробуйте снова:");
                }
                else
                {
                    if (result < 0)
                    {
                        Console.WriteLine("Вы ввели отрицательное значение, пожалуйста, введите положительное значение!");
                    }
                    else
                    {
                        tr = false;
                    }
                }
            }

            return result;
        }

        public static byte ByteTryParse()
        {
            byte result = 0;
            bool tr = true;
            while (tr)
            {
                bool successful = byte.TryParse(Console.ReadLine(), out result);
                if (!successful)
                {
                    Console.WriteLine("Введите число!\nПопробуйте снова:");
                }
                else
                {
                    if (result < 0)
                    {
                        Console.WriteLine("Вы ввели отрицательное значение, пожалуйста, введите положительное значение!");
                    }
                    else
                    {
                        tr = false;
                    }
                }
            }
            return result;
        }
    }
}