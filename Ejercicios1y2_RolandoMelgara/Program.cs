using System;

namespace Ejercicios1y2_RolandoMelgara
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo(1, "Toyota", "Corolla", 50000, 25000, 2022);
            Console.WriteLine(vehiculo);
            Console.WriteLine("------------------------------------------------------------");
            CasaComercial casaComercial = new CasaComercial("Casa de Vehículos", "contacto@casa.com");
            Vehiculo vehiculo1 = new Vehiculo(1, "Toyota", "Corolla", 50000, 25000, 2022);
            Vehiculo vehiculo2 = new Vehiculo(2, "Honda", "Civic", 40000, 22000, 2021);

            casaComercial.aniadirVehiculo(vehiculo1);
            casaComercial.aniadirVehiculo(vehiculo2);
            casaComercial.mostrarVehiculos();

            casaComercial.eliminarVehiculo(vehiculo2);
            casaComercial.mostrarVehiculos();

            casaComercial.vaciarVehiculo();
            casaComercial.mostrarVehiculos();
            Console.ReadKey();
        }
    }
}
