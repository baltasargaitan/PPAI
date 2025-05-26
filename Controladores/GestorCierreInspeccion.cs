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
        public List<OrdenDeInspeccion> OrdenesInspeccionCR { get; set; } // Lista de órdenes de inspección
        public string nomEmpleado { get; set; }
        public Sesion sesionActual { get; set; }
        public string nombreES; // Atributo para almacenar el nombre de la estación sismológica


        // Constructor vacío
        public GestorCierreInspeccion(//Falta parámetro obtenido de la pantalla iniciar sesión)
            )
        {
            //
        }
        // Instancia de la clase Sesion

        //MÉTODOS DE LA CLASE

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
        public List<OrdenDeInspeccion> buscarOrdenes(Empleado empl)
        {
            var datos = new DatosHardcodeados.DatosHardcodeados();
            var OrdenesInspeccion = datos.ObtenerOrdenesDeInspeccion();

            // List<OrdenDeInspeccion> datosOrdenes = new List<OrdenDeInspeccion>(); // Lista para almacenar los datos de las órdenes

            for (int i = 0; i < OrdenesInspeccion.Count; i++)
            {
                if (OrdenesInspeccion[i].EsDeEmpleado(empl) && OrdenesInspeccion[i].estado.nombreEstado == "Completamente Realizada")
                {
                    this.OrdenesInspeccionCR.Add(OrdenesInspeccion[i]);
                    //añadir a la lista
                }
            }
            return OrdenesInspeccionCR;
        }
        

    }
}

