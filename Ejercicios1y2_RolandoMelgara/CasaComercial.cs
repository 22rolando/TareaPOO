using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios1y2_RolandoMelgara
{
    class CasaComercial
    {
        private List<Vehiculo> vehiculos;
        private string nombre;
        private string correo;
        private int totalVehiculos;

        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public int TotalVehiculos { get => totalVehiculos; set => totalVehiculos = value; }

        public CasaComercial(string nombre, string correo)
        {
            Vehiculos = new List<Vehiculo>();
            this.Nombre = nombre;
            this.Correo = correo;
            this.TotalVehiculos = 0;
        }



        public void aniadirVehiculo(Vehiculo v)
        {
            Vehiculos.Add(v);
            TotalVehiculos++;
        }

        public void mostrarVehiculos()
        {
            Console.WriteLine("Lista de vehículos:");
            foreach (Vehiculo v in Vehiculos)
            {
                Console.WriteLine(v);
            }
        }

        public void vaciarVehiculo()
        {
            Vehiculos.Clear();
            TotalVehiculos = 0;
        }

        public void eliminarVehiculo(Vehiculo v)
        {
            Vehiculos.Remove(v);
            TotalVehiculos--;
        }
    }
}
