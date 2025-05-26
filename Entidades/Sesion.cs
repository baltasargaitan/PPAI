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
        public Sesion(DateTime fechaHoraDesde, Usuario usuario)
        {
            this.FechaHoraDesde = fechaHoraDesde; // Asigna la fecha y hora actual
            this.Usuario = usuario; // Asigna el usuario a la sesión
        }

        public Sesion(DateTime fechaHoraHasta)
        {
            this.FechaHoraDesde = DateTime.Now; // Asigna la fecha y hora actual
            this.FechaHoraHasta = fechaHoraHasta;
        }
        public Empleado obtenerUsuario()
        {
            return Usuario.GetRILogueado(); // Llama al método GetRILogueado de la clase Usuario
        }
    }
}