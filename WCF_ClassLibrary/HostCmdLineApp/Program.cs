using System.ServiceModel;
using System.Configuration;
using System;
namespace HostCmdLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceType = typeof(MyWCFServices.HelloWorldService);
            var httpBaseAddress = ConfigurationSettings.AppSettings["HTTPBaseAddress"];
            var baseAddress = new Uri[] { new Uri(httpBaseAddress) };
            var host = new ServiceHost(serviceType, baseAddress);
            host.Open();
            Console.WriteLine("HelloWorldService is now running");
            Console.WriteLine("Press any key to stop it....");
            Console.ReadKey();
            host.Close();
        }
    }
}
