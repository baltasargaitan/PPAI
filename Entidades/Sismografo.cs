using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Sismografo
    {
        public DateTime fechaAdquisicion;
        public int identificadorSismografo;
        public int nroSerie;

        // Constructor
        public Sismografo(DateTime fechaAdq, int idSismograf, int numSerie)
        {
            fechaAdquisicion = fechaAdq;
            identificadorSismografo = idSismograf;
            nroSerie = numSerie;
        }


        // Propiedades para acceder a los atributos
        public DateTime FechaAdquisicion
        {
            get { return fechaAdquisicion; }
            set { fechaAdquisicion = value; }
        }

        public int IdentificadorSismografo
        {
            get { return identificadorSismografo; }
            set { identificadorSismografo = value; }
        }

        public int NroSerie
        {
            get { return nroSerie; }
            set { nroSerie = value; }
        }
    }

}
