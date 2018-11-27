using System;

namespace Creational.AbstractFactory.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.RunClient();

            Console.ReadLine();
        }
    }
}
