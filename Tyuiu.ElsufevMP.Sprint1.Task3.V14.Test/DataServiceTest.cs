using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint1.Task3.V14.Lib;

namespace Tyuiu.ElsufevMP.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 1;
            double wait = 1;
            var res = ds.ReverseNumber(number);
            Assert.AreEqual(wait, res);
        }
    }
}
