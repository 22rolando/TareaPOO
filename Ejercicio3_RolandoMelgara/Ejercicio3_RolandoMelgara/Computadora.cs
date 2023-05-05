using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3_RolandoMelgara
{
    class Computadora
    {
        private int capacidadDisco;
        private int espacioDisponible;
        private bool encendido;

        public int CapacidadDisco { get => capacidadDisco; set => capacidadDisco = value; }
        public int EspacioDisponible { get => espacioDisponible; set => espacioDisponible = value; }
        public bool Encendido { get => encendido; set => encendido = value; }

        public Computadora(int capacidadDisco, int espacioDisponible, bool encendido)
        {
            this.CapacidadDisco = capacidadDisco;
            this.EspacioDisponible = espacioDisponible;
            this.Encendido = encendido;
        }


        public void aniadirDatos(int datos)
        {
            if (Encendido)
            {
                if (EspacioDisponible + datos > CapacidadDisco)
                {
                    EspacioDisponible = CapacidadDisco;
                }
                else
                {
                    EspacioDisponible += datos;
                }
            }
        }

        public void eliminarDatos(int datos)
        {
            if (Encendido)
            {
                EspacioDisponible -= datos;
                if (EspacioDisponible < 0)
                {
                    EspacioDisponible = 0;
                }
            }
        }

        public void encender()
        {
            Encendido = true;
            Console.WriteLine("Bienvenido/a!");
        }

        public void apagar()
        {
            Encendido = false;
            Console.WriteLine("Hasta luego!");
        }
    }
}
