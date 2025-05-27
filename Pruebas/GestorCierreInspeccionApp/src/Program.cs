using System;
using PPAI2025_3K1_4_1_Programa.Controladores;
using PPAI2025_3K1_4_1_Programa.DatosHardcodeados;
using PPAI2025_3K1_4_1_Programa.Entidades;

namespace GestorCierreInspeccionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the data
            var datos = new DatosHardcodeados.DatosHardcodeados();
            var gestor = new GestorCierreInspeccion();

            // Get the logged-in employee
            Empleado empleadoLogueado = gestor.buscarRILogueado();
            if (empleadoLogueado != null)
            {
                Console.WriteLine($"Empleado logueado: {empleadoLogueado.Nombre} {empleadoLogueado.Apellido}");

                // Retrieve inspection orders for the logged-in employee
                var ordenes = gestor.buscarOrdenes(empleadoLogueado);
                if (ordenes.Count > 0)
                {
                    Console.WriteLine("Órdenes de inspección disponibles:");
                    foreach (var orden in ordenes)
                    {
                        Console.WriteLine($"- Orden ID: {orden.Id}, Fecha de finalización: {orden.FechaFinalizacion}");
                    }
                }
                else
                {
                    Console.WriteLine("No hay órdenes de inspección disponibles para cerrar.");
                }
            }
            else
            {
                Console.WriteLine("No se pudo encontrar el empleado logueado.");
            }

            // Keep the console open
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}