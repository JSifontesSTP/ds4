using System;

class CalculosMatematicos33
{
    public static double Calcular(double a, double b)
    {
        return (a + b) * (a - b);
    }

    public static double CalculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public static double PerimetroRectangulo(double lado1, double lado2)
    {
        return 2 * (lado1 + lado2);
    }
}

class Program33
{
    static void Main()
    {
        Console.WriteLine("=== PROGRAMA 3: PERÍMETRO DE UN RECTÁNGULO ===");

        Console.Write("Ingrese el primer lado del rectángulo: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo lado del rectángulo: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        double perimetro = CalculosMatematicos33.PerimetroRectangulo(lado1, lado2);
        Console.WriteLine($"El perímetro del rectángulo con lados {lado1} y {lado2} es: {perimetro}");
    }
}