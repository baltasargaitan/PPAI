using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class OrdenDeInspeccion
    {
        private int nroOrden;
        private DateTime fechaFinalizacion;

        public OrdenDeInspeccion(int nroOrden, DateTime fechaFinalizacion)
        {
            this.nroOrden = nroOrden;
            this.fechaFinalizacion = fechaFinalizacion;
        }
        public int NroOrden
        {
            get { return nroOrden; }
            set { nroOrden = value; }
        }
        public DateTime FechaFinalizacion
        {
            get { return fechaFinalizacion; }
            set { fechaFinalizacion = value; }
        }

        public void EsDeEmpleado()
        {

        }

        public void EstaCompletamenteRealizado()
        {

        }

        public void mostrarDatosOrden()
        {

        }

        public int GetNroOrden()
        {
            return nroOrden;
        }

        public DateTime GetFechaFinalizacion()
        {
            return fechaFinalizacion;
        }

        public void SetFechaHoraCierre()
        {
            
        }

        public void SetEstado()
        {

        }

        public void EnviarSismografoParaReparacion()
        {
        
        }

        public void Cerrar()
        {

        }

    }
}


