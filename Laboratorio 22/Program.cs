using System;

namespace laboratorio21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asignando valor a variable estatica.
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);
        }
    }
    public class MyClass
    {
        //Declarando variable estatica.
        public static int Valor;
    }
}