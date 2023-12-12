using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint6.TaskReview.V27.Lib;

namespace Tyuiu.BratsunDA.Sprint6.TaskReview.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int[,] mx = new int[,] { { 5, 10, 15 }, { 2, 4, 8 }, { 10, 12, 89 } };
            DataService ds = new DataService();
            int res = ds.GetSum(mx, 2, 0, 2);
            int wait = 22;
            Assert.AreEqual(wait, res);
        }
    }
}
