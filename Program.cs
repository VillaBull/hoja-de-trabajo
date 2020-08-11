using System;

namespace hoja_de_trabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numerador = 0, Denominador = 1;
            int Numerador2 = 0, Denominador2 = 1;
            Console.Write("Num 1: ");
            Numerador = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("     ----");
            Console.Write("Den 1: ");
            Denominador = Convert.ToInt32( Console.ReadLine());

            Console.Write("");

            Console.Write("Num 2: ");
            Numerador2 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("     ----");
            Console.Write("Den 2: ");
            Denominador2 = Convert.ToInt32( Console.ReadLine());

            Console.ReadKey();
        }
    }
}
