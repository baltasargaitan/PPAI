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
        public int NroOrden { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFinalizacion { get; set; }
        public DateTime? FechaHoraCierre { get; set; }
        public string ObservacionCierre { get; set; }
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
            this.NroOrden = nroOrden;
            this.FechaHoraInicio = fechaHoraInicio;
            this.FechaHoraFinalizacion = fechaHoraFinalizacion;
            this.FechaHoraCierre = null;
            this.ObservacionCierre = string.Empty;
            this.estacionSismologica = estacionSismologica;
            this.estado = estado;
            this.empleado = empleado;
        }

        // Métodos
        public bool EsDeEmpleado(Empleado empl)
        {
            if (empleado == empl)
            { return true; }
            return false;
        }

        public bool EstaCompletamenteRealizado()
        {
            return FechaHoraCierre.HasValue;
        }

        public string MostrarDatosOrden()
        {
            return $"Nro Orden: {NroOrden}\n" +
                   $"Fecha Hora Finalización: {FechaHoraFinalizacion}\n" +
                   $"Estación Sismológica: {(estacionSismologica != null ? estacionSismologica.GetNombre() : "No asignada")}\n" +
                   $"ID Sismógrafo: {(estacionSismologica != null ? estacionSismologica.ObtenerIdSismografo().ToString() : "No asignado")}\n";
        } 
        

        public void EnviarSismografoParaReparacion()
        {
            // Lógica para enviar el sismógrafo a reparación
            //var sismfueraServicio = this.estacionSismologica.ponerSismografo
        }

        public void Cerrar()
        {
            FechaHoraCierre = DateTime.Now;
            Console.WriteLine("Orden cerrada.");
        }
    }
}