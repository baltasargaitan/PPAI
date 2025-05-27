using PPAI2025_3K1_4_1_Programa.Entidades;
using PPAI2025_3K1_4_1_Programa.DatosHardcodeados;

namespace PPAI2025_3K1_4_1_Programa.Controladores
{
    public class GestorCierreInspeccion
    {
        private Sesion sesionActual;
        private Empleado responsableInspeccion;

        public GestorCierreInspeccion()
        {
            // Inicializa la sesión desde los datos hardcodeados
            var datos = new DatosHardcodeados.DatosHardcodeados();
            sesionActual = datos.ObtenerSesion();
        }

        public void opcCerrarOrdenDeInspeccion()
        {
            responsableInspeccion = buscarRILogueado();
            // Aquí puedes continuar con el flujo, por ejemplo, mostrar órdenes, etc.
        }

        public Empleado buscarRILogueado()
        {
            if (sesionActual != null)
            {
                Usuario usuario = sesionActual.obtenerUsuario();
                return usuario.getRILogueado();
            }
            return null;
        }
    }
}