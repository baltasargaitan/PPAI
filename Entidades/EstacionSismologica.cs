using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class EstacionSismologica
    {
        private int codigoEstacion;
        private string documentoCertificacionAdquirida;
        private DateTime fechaSolicitudCertificacion;
        public float latitud;
        private float longitud;
        private string nombre;
        private int nroCertificacion;
        private Sismografo sismografo; // Atributo para almacenar el sismógrafo asociado a la estación

        // Constructor
        public EstacionSismologica(int codEst, string docCertificacionAdq, DateTime fechaSolCertificacion, float lat, float longit, string nom, int nroCert, Sismografo sismogra)
        {
            codigoEstacion = codEst;
            documentoCertificacionAdquirida = docCertificacionAdq;
            fechaSolicitudCertificacion = fechaSolCertificacion;
            latitud = lat;
            longitud = longit;
            nombre = nom;
            nroCertificacion = nroCert;
            this.sismografo = sismogra; // Asignar el sismógrafo al atributo correspondiente
        }

        // Propiedades para acceder a los atributos
        public int CodigoEstacion
        {
            get { return codigoEstacion; }
            set { codigoEstacion = value; }
        }

        public string DocumentoCertificacionAdquirida
        {
            get { return documentoCertificacionAdquirida; }
            set { documentoCertificacionAdquirida = value; }
        }

        public DateTime FechaSolicitudCertificacion
        {
            get { return fechaSolicitudCertificacion; }
            set { fechaSolicitudCertificacion = value; }
        }

        public float Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }

        public float Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int NroCertificacion
        {
            get { return nroCertificacion; }
            set { nroCertificacion = value; }
        }

        public Sismografo Sismografo
        {
            get { return sismografo; }
            set { sismografo = value; }
        }

        // Método para obtener IdSismógrafo
        public int ObtenerIdSismografo()
        {
            return sismografo.IdentificadorSismografo;
        }
    }
}
