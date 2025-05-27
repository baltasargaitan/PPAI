using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class EstacionSismologica
    {
        public int codigoEstacion { get; set; }
        public string documentoCertificacionAdquirida { get; set; }
        public DateTime fechaSolicitudCertificacion { get; set; }
        public float latitud { get; set; }
        public float longitud { get; set; }
        public string nombre { get; set; }
        public int nroCertificacion { get; set; }
        public Sismografo sismografo { get; set; } // Atributo para almacenar el sismógrafo asociado a la estación

        // Constructor
        public EstacionSismologica(int codEst, string docCertificacionAdq, DateTime fechaSolCertificacion, float lat, float longit, string nom, int nroCert)
        {
            this.codigoEstacion = codEst;
            this.documentoCertificacionAdquirida = docCertificacionAdq;
            this.fechaSolicitudCertificacion = fechaSolCertificacion;
            this.latitud = lat;
            this.longitud = longit;
            this.nombre = nom;
            this.nroCertificacion = nroCert;
        }

        // Método para obtener IdSismógrafo
        public int obtenerIdSismografo()
        {

            // Verificar si el sismógrafo está asociado a la estación
            if (sismografo == null)
            {
                throw new InvalidOperationException("No hay sismógrafo asociado a esta estación.");
            }
            return sismografo.identificadorSismografo;
        }
        public string getNombre()
        {
            return nombre;
        }

        // public bool ponerSismografoFueraDeServicio(Sismografo sismografo)

        //{
        // for (int i = 0; i < sismografo; i++)
        //{
        //    if (sismografo.cambiosEstado[i].estado.nombre == "Fuera de Servicio")
        //      {
        //           return true;
        //       }
        //   }
        //}
    }
}
