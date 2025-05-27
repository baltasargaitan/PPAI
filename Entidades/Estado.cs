using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Estado
    {
        public string ambito { get; set; }
        public string nombreEstado { get; set; }

        // Constructor con parámetros (opcional)
        public Estado(string ambito, string nombreEstado)
        {
            this.ambito = ambito;
            this.nombreEstado = nombreEstado;
        }
        // Métodos
        public bool esCompletamenteRealizada()
        {
            return nombreEstado.Equals("Completamente Realizada", StringComparison.OrdinalIgnoreCase);
        }

        public bool esCerrada()
        {
            return nombreEstado.Equals("Cerrada", StringComparison.OrdinalIgnoreCase);
        }

        public bool esFueraDeServicio()
        {
            return nombreEstado.Equals("Fuera de Servicio", StringComparison.OrdinalIgnoreCase);
        }

        public bool esAmbitoOrdenInspeccion()
        {
            return ambito.Equals("Orden de Inspección", StringComparison.OrdinalIgnoreCase);
        }

        public bool esAmbitoSismografico()
        {
            return ambito.Equals("Sismográfico", StringComparison.OrdinalIgnoreCase);
        }
    }
}
