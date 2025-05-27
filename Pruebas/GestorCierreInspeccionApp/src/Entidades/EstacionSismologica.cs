using System;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class EstacionSismologica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInstalacion { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string Descripcion { get; set; }
        public int Anio { get; set; }

        public EstacionSismologica(int id, string nombre, DateTime fechaInstalacion, float latitud, float longitud, string descripcion, int anio)
        {
            Id = id;
            Nombre = nombre;
            FechaInstalacion = fechaInstalacion;
            Latitud = latitud;
            Longitud = longitud;
            Descripcion = descripcion;
            Anio = anio;
        }
    }
}