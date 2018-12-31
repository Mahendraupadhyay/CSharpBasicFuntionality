using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreApplication_Sample.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "4548989";
        }
        [Route("address")]
        public string Address()
        {
            return "Your Address ABC";
        }
    }
}
