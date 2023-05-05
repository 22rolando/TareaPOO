using System;

namespace Ejercicio3_RolandoMelgara
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora computadora = new Computadora(500, 250, false);

            computadora.aniadirDatos(300);
            Console.WriteLine("Espacio disponible: " + computadora.EspacioDisponible);

            computadora.eliminarDatos(200);
            Console.WriteLine("Espacio disponible: " + computadora.EspacioDisponible);

            computadora.encender();

            computadora.aniadirDatos(500);
            Console.WriteLine("Espacio disponible: " + computadora.EspacioDisponible);

            computadora.eliminarDatos(700);
            Console.WriteLine("Espacio disponible: " + computadora.EspacioDisponible);

            computadora.apagar();

            Console.ReadKey();
        }
    }
}
