using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint2.Task5.V6.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("Дама треф", ds.FindCardNameAndValue(2, 12));
            Assert.AreEqual("Валет бубен", ds.FindCardNameAndValue(3, 11));
            Assert.AreEqual("Король черв", ds.FindCardNameAndValue(4, 13));
            Assert.AreEqual("Туз пик", ds.FindCardNameAndValue(1, 14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(-1, 18);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(1, -3);
            });
        }
    }
}
