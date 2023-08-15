using System;
using System.Globalization;


namespace Bhaskara

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            double A = double.Parse(valores[0] , CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1] , CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2] , CultureInfo.InvariantCulture);
            double resultado1;
            double resultado2;
            double delta = (Math.Pow(B, 2) - (4 * A * C));


            resultado1 = (-B + (Math.Sqrt(delta))) / (2 * A);
            resultado2 = (-B - (Math.Sqrt(delta))) / (2 * A);

            if (A != 0 && delta > 0) 
            {
                Console.WriteLine($"R1 = {resultado1.ToString("F5" ,CultureInfo.InvariantCulture)}\nR2 = {resultado2.ToString("F5" , CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
    