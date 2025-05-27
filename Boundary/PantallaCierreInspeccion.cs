using PPAI2025_3K1_4_1_Programa.Controladores;
using PPAI2025_3K1_4_1_Programa.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI2025_3K1_4_1_Programa.Boundary
{
    public partial class PantallaCierreInspeccion : Form
    {
        // Atrbutos de la clase PantallaCierreInspeccion
        public GestorCierreInspeccion gestorCierreInspeccion { get; set; } // Atributo para almacenar el gestor de cierre de inspección
        public ComboBox Ordenes;// Lista de órdenes de inspección

        public PantallaCierreInspeccion()
        {
            InitializeComponent();
        }

        private void pantallaCierreInspeccion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (habilitarVentana())
            {
                this.gestorCierreInspeccion = new GestorCierreInspeccion(); // Inicializar el gestor de cierre de inspección
                this.gestorCierreInspeccion.opcCerrarOrdenDeInspeccion(); // Llamar al método para cerrar la orden de inspección
            }
            ;
        }

        public bool habilitarVentana()
        {
            // Habilitar la ventana de cierre de inspección
            this.Enabled = true;
            this.Visible = true;
            // Retorna true si ambas propiedades están en true
            return this.Enabled && this.Visible;
        }
        //Esto pa mostrar despues, usa una lista que se creo en el gestor
        public void mostrarSeleccionOrdenes(DataGridView gridView, List<(string nombreEstacion, string idSismografo, OrdenDeInspeccion orden)> OrdenesInspeccionCR)
        {
            // Limpiar filas previas
            gridView.Rows.Clear();
            gridView.Columns.Clear();

            // Agregar columnas
            gridView.Columns.Add("Estacion", "Estación");
            gridView.Columns.Add("IdSismografo", "ID Sismógrafo");
            gridView.Columns.Add("FechaFinalizacion", "Fecha Finalización");
            gridView.Columns.Add("NumeroOrden", "Numero de Orden");


            // Agregar filas con los datos de la lista
            foreach (var dato in OrdenesInspeccionCR)
            {
                gridView.Rows.Add(dato.nombreEstacion, dato.idSismografo, dato.orden.fechaHoraFinalizacion, dato.orden.nroOrden);
            }
        }
    }
}
