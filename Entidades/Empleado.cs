using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI2025_3K1_4_1_Programa.Entidades;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public Rol rol { get; set; } // Relación con la clase Rol

        // CONSTRUCTOR 
        public Empleado(string nombre, string apellido, string mail, string telefono, Rol rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.telefono = telefono;
            this.rol = rol;
        }
        public bool EsResponsableDeReparacion()
        {
            // Lógica que determine si es responsable
            return true; // o false según tu lógica
        }
        public Empleado GetEmpleado()
        {
            return this;
        }
        

    }

}
