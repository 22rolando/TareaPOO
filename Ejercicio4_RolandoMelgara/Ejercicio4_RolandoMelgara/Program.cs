using System;

namespace Ejercicio4_RolandoMelgara
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo(1, "Ford", "Fiesta", 10000, 100000, 2015);
            Console.WriteLine(vehiculo1);

            Auto auto1 = new Auto(2, "Chevrolet", "Corsa", 50000, 80000, 2010, true);
            Console.WriteLine(auto1);

            Moto moto1 = new Moto(3, "Honda", "CBR", 2000, 120000, 2020, false);
            Console.WriteLine(moto1);

            Console.ReadKey();
        }
    }
}
