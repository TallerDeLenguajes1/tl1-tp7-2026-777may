using EspacioCalculadora;
Calculadora calc1 = new();
do
{
    Console.WriteLine("Ingrese la operacion a realizar");
    if (int.TryParse(Console.ReadLine(), out int opcion))
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
                if (num1 != 0)
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
                break;
        }

    }
} while (opcion != 0);