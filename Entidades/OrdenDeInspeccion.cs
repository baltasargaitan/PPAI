using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class OrdenDeInspeccion
    {
        // Propiedades automáticas
        public int nroOrden { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public DateTime fechaHoraFinalizacion { get; set; }
        public DateTime? fechaHoraCierre { get; set; }
        public string observacionCierre { get; set; }
        public EstacionSismologica estacionSismologica { get; set; } // Atributo para almacenar la estación sismológica asociada
        public Estado estado { get; set; } // Atributo para almacenar el estado actual de la orden
        public Empleado empleado { get; set; } // Atributo para almacenar el empleado asociado a la orden

        // Constructor
        public OrdenDeInspeccion(
            int nroOrden,
            DateTime fechaHoraInicio,
            DateTime fechaHoraFinalizacion,
            EstacionSismologica estacionSismologica,
            Estado estado,
            Empleado empleado)
        {
            this.nroOrden = nroOrden;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFinalizacion = fechaHoraFinalizacion;
            this.fechaHoraCierre = null;
            this.observacionCierre = string.Empty;
            this.estacionSismologica = estacionSismologica;
            this.estado = estado;
            this.empleado = empleado;
        }

        // Métodos
        public bool esDeEmpleado(Empleado empl)
        {
            if (empleado == empl)
            { return true; }
            return false;
        }

        public bool estaCompletamenteRealizado()
        {
            return fechaHoraCierre.HasValue;
        }

        public (string nombreEstacion, string idSismografo, OrdenDeInspeccion orden) mostrarDatosOrden()
        {
            return (
                estacionSismologica?.getNombre() ?? "No asignada",
                estacionSismologica?.obtenerIdSismografo().ToString() ?? "No asignado",
                this
            );
        }




        public void enviarSismografoParaReparacion()
        {
            // Lógica para enviar el sismógrafo a reparación
            //var sismfueraServicio = this.estacionSismologica.ponerSismografo
        }

        public void cerrar()
        {
            fechaHoraCierre = DateTime.Now;
            Console.WriteLine("Orden cerrada.");
        }
    }
}