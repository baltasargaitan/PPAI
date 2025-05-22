using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;

        // Constructor (equivale al "new()" del diagrama)
        public CambioEstado(DateTime inicio, DateTime fin)
        {
            fechaHoraInicio = inicio;
            fechaHoraFin = fin;
        }
        // Getter y setter opcionales si usás propiedades automáticas
        public DateTime FechaHoraInicio
        {
            get { return fechaHoraInicio; }
            set { fechaHoraInicio = value; }
        }
        public DateTime FechaHoraFin
        {
            get { return fechaHoraFin; }
            set { fechaHoraFin = value; }
        }
        // Método esEstadoActual: devuelve true si no tiene fecha de fin
        public bool EsEstadoActual()
        {
            return fechaHoraFin == DateTime.MinValue;
        }

        // Método setFechaHoraFin
        public void SetFechaHoraFin(DateTime fin)
        {
            fechaHoraFin = fin;
        }
        // Método crearMotivosFueraDeServicio (implementación vacía por ahora)
        public void CrearMotivosFueraDeServicio()
        {
            // A implementar según lógica del negocio
        }
    }
}
