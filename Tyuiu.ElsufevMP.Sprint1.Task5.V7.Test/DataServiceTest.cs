using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ElsufevMP.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 90;
            double res = ds.AngleToHoursMinutes(f);
            int result = Convert.ToInt32(res);
            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
