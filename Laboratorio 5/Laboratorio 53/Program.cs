using System;

class Frutas
{
    public void MostrarFrutas()
    {
        string[] frutas = { "Manzana", "plátano", "naranja" };
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}

class Program3
{
    static void Main(string[] args)
    {
        Frutas lab = new Frutas();
        lab.MostrarFrutas();
        Console.ReadKey();
    }
}