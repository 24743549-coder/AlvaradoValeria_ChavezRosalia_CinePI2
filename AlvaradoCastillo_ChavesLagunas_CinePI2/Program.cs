using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaradoCastillo_ChavesLagunas_CinePI2
{
    internal class Program
    {
        // Matriz bidimensional de 5 filas por 6 columnas (30 asientos)
        static string[,] SalaDeCine = new string[5, 6];
        static void Main(string[] args)
        {
            // Inicializar la matriz con "[ O ]" (Disponible)
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    SalaDeCine[f, c] = "[ O ]";
                }
            }

            bool ejecutando = true;

            while (ejecutando)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("    GESTIONAMOS EL SISTEMA DEL CINE - DÍA 1  ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Lugar en la Sala");
                Console.WriteLine("2. Salir");
                Console.Write("\nEscoja una de las dos opciones: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        ReflejarMatriz();
                        Pausar();
                        break;

                    case "2":
                        ejecutando = false;
                        Console.WriteLine("\n¡Abandonando sistema!");
                        break;

                    default:
                        Console.WriteLine("\nLa opción escojida no es válida.");
                        Pausar();
                        break;
                }
            }
        }

        // Resultado de matriz de acuerdo a como se muestra en la Pantalla
        static void ReflejarMatriz()
        {
            Console.WriteLine("===                   PANTALLA               ===\n");

            // ColumnasYSuNumero
            Console.Write("          C1     C2     C3     C4     C5     C6\n\n");

            // DemostracionFilasYAsientos
            for (int f = 0; f < 5; f++)
            {
                Console.Write($"Fila {f + 1} ");
                for (int c = 0; c < 6; c++)
                {
                    Console.Write($" {SalaDeCine[f, c]} ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("InformaciónAsientos: [ O ] = Disponible  |  [ X ] = Ocupado");
        }

        static void Pausar()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
    