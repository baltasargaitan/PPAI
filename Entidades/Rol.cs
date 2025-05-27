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
        public string descripcion { get; set; }
        public string nombre { get; set; }

        // Constructor
        public Rol(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        // Método
        public string getNombre()
        {
            return nombre;
        }
    }
}

