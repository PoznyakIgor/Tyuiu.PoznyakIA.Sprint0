using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PoznyakIA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Игорь";
            var res = DagtaService.GetMessae(name);

            Assert.AreEqual("Привет, Игорь", res);
        
        }
    }
}
