using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private string mail;
        private string telefono;
        public Rol rol; // Relación con la clase Rol

        // CONSTRUCTOR 
        public Empleado(string nombre, string apellido, string mail, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.telefono = telefono;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
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
