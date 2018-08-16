using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsSampleApplication;

namespace SampleUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_button1_Click_Method1()
        {
            Form1 f1 = new Form1();
            f1.button1_Click(null, null);
        }
    }
}
