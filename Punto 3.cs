class Punto3
{
    static void Main()
    {
        Console.WriteLine("Ingrese le numero de empleados: ");
        int empleados = int.Parse(Console.ReadLine());

        for (int i = 0; i < empleados; i++)
        {
            Console.WriteLine($"Ingrese el sueldo base del empleado {i}: ");
            double sueldo = int.Parse(Console.ReadLine());

            double descuentoRenta = sueldo * 0.10;
            double descuentoAFP = sueldo * 0.05;
            double decuentoISSS = sueldo * 0.04;

            double sueldoNeto = descuentoRenta - descuentoAFP - decuentoISSS;

            Console.WriteLine($"Sueldo del empleado {i}: {sueldo}");
            Console.WriteLine($"Descuento de renta: {descuentoRenta}");
            Console.WriteLine($"Descuento de AFP: {descuentoAFP}");
            Console.WriteLine($"Descuento de seguro social: {decuentoISSS}");
            Console.WriteLine($"Sueldo neto del empleado {i}: {sueldoNeto}");
        }
    }
}
