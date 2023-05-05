using System;

namespace Ejercicio5_RolandoMelgara
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album1 = new Album(1, "Vacaciones", DateTime.Now);
            Foto foto1 = new Foto(1, 5, DateTime.Now, "Playa");
            Foto foto2 = new Foto(2, 8, DateTime.Now, "Montaña");
            Foto foto3 = new Foto(3, 3, DateTime.Now, "Ciudad");

            album1.AniadirFoto(foto1);
            album1.AniadirFoto(foto2);
            album1.AniadirFoto(foto3);

            Console.WriteLine("Fotos del álbum:");
            album1.MostrarFotos();

            Console.WriteLine($"El tamaño del álbum es: {album1.TamanoAlbum()} GB");

            album1.VaciarAlbum();
            Console.WriteLine("Fotos del álbum después de vaciarlo:");
            album1.MostrarFotos();
            Console.ReadKey();
        }
    }
}
