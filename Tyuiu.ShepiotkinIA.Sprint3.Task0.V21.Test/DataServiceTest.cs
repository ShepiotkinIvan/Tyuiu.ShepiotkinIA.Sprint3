using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint3.Task0.V21.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            Assert.AreEqual(-63.727, ds.GetSumSeries(1.5, 1, 13));
        }
    }
}
