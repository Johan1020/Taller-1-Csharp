class Punto2
{
    static void Main()
    {
        int numero;

        Console.WriteLine("Imprime los numeros del 1 al 50 menos el 25");

        for (int i = 1; i <= 50; i++)
        {
            if (i != 25)
            {
                Console.WriteLine(i);
            }
        }
    }
}
