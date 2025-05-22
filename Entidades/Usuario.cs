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
        public string nombreUsuario;
        public string contraseña;
        public Empleado empleado; // Relación con la clase Empleado

        // Constructor
        public Usuario(string nombreUsuario, string contraseña)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }
        public string GetRILogueado()
        {
            return empleado != null ? empleado.ToString() : string.Empty;
        }

    }

}
