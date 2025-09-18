using System;

class CalculosMatematicos32
{
    public static double Calcular(double a, double b)
    {
        return (a + b) * (a - b);
    }

    public static double CalculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}

class Program32
{
    static void Main()
    {
        Console.WriteLine("=== PROGRAMA 2: ÁREA DE UN CÍRCULO ===");

        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = CalculosMatematicos32.CalculoArea(radio);
        Console.WriteLine($"El área del círculo con radio {radio} es: {area:F2}");
    }
}