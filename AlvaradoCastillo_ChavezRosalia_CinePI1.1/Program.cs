using System;

namespace AlvaradoCastillo_ChavezRosalia_CinePI1._1
{
    internal class Program
    {
        // Matriz de 5 filas por 6 columnas (30 asientos)
        static string[,] SalaDeCine = new string[5, 6];

        static void Main(string[] args)
        {
            InicializarSala();
            bool ejecutando = true;

            while (ejecutando)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("    GESTIÓN DEL SISTEMA DE CINE         ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Mostrar Estado de la Sala");
                Console.WriteLine("2. Reservar Asiento");
                Console.WriteLine("3. Liberar Asiento");
                Console.WriteLine("4. Consultar Disponibilidad");
                Console.WriteLine("5. Salir");
                Console.Write("\nEscoja una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        ReflejarMatriz();
                        Pausar();
                        break;
                    case "2":
                        Console.Clear();
                        ReservarAsiento();
                        Pausar();
                        break;
                    case "3":
                        Console.Clear();
                        LiberarAsiento();
                        Pausar();
                        break;
                    case "4":
                        Console.Clear();
                        ConsultarDisponibilidad();
                        Pausar();
                        break;
                    case "5":
                        ejecutando = false;
                        Console.WriteLine("\n¡Saliendo del sistema!");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        Pausar();
                        break;
                }
            }
        }

        static void InicializarSala()
        {
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    SalaDeCine[f, c] = "[ O ]";
                }
            }
        }

        static void ReflejarMatriz()
        {
            Console.WriteLine("=== PANTALLA ===\n");
            Console.Write("          C1     C2     C3     C4     C5     C6\n\n");
            for (int f = 0; f < 5; f++)
            {
                Console.Write($"Fila {f + 1} ");
                for (int c = 0; c < 6; c++)
                {
                    Console.Write($" {SalaDeCine[f, c]} ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Información Asientos: [ O ] = Disponible  |  [ X ] = Ocupado");
        }

        // Estructura modular del diseño algorítmico
        static void ReservarAsiento()
        {
            Console.WriteLine("--- RESERVAR ASIENTO ---");
        }

        static void LiberarAsiento()
        {
            Console.WriteLine("--- LIBERAR ASIENTO ---");
        }

        static void ConsultarDisponibilidad()
        {
            Console.WriteLine("--- CONSULTAR DISPONIBILIDAD ---");
        }

        static void Pausar()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}