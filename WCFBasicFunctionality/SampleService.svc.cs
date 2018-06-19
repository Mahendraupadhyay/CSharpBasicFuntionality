using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFBasicFunctionality
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SampleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SampleService.svc or SampleService.svc.cs at the Solution Explorer and start debugging.
    public class SampleService : ISampleService
    {
       public int AddNumber(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
