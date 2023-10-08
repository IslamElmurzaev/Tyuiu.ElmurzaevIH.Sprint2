using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint2.Task0.V15.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint2.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 275;
            var result = ds.GetCompareOperations(x, y);

            bool[] wait = new bool[] { false, false, true, true, false, false };
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
