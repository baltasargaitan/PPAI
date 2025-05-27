using System;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class OrdenDeInspeccion
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public EstacionSismologica Estacion { get; set; }
        public Estado Estado { get; set; }
        public Empleado Responsable { get; set; }

        public OrdenDeInspeccion(int id, DateTime fechaCreacion, DateTime fechaFinalizacion, EstacionSismologica estacion, Estado estado, Empleado responsable)
        {
            Id = id;
            FechaCreacion = fechaCreacion;
            FechaFinalizacion = fechaFinalizacion;
            Estacion = estacion;
            Estado = estado;
            Responsable = responsable;
        }

        public bool EsDeEmpleado(Empleado empleado)
        {
            return Responsable.Equals(empleado);
        }
    }
}