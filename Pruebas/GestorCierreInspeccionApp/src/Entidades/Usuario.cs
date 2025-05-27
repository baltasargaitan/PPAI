using System;

namespace GestorCierreInspeccionApp.Entidades
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public Empleado EmpleadoAsociado { get; set; }

        public Usuario(string nombreUsuario, string contrasena, Empleado empleadoAsociado)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            EmpleadoAsociado = empleadoAsociado;
        }
    }
}