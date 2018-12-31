using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreApplication_Sample
{
   public interface IGreeter
    {
        string NewMethod(); 
    }

   public class Greeter : IGreeter
    {
        public string NewMethod()
        {
            return "Hello From New Method";
        }
    }
}
