using System;

class PruebaVector1
{
    private int[] sueldos = new int[5]; //declaramos e inicializamos el vector
    public void Cargar()
    {
        for(int f = 0; f < 5; f++)
        {
            Console.Write("Ingrese el sueldo del operario " + (f + 1) + ": ");
            string? linea = Console.ReadLine();
            if (!int.TryParse(linea, out sueldos[f]))
            {
                Console.WriteLine("Valor inválido, se asigna 0.");
                sueldos[f] = 0;
            }
        }
    }
    //Muestra los sueldos de los operarios en el vector sueldos[f]
    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios:\n");
        for (int f = 0; f < 5; f++)
        {
            Console.WriteLine("[" + sueldos[f] + "] ");
        }
        Console.ReadKey();
    }
}

class Program1
{
    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
    }
}