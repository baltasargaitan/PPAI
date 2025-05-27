using System;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Sismografo
    {
        public DateTime FechaInstalacion { get; set; }
        public int Id { get; set; }
        public int Identificador { get; set; }
        public string Estado { get; set; } // Puede ser "En Servicio", "Fuera de Servicio", etc.

        public Sismografo(DateTime fechaInstalacion, int id, int identificador, string estado)
        {
            FechaInstalacion = fechaInstalacion;
            Id = id;
            Identificador = identificador;
            Estado = estado;
        }
    }
}