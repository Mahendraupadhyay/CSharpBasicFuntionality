using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsSampleApplication;

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
            ClassLibrary.IManager manager = new ClassLibrary.ManagerClass();
            int actual = manager.AddEmployeeDetails(2, "asa", "sad", 2343, "F", 4);
            Assert.AreEqual(1, actual);
        }
    }
}
