using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Rol
    {
        // Propiedades automáticas
        public string Descripcion { get; set; }
        public string Nombre { get; set; }

        // Constructor
        public Rol(string descripcion, string nombre)
        {
            this.Descripcion = descripcion;
            this.Nombre = nombre;
        }

        // Método
        public string GetNombre()
        {
            return Nombre;
        }
    }
}

