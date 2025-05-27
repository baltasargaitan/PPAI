using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Sesion
    {
        public DateTime fechaHoraDesde { get; set; }
        public DateTime? fechaHoraHasta { get; set; }
        public Usuario usuario { get; set; }

        // Constructor
        public Sesion(DateTime fechaHoraDesde, DateTime? fechaHoraHasta, Usuario usuario)
        {
            this.fechaHoraDesde = DateTime.Now; // Asigna la fecha y hora actual
            this.fechaHoraHasta = null;
            this.usuario = usuario; // Asigna el usuario a la sesión
        }
        public Empleado obtenerUsuario()
        {
            return usuario.getRILogueado();
        }
    }
}