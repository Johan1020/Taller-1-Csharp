using System;

class Punto4
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de números primos que desea generar:");
        int cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine($"Los primeros {cantidad} números primos son:");
        GenerarNumerosPrimos(cantidad);

        Console.ReadLine();
    }

    static void GenerarNumerosPrimos(int cantidad)
    {
        int contador = 0;

        for (int numero = 2; contador < cantidad; numero++)
        {
            if (EsPrimo(numero))
            {
                Console.Write($"{numero} ");
                contador++;
            }
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
