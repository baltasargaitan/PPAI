using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Estado
    {
        private string ambito;
        private string nombreEstado;

        // Constructor por defecto
        public Estado()
        {
        }

        // Constructor con parámetros (opcional)
        public Estado(string ambito, string nombreEstado)
        {
            this.ambito = ambito;
            this.nombreEstado = nombreEstado;
        }

        // Propiedades
        public string Ambito
        {
            get { return ambito; }
            set { ambito = value; }
        }

        public string NombreEstado
        {
            get { return nombreEstado; }
            set { nombreEstado = value; }
        }

        // Métodos
        public bool EsCompletamenteRealizada()
        {
            return nombreEstado.Equals("Completamente Realizada", StringComparison.OrdinalIgnoreCase);
        }

        public bool EsCerrada()
        {
            return nombreEstado.Equals("Cerrada", StringComparison.OrdinalIgnoreCase);
        }

        public bool EsFueraDeServicio()
        {
            return nombreEstado.Equals("Fuera de Servicio", StringComparison.OrdinalIgnoreCase);
        }

        public bool EsAmbitoOrdenInspeccion()
        {
            return ambito.Equals("Orden de Inspección", StringComparison.OrdinalIgnoreCase);
        }

        public bool EsAmbitoSismografico()
        {
            return ambito.Equals("Sismográfico", StringComparison.OrdinalIgnoreCase);
        }
    }
}
