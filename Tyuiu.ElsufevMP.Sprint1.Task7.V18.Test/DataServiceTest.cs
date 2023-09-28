using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint1.Task7.V18.Lib;

namespace Tyuiu.ElsufevMP.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double wait = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
