class Program4
{
    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Acceso denegado - No cumple con el criterio de edad.");
        }
        else
        {
            Console.WriteLine("Acceso concedido");
        }
    }
    static void Main(string[] args)
    {
        try
        {
            checkAge(15);
        }
        catch(Exception e)
        {
            Console.WriteLine("Se ha producido una excepción: " + e.Message);
        }
        
    }
}