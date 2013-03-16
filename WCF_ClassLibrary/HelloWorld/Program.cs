
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HelloWorldServicesClient();
            Console.WriteLine(client.GetMessage("Abhishek Gopalan"));
        }
    }
}
