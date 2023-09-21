using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint1.Task2.V22.Lib;

namespace Tyuiu.ElsufevMP.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 1;
            int b = 2;
            int c = 3;
            var res = ds.CalculateAVGValue(a, b, c);
            Assert.AreEqual(2, res);
        }
    }
}
