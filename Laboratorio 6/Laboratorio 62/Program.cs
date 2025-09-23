class Program2
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el numero deseado");

        try
        {
            num = Int16.Parse(Console.ReadLine());
            Console.WriteLine(num);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("No ha introducido un dijito valido");
            num = -1;
            Console.WriteLine(num);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("El numero es demasiado grande o demasiado pequeño para un Int16");
            num = -1;
            Console.WriteLine(num);
        }
        Console.WriteLine(num);
    }
}