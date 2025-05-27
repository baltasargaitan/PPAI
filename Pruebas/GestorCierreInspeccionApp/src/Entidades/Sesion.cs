using System;

namespace PPAI2025_3K1_4_1_Programa.Entidades
{
    public class Sesion
    {
        public DateTime Inicio { get; private set; }
        public Usuario Usuario { get; private set; }

        public Sesion(DateTime inicio, Usuario usuario)
        {
            Inicio = inicio;
            Usuario = usuario;
        }

        public Usuario obtenerUsuario()
        {
            return Usuario;
        }
    }
}