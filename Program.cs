using System;

namespace TP1_EJ4
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Title = "Distancia de KM a millas y yardas ";

            double Kilometros, Millas, Yardas;

            Console.Write("Ingrese la cantidad de Kilometros: ");
            Kilometros = Convert.ToSingle(Console.ReadLine());

            Yardas = Kilometros * 1093.6133;
            Millas = Kilometros * 0.621371192;

            Console.WriteLine($"{Kilometros} Kilometros son {Millas} Millas, y  {Yardas} Yardas");



        }
    }
}
