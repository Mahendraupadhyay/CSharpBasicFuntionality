using ASPDotNetCoreApplication_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreApplication_Sample.Services
{
    public class InMemoryRestaurentData :IRestaurentData
    {
        public InMemoryRestaurentData()
        {
            _restaurents = new List<Restaurent>
            {
               new Restaurent{Id = 1, Name ="Restaurent1"},
               new Restaurent{Id = 2, Name ="Restaurent2"},
               new Restaurent{Id = 3, Name ="Restaurent3"},
            }
            ;
        }
        public IEnumerable<Restaurent> GetAll()
        {
            return _restaurents.OrderBy(f=>f.Name);
        }
        List<Restaurent> _restaurents;
    }
}
