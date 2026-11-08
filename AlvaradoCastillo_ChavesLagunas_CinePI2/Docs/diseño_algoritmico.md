
# Algoritmo General del Sistema

1. Inicio
2. Crear la matriz SalaDeCine[5, 6] e inicializar todas las posiciones con "[ O ]" (Disponible).
3. Mostrar el menú principal con las opciones disponibles (Ver sala, Reservar, Liberar, Estadísticas, Salir).
4. Leer la opción ingresada por el usuario.
5. Según la opción:
   - Opción 1 (Ver Sala): Desplegar la matriz en formato de cuadrícula con sus filas y columnas.
   - Opción 2 (Reservar): Solicitar Fila (1-5) y Columna (1-6). Validar si el asiento está libre "[ O ]". Si lo está, cambiar a "[ X ]".
   - Opción 3 (Liberar): Solicitar Fila (1-5) y Columna (1-6). Validar si el asiento está ocupado "[ X ]". Si lo está, cambiar a "[ O ]".
   - Opción 4 (Estadísticas): Recorrer la matriz, contar los disponibles/ocupados y calcular el porcentaje de ocupación.
   - Opción 5 (Salir): Terminar la ejecución.
6. Si no elige la opción de salir, regresar al menú principal.
7. Fin



# Pseudocódigo: Reservar Asiento
Función ReservarAsiento()
    Escribir "Ingrese número de fila (1 a 5):"
    Leer fila
    Escribir "Ingrese número de columna (1 a 6):"
    Leer columna

    Si fila < 1 O fila > 5 O columna < 1 O columna > 6 Entonces
        Escribir "Error: Coordenadas fuera de rango."
    Sino
        Si SalaDeCine[fila - 1, columna - 1] == "[ O ]" Entonces
            SalaDeCine[fila - 1, columna - 1] = "[ X ]"
            Escribir "¡Asiento reservado con éxito!"
        Sino
            Escribir "Error: El asiento ya se encuentra ocupado."
        FinSi
    FinSi
FinFunción

# Pseudocódigo: Calcular Estadísticas
Función MostrarEstadisticas()
    ocupados = 0
    disponibles = 0
    totalAsientos = 30

    Para f = 0 Hasta 4 Hacer
        Para c = 0 Hasta 5 Hacer
            Si SalaDeCine[f, c] == "[ X ]" Entonces
                ocupados = ocupados + 1
            Sino
                disponibles = disponibles + 1
            FinSi
        FinPara
    FinPara

    porcentaje = (ocupados / totalAsientos) * 100

    Escribir "Asientos Ocupados: ", ocupados
    Escribir "Asientos Disponibles: ", disponibles
    Escribir "Porcentaje de Ocupación: ", porcentaje, "%"
FinFunción