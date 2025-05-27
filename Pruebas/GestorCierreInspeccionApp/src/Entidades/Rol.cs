using System;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Rol
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Rol(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}