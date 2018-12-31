using ASPDotNetCoreApplication_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreApplication_Sample.Services
{
   public interface IRestaurentData
    {
      IEnumerable<Restaurent>  GetAll();
    }
}
