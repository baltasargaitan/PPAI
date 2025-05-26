using PPAI2025_3K1_4_1_Programa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.DatosHardcodeados
{
    public internal class DatosHardcodeados
    {
        //Estados
        public Estado estadoCompletamenteRealizada = new Estado("Orden de Inspección", "Completamente Realizada");
        public Estado estadoPendiente = new Estado("Orden de Inspección", "Pendiente");
        public Estado estadoEnProceso = new Estado("Orden de Inspección", "En Proceso");
        public Estado estadoCerrada = new Estado("Orden de Inspección", "Cerrada");

        // Rol
        public Rol rolTecnico = new Rol("Tecnico", "Tecnico de Estación Sismológica");
        public Rol rolInspector = new Rol("Inspector", "Inspector de Estación Sismológica");

        // Empleado de ejemplo
        public Empleado empleado1;
        public Empleado empleado2;

        // Usuario
        public Usuario usuario;

        // Sesion
        public Sesion sesion = new Sesion(DateTime.Now, Usuario usuario);

        // Empleado de ejemplos()
        public Empleado empleado1 = new Empleado("Juan", "Perez", "JPerez@gmail.com", "+5493834344368", rolInspector);
        public Empleado empleado2 = new Empleado("Jose", "Brenner", "JBrenner@hotmail.com", "+5493834344369", rolTecnico);
            usuario = new Usuario("JPerez", "JuanPerez1234", empleado1);

        // Usuario
        public Usuario usuario = new Usuario("JPerez", "JuanPerez1234", empleado1);
            sesion = new Sesion(DateTime.Now, usuario);
        }

        // Estación y sismógrafo de ejemplo
        public Sismografo sismografo = new Sismografo(DateTime.Now.AddYears(-1), 1, 1001, null);
        public EstacionSismologica estacion = new EstacionSismologica(1, "Doc123", DateTime.Now.AddMonths(-4), 34.60f, 58.38f, "Estación Sur", 2024);

        // Lista de órdenes
        public OrdenesDeInspeccion ordenes = new List<OrdenDeInspeccion>
            {
                new OrdenDeInspeccion(1, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-9), estacion, estadoCompletamenteRealizada, empleado1),
                new OrdenDeInspeccion(2, DateTime.Now.AddDays(-8), DateTime.Now.AddDays(-7), estacion, estadoCompletamenteRealizada, empleado1),
                new OrdenDeInspeccion(3, DateTime.Now.AddDays(-6), DateTime.Now.AddDays(-5), estacion, estadoCompletamenteRealizada, empleado1),
                new OrdenDeInspeccion(4, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-3), estacion, estadoPendiente, empleado1),
                new OrdenDeInspeccion(5, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), estacion, estadoEnProceso, empleado2),
                new OrdenDeInspeccion(6, DateTime.Now, DateTime.Now.AddHours(1), estacion, estadoCerrada, empleado2),
                new OrdenDeInspeccion(7, DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), estacion, estadoPendiente, empleado2)
            };

        public List<OrdenDeInspeccion> ObtenerOrdenesDeInspeccion()
        { 
            return ordenes;
        }

        public Sesion ObtenerSesion()
        { 
            return sesion;
        }
    }

}
