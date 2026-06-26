// dotnet new gitignore
using EspacioCalculadora;
Calculadora calc1 = new();
int opcion;
char operacion;
double anterior;
do
{
    Console.WriteLine("""
        ============= MENÚ ============= 
            (1) Sumar
            (2) Restar
            (3) Multiplicar
            (4) Dividir
            (5) Limpiar resultado
            (0) Salir
        ================================
        Seleccione una opción: 
        """);
    if (int.TryParse(Console.ReadLine(), out opcion) && opcion is >= 0 and <6)
    {
        if( opcion is not 0 and not 5)
        {
            Console.WriteLine("Ingrese un num:");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                anterior = calc1.Resultado;
                switch (opcion)
                {
                    case 1:
                        calc1.Sumar(num1);
                        operacion = '+';
                        break;
                    case 2:
                        calc1.Restar(num1);
                        operacion = '-';
                        break;
                    case 3:
                        calc1.Multiplicar(num1);
                        operacion = '*';
                        break;
                    case 4:
                        if (Calculadora.ValidarDivisor(num1))
                        {
                            calc1.Dividir(num1);
                            operacion = '/';
                        }
                        else
                        {
                            Console.WriteLine("\n------------------ El divisor no es valido ------------------\n");
                            operacion = ' ';
                        }
                        break;
                    default:
                        Console.WriteLine("\n------------------ La opcion no es valida ------------------\n");
                        operacion = ' ';
                        opcion = 0;
                        break;
                }
                if (operacion != ' ')
                {
                    Console.WriteLine($"\n{anterior}{operacion}{num1} = {calc1.Resultado}\n");
                }
            }
        }
        else
        {
            if (opcion == 5) calc1.Limpiar(); 
        }
    }
    else
    {
        Console.WriteLine("\n------------------- Operacion Incorrecta -------------------\n");
    }
    Console.WriteLine("\n-------------------------------------------------------------\n\n");
} while (opcion != 0);


// public static class ExtensionesNumericas
// {
//     // El 'this' antes del tipo le dice a C# que este método se le "pega" a cualquier int
//     public static bool EstaEntre(this int num, int min, int max)
//     {
//         return num >= min && num <= max;
//     }
// }