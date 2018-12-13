using System;
using ClassLibrary;

namespace ConsumeClassLib
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager manager = new ManagerClass();
            int result = manager.AddEmployeeDetails(1, "Mah1", "Upad1", 12312, "M", 2);
            Console.WriteLine(result > 0 ? "Employee details added successfully" : "Employee Details could not added");
            Console.WriteLine("*****End*******");
            Console.ReadKey();
        }
    }
}
