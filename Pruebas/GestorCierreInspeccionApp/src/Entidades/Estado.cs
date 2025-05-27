using System;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Estado
    {
        public string Tipo { get; set; }
        public string NombreEstado { get; set; }

        public Estado(string tipo, string nombreEstado)
        {
            Tipo = tipo;
            NombreEstado = nombreEstado;
        }
    }
}