using EspacioCalculadora;
Calculadora calc1 = new();
int opcion;
do
{
    Console.WriteLine("Ingrese la operacion a realizar , 0 para salir");
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        if( opcion != 0)
        {
            Console.WriteLine("Ingrese un num");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                switch (opcion)
                {
                    case 1:
                        calc1.Sumar(num1);
                        break;
                    case 2:
                        calc1.Restar(num1);
                        break;
                    case 3:
                        calc1.Multiplicar(num1);
                        break;
                    case 4:
                        if (Calculadora.ValidarDivisor(num1))
                        {
                            calc1.Dividir(num1);
                        }
                        else
                        {
                            Console.WriteLine("El divisor no es valido");
                        }
                        break;
                    case 5:
                        calc1.Limpiar();
                        break;
                    default:
                        Console.WriteLine("La opcion no es valida");
                        opcion = 0;
                        break;
                }
            }
        }
    }
} while (opcion != 0);