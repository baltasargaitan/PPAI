using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class MotivoTipo
    {
        public string tipoMotivo { get; set; }
        public string descripcion { get; set; }

        // Constructor
        public MotivoTipo(string tipoMotivo, string descripcion)
        {
            this.descripcion = descripcion;
            this.tipoMotivo = tipoMotivo;
        }
    }
}