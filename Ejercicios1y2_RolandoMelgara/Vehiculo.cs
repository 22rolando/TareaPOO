using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios1y2_RolandoMelgara
{
    class Vehiculo
    {

        private int id;
        private string marca;
        private string modelo;
        private int kM;
        private decimal precio;
        private int anio;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int KM { get => kM; set => kM = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Anio { get => anio; set => anio = value; }

        public Vehiculo(int id, string marca, string modelo, int kM, decimal precio, int anio)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            KM = kM;
            Precio = precio;
            Anio = anio;
        }

        public Vehiculo()
        {

        }

        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}, Precio: {Precio}";
        }
    }
}
