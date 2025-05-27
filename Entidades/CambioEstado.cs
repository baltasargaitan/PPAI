using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class CambioEstado
    {
        public DateTime fechaHoraInicio { get; set; }
        public DateTime? fechaHoraFin { get; set; }

        public Estado estado; // Atributo para almacenar el estado actual

        public Empleado empleado; // Atributo para almacenar el empleado que realizó el cambio (opcional, si se requiere)

        // Constructor (equivale al "new()" del diagrama)
        public CambioEstado(DateTime inicio, Estado estado, Empleado empleado)
        {
            this.fechaHoraInicio = inicio;
            this.fechaHoraFin = null;
            this.estado = estado; // Inicializar el estado
            this.empleado = empleado; // Inicializar el empleado que realizó el cambio  
        }

        // Método esEstadoActual: devuelve true si no tiene fecha de fin
        public bool esEstadoActual()
        {
            return fechaHoraFin == DateTime.MinValue;
        }

        // Método setFechaHoraFin
        public void setFechaHoraFin(DateTime fin)
        {
            fechaHoraFin = fin;
        }
        // Método crearMotivosFueraDeServicio (implementación vacía por ahora)
        public void crearMotivosFueraDeServicio()
        {
            // A implementar según lógica del negocio
        }
    }
}
