using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5_RolandoMelgara
{
    class Foto
    {
        private int id;
        private double tamaño;
        private DateTime fechaCreacion;
        private string comentarios;

        public int Id { get => id; set => id = value; }
        public double Tamaño { get => tamaño; set => tamaño = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }

        public Foto(int id, double tamaño, DateTime fechaCreacion, string comentarios)
        {
            Id = id;
            Tamaño = tamaño;
            FechaCreacion = fechaCreacion;
            Comentarios = comentarios;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nTamaño: {Tamaño} MB\nFecha de creación: {FechaCreacion}\nComentarios: {Comentarios}";
        }
    }

    class Album
    {
        private int id;
        private string nombre;
        private DateTime fechaCreacion;
        public List<Foto> Fotos;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

        public Album(int id, string nombre, DateTime fechaCreacion)
        {
            Id = id;
            Nombre = nombre;
            FechaCreacion = fechaCreacion;
            Fotos = new List<Foto>();
        }

        public void AniadirFoto(Foto f)
        {
            Fotos.Add(f);
        }

        public void MostrarFotos()
        {
            foreach (Foto f in Fotos)
            {
                Console.WriteLine(f);
                Console.WriteLine();
            }
        }

        public void VaciarAlbum()
        {
            Fotos.Clear();
        }

        public void EliminarFoto(Foto f)
        {
            Fotos.Remove(f);
        }

        public double TamanoAlbum()
        {
            double total = 0;
            foreach (Foto f in Fotos)
            {
                total += f.Tamaño;
            }
            return total / 1024; // convertir MB a GB
        }
    }
}
