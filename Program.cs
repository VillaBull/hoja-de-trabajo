using System;

namespace hoja_de_trabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numerador = 0, Denominador = 1;
            int Numerador2 = 0, Denominador2 = 1;

            Console.WriteLine("Ingrese Primer Fracción");
            Console.Write("Num: ");
            Numerador = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("    ----");
            Console.Write("Den: ");
            Denominador = Convert.ToInt32( Console.ReadLine());

            Console.Write("");

            Console.WriteLine("Ingrese Segunda Fracción");
            Console.Write("Num: ");
            Numerador2 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("    ----");
            Console.Write("Den: ");
            Denominador2 = Convert.ToInt32( Console.ReadLine());

            int Resultado;
            int Resultado1;

            Resultado = Numerador*Numerador2;
            Resultado1 = Denominador*Denominador2;

            Console.WriteLine("El resultado de la multiplicación es:");

            Console.WriteLine(" "+ Resultado);
            Console.WriteLine("---");
            Console.WriteLine(" "+ Resultado1);

            Console.ReadKey();
        }
    }
}
