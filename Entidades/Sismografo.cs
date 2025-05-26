using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Sismografo
    {
        public DateTime fechaAdquisicion { get; set; }
        public int identificadorSismografo { get; set; }
        public int nroSerie { get; set; }
        public EstacionSismologica estacionSismologica { get; set; } // Atributo para almacenar la estación sismológica asociada
        // Lista de cambios de estado
        public List<CambioEstado> cambiosEstado = new List<CambioEstado>();

        // Constructor
        public Sismografo(DateTime fechaAdq, int idSismograf, int numSerie, EstacionSismologica estSism)
        {
            fechaAdquisicion = fechaAdq;
            identificadorSismografo = idSismograf;
            nroSerie = numSerie;
            estacionSismologica = estSism; // Asignar la estación sismológica al atributo correspondiente

            // Crear el cambio de estado inicial y agregarlo
            var cambioInicial = new CambioEstado(DateTime.Now, new Estado("sismografo", "Disponible"));
            cambiosEstado.Add(cambioInicial);
        }

        // Obtener el cambio de estado actual (el que no tiene fecha de fin)
        public CambioEstado ObtenerEstadoActual()
        {
            return cambiosEstado.FindLast(c => c.fechaHoraFin == null);
        }

        // Crear nuevo cambio de estado (y cerrar el actual si hay uno)
        public void CrearCambioEstado(DateTime nuevaFechaInicio, Estado estad)
        {
            // Cerrar el actual si está activo
            var actual = ObtenerEstadoActual();
            if (actual != null)
            {
                actual.SetFechaHoraFin(nuevaFechaInicio);
            }

            // Crear y agregar nuevo
            var nuevo = new CambioEstado(nuevaFechaInicio, estad);
            cambiosEstado.Add(nuevo);
        }

        public Boolean sosDeEstacionSimsologica(EstacionSismologica estacion)
        {
            return this.estacionSismologica == estacion;
        }
    }
}
