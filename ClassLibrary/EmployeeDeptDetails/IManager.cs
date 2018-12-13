using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public interface IManager
    {
       int AddEmployeeDetails(int empId, string empFName, string empLName, double empSalary, string empGender   , int deptId);
       
    }
}
