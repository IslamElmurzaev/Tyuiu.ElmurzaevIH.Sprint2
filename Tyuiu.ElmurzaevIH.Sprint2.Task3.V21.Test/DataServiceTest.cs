using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint2.Task3.V21.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 3;
            double res = ds.Calculate(x);

            double wait = 648;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 0;
            double res = ds.Calculate(x);

            double wait = 0.833;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double x = -21;
            double res = ds.Calculate(x);

            double wait = 0.954;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = -30;
            double res = ds.Calculate(x);

            double wait = -329.967;
            Assert.AreEqual(wait, res);
        }
    }
}
