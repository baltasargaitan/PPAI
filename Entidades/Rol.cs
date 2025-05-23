using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Rol
    {
        public string descripcion;
        public string nombreUsuario;

        public Rol(string descripcion, string nombreUsuario)
        {
            this.descripcion = descripcion;
            this.nombreUsuario = nombreUsuario;
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string GetNombre()
        {
            return nombreUsuario;
        }
    }

}
