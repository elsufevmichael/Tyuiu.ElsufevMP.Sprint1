using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint1.Task6.V17.Lib;

namespace Tyuiu.ElsufevMP.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strTest = "aboba";
            bool res = ds.CheckPalindrome(strTest);
            string wait = "aboba";
            Assert.AreEqual(wait, res);
        }
    }
}
