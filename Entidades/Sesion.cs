using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Sesion
    {
        public DateTime FechaHoraDesde { get; set; }
        public DateTime FechaHoraHasta { get; set; }
        public Usuario Usuario { get; set; }

        // Constructor
        public Sesion()
        {
            FechaHoraDesde = DateTime.Now; // Asigna la fecha y hora actual
        }

        public Sesion(DateTime fechaHoraHasta)
        {
            FechaHoraDesde = DateTime.Now; // Asigna la fecha y hora actual
            FechaHoraHasta = fechaHoraHasta;
        }
    }
}