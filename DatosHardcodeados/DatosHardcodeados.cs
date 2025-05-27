using PPAI2025_3K1_4_1_Programa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.DatosHardcodeados
{
    public class DatosHardcodeados
    {
        // Estados
        public Estado EstadoCompletamenteRealizada { get; set; }
        public Estado EstadoPendiente { get; set; }
        public Estado EstadoEnProceso { get; set; }
        public Estado EstadoCerrada { get; set; }

        // Roles
        public Rol RolTecnico { get; set; }
        public Rol RolInspector { get; set; }

        // Empleados
        public Empleado Empleado1 { get; set; }
        public Empleado Empleado2 { get; set; }

        // Usuario y Sesión
        public Usuario Usuario1 { get; set; }
        public Sesion Sesion1 { get; set; }

        // Estación y Sismógrafo
        public Sismografo Sismografo1 { get; set; }
        public EstacionSismologica Estacion1 { get; set; }

        // Lista de órdenes
        public List<OrdenDeInspeccion> Ordenes { get; set; }

        // Constructor
        public DatosHardcodeados()
        {
            // Inicialización de estados
            EstadoCompletamenteRealizada = new Estado("Orden de Inspección", "Completamente Realizada");
            EstadoPendiente = new Estado("Orden de Inspección", "Pendiente");
            EstadoEnProceso = new Estado("Orden de Inspección", "En Proceso");
            EstadoCerrada = new Estado("Orden de Inspección", "Cerrada");

            // Inicialización de roles
            RolTecnico = new Rol("Tecnico", "Tecnico de Estación Sismológica");
            RolInspector = new Rol("Inspector", "Inspector de Estación Sismológica");

            // Inicialización de empleados
            Empleado1 = new Empleado("Juan", "Perez", "JPerez@gmail.com", "+5493834344368", RolInspector);
            Empleado2 = new Empleado("Jose", "Brenner", "JBrenner@hotmail.com", "+5493834344369", RolTecnico);

            // Inicialización de usuario y sesión
            Usuario1 = new Usuario("JPerez", "JuanPerez1234", Empleado1);
            Sesion1 = new Sesion(DateTime.Now, null, Usuario1);

            // Inicialización de estación y sismógrafo
            Sismografo1 = new Sismografo(DateTime.Now.AddYears(-1), 1, 1001, null);
            Estacion1 = new EstacionSismologica(1, "Doc123", DateTime.Now.AddMonths(-4), 34.60f, 58.38f, "Estación Sur", 2024);

            // Inicialización de órdenes
            Ordenes = new List<OrdenDeInspeccion>
        {
            new OrdenDeInspeccion(1, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-9), Estacion1, EstadoCompletamenteRealizada, Empleado1),
            new OrdenDeInspeccion(2, DateTime.Now.AddDays(-8), DateTime.Now.AddDays(-7), Estacion1, EstadoCompletamenteRealizada, Empleado1),
            new OrdenDeInspeccion(3, DateTime.Now.AddDays(-6), DateTime.Now.AddDays(-5), Estacion1, EstadoCompletamenteRealizada, Empleado1),
            new OrdenDeInspeccion(4, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-3), Estacion1, EstadoPendiente, Empleado1),
            new OrdenDeInspeccion(5, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), Estacion1, EstadoEnProceso, Empleado2),
            new OrdenDeInspeccion(6, DateTime.Now, DateTime.Now.AddHours(1), Estacion1, EstadoCerrada, Empleado2),
            new OrdenDeInspeccion(7, DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), Estacion1, EstadoPendiente, Empleado2)
        };
        }

        // Métodos para obtener datos
        public List<OrdenDeInspeccion> ObtenerOrdenesDeInspeccion()
        {
            return Ordenes;
        }

        public Sesion ObtenerSesion()
        {
            return Sesion1;
        }
    }
}