using System;

class CalculosMatematicos
{
    public static double Calcular(double a, double b)
    {
        return (a + b) * (a - b);
    }
}

class Program31
{
    static void Main()
    {
        Console.WriteLine("=== PROGRAMA 1: OPERACIÓN (a+b)*(a-b) ===");

        Console.Write("Ingrese el primer número (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        double resultado = CalculosMatematicos.Calcular(a, b);
        Console.WriteLine($"El resultado de ({a} + {b}) * ({a} - {b}) es: {resultado}");
    }
}
