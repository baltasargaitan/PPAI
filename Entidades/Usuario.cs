using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI2025_3K1_4_1_Programa.Entidades;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Usuario
    {
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public Empleado empleado { get; set; } // Relación con la clase Empleado

        // Constructor
        public Usuario(string nombreUsuario, string contraseña, Empleado empleado)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.empleado = empleado; // Asigna el empleado asociado al usuario
        }
        public Empleado GetRILogueado()
        {
            return empleado; // Devuelve el empleado asociado al usuario
        }

    }

}
