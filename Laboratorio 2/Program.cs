using System;

namespace laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            //Ejemplo utilizando las variables de instancia de Clase.
            client.FirstName = "Josemanuel";
            client.LastName = "Sifontes";
            client.Age = 23;
            client.id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }
    public class Client
    {
        //Declarando variables de instancia en clase.
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}