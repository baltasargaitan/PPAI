using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class MotivoFueraServicio
    {
        public string comentario { get; set; }
        public MotivoTipo tipo { get; set; }

        // Constructor
        public MotivoFueraServicio(string comentario, MotivoTipo tipo)
        {
            this.tipo = tipo;
            this.comentario = comentario;
        }
    }
}
