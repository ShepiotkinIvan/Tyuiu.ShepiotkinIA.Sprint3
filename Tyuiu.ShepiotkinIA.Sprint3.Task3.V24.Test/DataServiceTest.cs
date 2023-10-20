using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint3.Task3.V24.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            string a = "****** ";
            var res = ds.ReplaceCharInString(a, '*', 'c');
            Assert.AreEqual(res, "cccccc ");
        }
    }
}
