using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint1.Task4.V22.Lib;

namespace Tyuiu.ElsufevMP.Sprint1.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 0.1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
