using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4_RolandoMelgara
{
    class Vehiculo
    {
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private double precio;
        private int año;

        public Vehiculo(int id, string marca, string modelo, int km, double precio, int año)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Año = año;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Año { get => año; set => año = value; }

        public override string ToString()
        {
            return "Marca: " + Marca + ", Modelo: " + Modelo + ", Año: " + Año + ", Precio: $" + Precio;
        }
    }

    class Auto : Vehiculo
    {
        private bool airbag;

        public Auto(int id, string marca, string modelo, int km, double precio, int año, bool airbag) : base(id, marca, modelo, km, precio, año)
        {
            this.Airbag = airbag;
            if (airbag)
            {
                Precio += 200;
            }
        }

        public bool Airbag { get => airbag; set => airbag = value; }

        public override string ToString()
        {
            return base.ToString() + (Airbag ? ", con Airbag" : "");
        }
    }

    class Moto : Vehiculo
    {
        private bool sidecar;

        public Moto(int id, string marca, string modelo, int km, double precio, int año, bool sidecar) : base(id, marca, modelo, km, precio, año)
        {
            this.sidecar = sidecar;
            if (sidecar)
            {
                Precio += 50;
            }
        }

        public bool Sidecar
        {
            get { return sidecar; }
            set { sidecar = value; }
        }

        public override string ToString()
        {
            return base.ToString() + (sidecar ? ", con Sidecar" : "");
        }
    }
}

}
