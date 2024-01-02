using System;

class Program
{
    // Funciones lambda para operaciones básicas
    static Func<double, double, double> Suma = (a, b) => a + b;
    static Func<double, double, double> Resta = (a, b) => a - b;
    static Func<double, double, double> Multiplicacion = (a, b) => a * b;
    static Func<double, double, double> Division = (a, b) => b != 0 ? a / b : double.NaN;

    // Función para calcular basada en la operación proporcionada
    static double Calcular(Func<double, double, double> operacion, double a, double b)
    {
        return operacion(a, b);
    }

    static void Main()
    {
        Console.WriteLine("Calculadora Funcional");

        while (true)
        {
            Console.WriteLine("\nSeleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("0. Salir");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                continue;
            }

            if (opcion == 0)
            {
                break; // Salir del bucle si se elige la opción 0
            }

            if (opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                continue;
            }

            // Ingresar valores por teclado
            Console.Write("Ingrese el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                continue;
            }

            Console.Write("Ingrese el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                continue;
            }

            // Realizar el cálculo según la opción seleccionada
            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = Calcular(Suma, a, b);
                    break;
                case 2:
                    resultado = Calcular(Resta, a, b);
                    break;
                case 3:
                    resultado = Calcular(Multiplicacion, a, b);
                    break;
                case 4:
                    resultado = Calcular(Division, a, b);
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }

        Console.WriteLine("¡Hasta luego!");
    }
}
