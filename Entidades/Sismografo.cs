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
        public EstacionSismologica estacionSismologica; // Atributo para almacenar la estación sismológica asociada
        // Lista de cambios de estado
        private List<CambioEstado> cambiosEstado = new List<CambioEstado>();

        // Constructor
        public Sismografo(DateTime fechaAdq, int idSismograf, int numSerie, DateTime fechaInicioEstadoInicial, EstacionSismologica estSism)
        {
            fechaAdquisicion = fechaAdq;
            identificadorSismografo = idSismograf;
            nroSerie = numSerie;
            estacionSismologica = estSism; // Asignar la estación sismológica al atributo correspondiente

            // Crear el cambio de estado inicial y agregarlo
            var cambioInicial = new CambioEstado(fechaInicioEstadoInicial);
            cambiosEstado.Add(cambioInicial);
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

        // Obtener el cambio de estado actual (el que no tiene fecha de fin)
        public CambioEstado ObtenerEstadoActual()
        {
            return cambiosEstado.FindLast(c => c.FechaHoraFin == null);
        }

        // Crear nuevo cambio de estado (y cerrar el actual si hay uno)
        public void CrearCambioEstado(DateTime nuevaFechaInicio)
        {
            // Cerrar el actual si está activo
            var actual = ObtenerEstadoActual();
            if (actual != null)
            {
                actual.SetFechaHoraFin(nuevaFechaInicio);
            }

            // Crear y agregar nuevo
            var nuevo = new CambioEstado(nuevaFechaInicio);
            cambiosEstado.Add(nuevo);
        }

        public Boolean sosDeEstacionSimsologica(EstacionSismologica estacion)
        {
            return this.estacionSismologica == estacion;
        }
    }
}
