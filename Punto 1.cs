class Punto1
{
    static void Main()
    {
        int num1;
        int num2;
        int num3;

        Console.WriteLine("Ingrese el primer numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el primer segundo: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el primer tercer: ");
        num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("El numero mayor es el: " + num1);
        }else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("El numero mayo es el: " +num2);
        }else if (num3 > num1 && num3 > num2)
        {
            Console.WriteLine("El numero mayor es el: " + num3);
        }
        else
        {
            Console.WriteLine("Empate");
        }

        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine("El numero menor es el: " + num1);
        }
        else if (num2 < num1 && num2 < num3)
        {
            Console.WriteLine("El numero menor es el: " + num2);
        }
        else if (num3 < num1 && num3 < num2)
        {
            Console.WriteLine("El numero menor es el: " + num3);
        }
        else
        {
            Console.WriteLine("Empate");
        }


    }
}
