using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsSampleApplication;
using System.Collections.Generic;

namespace SampleUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void Test_button1_Click_Method1()
        //{
        //    Form1 f1 = new Form1();
        //    f1.button1_Click(null, null);
        //}
        [TestMethod]
        public void AddEmpDetailsTest()
        {
            //ClassLibrary.IManager manager = new ClassLibrary.ManagerClass();
          //  int actual = manager.AddEmployeeDetails(2, "asa", "sad", 2343, "F", 4);
          //  Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void CheckReadList()
        {
            List<string> li = new List<string>();
            Form1 form1 = new Form1();
            form1.ReadList(li);
            int count = li.Count;
            Assert.AreEqual(2,count);
        }
    }
}
