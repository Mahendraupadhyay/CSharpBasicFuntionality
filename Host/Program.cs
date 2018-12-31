using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.ServiceModel.ServiceHost host = new ServiceHost(typeof(WCFBasicFunctionality.SampleService)))
            {
                host.Open();
                Console.WriteLine("Service started at" + DateTime.Now);
                Console.ReadKey();
            }
        }
    }
}
