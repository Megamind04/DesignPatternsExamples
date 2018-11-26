using System;

namespace Creational.FactoryMethod.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Example:\n");

            Client client = new Client();
            client.RunClient();

            Console.ReadLine();
        }
    }
}
