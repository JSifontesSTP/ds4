using System;
using System.Collections.Generic;

class Calificaciones
{
    public void CalcularPromedio()
    {
        List<int> calificaciones = new List<int> {85, 90, 78, 92, 88};
        int suma = 0;
        foreach (int calificacion in calificaciones)
        {
            suma += calificacion;
        }
        double promedio = suma / (double)calificaciones.Count;
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}

class Program4
{
    static void Main(string[] args)
    {
        Calificaciones lab = new Calificaciones();
        lab.CalcularPromedio();
        Console.ReadKey();
    }
}