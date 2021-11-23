using System;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.4, 2-й вариант, высокий уровень, Гребенюк
            for (double x = -2; x <= 3; x +=(0.5))
            {
                double S = 0;
                for (int k = 1; k <= 5; k++)
                {
                    double F = 1;
                    for (int i = 1; i<=k+1; i++)
                    {
                        F *= i;
                    }
                    S += Math.Pow(-2, k + 1) * F / Math.Pow(x + 2.5, k + 1);
                }
                Console.WriteLine("f(" + x + ") = " + S);
            }
                    
        }
    }
}
