using System;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Rol Rol { get; set; }

        public Empleado(string nombre, string apellido, string email, string telefono, Rol rol)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Rol = rol;
        }

        public string ObtenerNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}