using System;

namespace AlvaradoCastillo_ChavezRosalia_CinePI1._1
{
    internal class Program
    {
        // Matriz de 5 filas por 6 columnas (30 asientos)
        static string[,] SalaDeCine = new string[5, 6];

        // Arreglo de letras para mostrar las filas como en un cine real
        static char[] LetrasFilas = { 'A', 'B', 'C', 'D', 'E' };

        static void Main(string[] args)
        {
            InicializarSala();
            bool ejecutando = true;

            while (ejecutando)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("     GESTIÓN DEL SISTEMA DE CINE        ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Mostrar Estado de la Sala");
                Console.WriteLine("2. Reservar Asiento");
                Console.WriteLine("3. Liberar Asiento");
                Console.WriteLine("4. Consultar Disponibilidad");
                Console.WriteLine("5. Ver Estadísticas de Ocupación");
                Console.WriteLine("6. Salir");
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
                    case "5": Console.Clear(); 
                        MostrarEstadisticas(); 
                        Pausar();
                        break;
                    case "6":
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

        // Inicializar la matriz con todos los asientos libres
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

        // Mostrar la pantalla del cine y la matriz con filas A-E
        static void ReflejarMatriz()
        {
            Console.WriteLine("=================== PANTALLA ===================\n");
            Console.Write("           C1     C2     C3     C4     C5     C6\n\n");

            for (int f = 0; f < 5; f++)
            {
                // Muestra la letra de la fila (A, B, C, D, E)
                Console.Write($"Fila {LetrasFilas[f]}  ");

                for (int c = 0; c < 6; c++)
                {
                    Console.Write($" {SalaDeCine[f, c]} ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Información Asientos: [ O ] = Disponible  |  [ X ] = Ocupado");
        }

        // Reservar un asiento ingresando la letra de la fila y número de columna
        static void ReservarAsiento()
        {
            Console.WriteLine("--- RESERVAR ASIENTO ---\n");

            Console.Write("Ingrese la letra de la fila (A - E): ");
            string entradaFila = Console.ReadLine().ToUpper(); // Convierte a mayúscula (ej: 'a' -> 'A')

            Console.Write("Ingrese el número de columna (1 - 6): ");
            int columna = int.Parse(Console.ReadLine());

            // Convertir letra a índice numérico (A=0, B=1, C=2, D=3, E=4)
            int fila = ConvertirLetraAIndice(entradaFila);

            // Validar límites
            if (fila == -1 || columna < 1 || columna > 6)
            {
                Console.WriteLine("\nError: El asiento seleccionado no existe. (Recuerde: Filas A-E y Columnas 1-6)");
                return;
            }

            int c = columna - 1;

            if (SalaDeCine[fila, c] == "[ O ]")
            {
                SalaDeCine[fila, c] = "[ X ]";
                Console.WriteLine($"\n¡Éxito! Asiento {entradaFila}{columna} reservado correctamente.");
            }
            else
            {
                Console.WriteLine($"\nError: El asiento {entradaFila}{columna} ya está ocupado.");
            }
        }

        // Liberar un asiento reservado
        static void LiberarAsiento()
        {
            Console.WriteLine("--- LIBERAR ASIENTO ---\n");

            Console.Write("Ingrese la letra de la fila (A - E): ");
            string entradaFila = Console.ReadLine().ToUpper();

            Console.Write("Ingrese el número de columna (1 - 6): ");
            int columna = int.Parse(Console.ReadLine());

            int fila = ConvertirLetraAIndice(entradaFila);

            if (fila == -1 || columna < 1 || columna > 6)
            {
                Console.WriteLine("\nError: El asiento seleccionado no existe.");
                return;
            }

            int c = columna - 1;

            if (SalaDeCine[fila, c] == "[ X ]")
            {
                SalaDeCine[fila, c] = "[ O ]";
                Console.WriteLine($"\n¡Éxito! Asiento {entradaFila}{columna} liberado correctamente.");
            }
            else
            {
                Console.WriteLine($"\nAviso: El asiento {entradaFila}{columna} ya estaba libre.");
            }
        }
        // Consultar disponibilidad de un asiento específico
        static void ConsultarDisponibilidad()
        {
            Console.WriteLine("--- CONSULTAR DISPONIBILIDAD ---\n");

            Console.Write("Ingrese la letra de la fila (A - E): ");
            string entradaFila = Console.ReadLine().ToUpper();

            Console.Write("Ingrese el número de columna (1 - 6): ");
            int columna = int.Parse(Console.ReadLine());

            int fila = ConvertirLetraAIndice(entradaFila);

            if (fila == -1 || columna < 1 || columna > 6)
            {
                Console.WriteLine("\nError: El asiento seleccionado no existe.");
                return;
            }

            int c = columna - 1;

            if (SalaDeCine[fila, c] == "[ O ]")
            {
                Console.WriteLine($"\nEl asiento {entradaFila}{columna} está DISPONIBLE.");
            }
            else
            {
                Console.WriteLine($"\nEl asiento {entradaFila}{columna} está OCUPADO.");
            }
        }

        // Método auxiliar simple para transformar letras A-E a índices 0-4
        static int ConvertirLetraAIndice(string letra)
        {
            switch (letra)
            {
                case "A": return 0;
                case "B": return 1;
                case "C": return 2;
                case "D": return 3;
                case "E": return 4;
                default: return -1; // Retorna -1 si escriben una letra no válida (ej: 'Z')
            }
        }
        // Mostrar estadísticas de ocupación de la sala
        static void MostrarEstadisticas()
        {
            Console.WriteLine("--- ESTADÍSTICAS DE OCUPACIÓN ---\n");
            int disponibles = 0;
            int ocupados = 0;
            int totalAsientos = SalaDeCine.GetLength(0) * SalaDeCine.GetLength(1); // 30

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    if (SalaDeCine[f, c] == "[ X ]")
                    {
                        ocupados++;
                    }
                    else
                    {
                        disponibles++;
                    }
                }
            }

            double porcentajeOcupacion = ((double)ocupados / totalAsientos) * 100;

            Console.WriteLine($"Total de asientos en sala: {totalAsientos}");
            Console.WriteLine($"Asientos disponibles [ O ]: {disponibles}");
            Console.WriteLine($"Asientos ocupados    [ X ]: {ocupados}");
            Console.WriteLine($"Porcentaje de ocupación   : {porcentajeOcupacion:F2}%");
        }

        static void Pausar()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}