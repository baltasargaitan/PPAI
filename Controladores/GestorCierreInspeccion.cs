using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI2025_3K1_4_1_Programa.Entidades;
using PPAI2025_3K1_4_1_Programa.DatosHardcodeados; // uso de las datos hardcodeados
using PPAI2025_3K1_4_1_Programa.Boundary; // uso de la pantalla de cierre de ordenes

namespace PPAI2025_3K1_4_1_Programa.Controladores
{
    public class GestorCierreInspeccion
    {
        // ATRIBUTOS DE LA CLASE
        public List<(string nombreEstacion, String idSismografo, OrdenDeInspeccion orden)> OrdenesInspeccionCR { get; set; } // Lista de órdenes de inspección
        public string nomEmpleado { get; set; }
        public Sesion sesionActual { get; set; }
        public string nombreES; // Atributo para almacenar el nombre de la estación sismológica
        public PantallaCierreInspeccion pantallaCierreInspeccion; // Atributo para la pantalla de cierre de inspección

        // Constructor vacío
        public GestorCierreInspeccion(){
            
        }
        // Instancia de la clase Sesion


        //MÉTODOS DE LA CLASE

        // Método para la opcion Cerrar Orden de Inspección
        public void cerrarOrdenInspeccion(OrdenDeInspeccion orden, string observacion)
        {
            // Verificar si la orden es válida
            if (orden != null)
            {
                // Cerrar la orden de inspección
                orden.cerrar();
                // Asignar la observación de cierre
                orden.observacionCierre = observacion;
                // Mostrar mensaje de éxito
                Console.WriteLine("Orden cerrada exitosamente.");
            }
            else
            {
                // Mostrar mensaje de error si la orden es nula
                Console.WriteLine("Error: La orden no es válida.");
            }
        }

        //Metodo para buscar empleado por nombre
        public Empleado buscarRILogueado()
        {
            var datos = new DatosHardcodeados.DatosHardcodeados();
            this.sesionActual = datos.ObtenerSesion();

            if (this.sesionActual != null)
            {
                return this.sesionActual.obtenerUsuario();
            }
            return null;
        }


        //buscarOrdenes
        public List<(string nombreEstacion, String idSismografo, OrdenDeInspeccion orden)> buscarOrdenes(Empleado empl)
        {
            var datos = new DatosHardcodeados.DatosHardcodeados();
            var OrdenesInspeccion = datos.ObtenerOrdenesDeInspeccion();

            // List<OrdenDeInspeccion> datosOrdenes = new List<OrdenDeInspeccion>(); // Lista para almacenar los datos de las órdenes

            for (int i = 0; i < OrdenesInspeccion.Count; i++)
            {
                if (OrdenesInspeccion[i].esDeEmpleado(empl) && OrdenesInspeccion[i].estaCompletamenteRealizado())
                {
                    this.OrdenesInspeccionCR.Add(OrdenesInspeccion[i].mostrarDatosOrden());
                    //añadir a la lista
                }
            }
            return OrdenesInspeccionCR;

        }

        //Ordenar Ordenes
        public List<(string nombreEstacion, string idSismografo, OrdenDeInspeccion orden)> OrdenarOrdenes(List<(string nombreEstacion, string idSismografo, OrdenDeInspeccion orden)> OrdenesInspeccionCR)
        {
            return OrdenesInspeccionCR.OrderBy(o => o.orden.fechaHoraFinalizacion).ToList();
        }

    }
}
