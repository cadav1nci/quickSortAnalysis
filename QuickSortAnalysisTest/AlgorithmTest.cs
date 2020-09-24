using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuikSortAnalysis; 

namespace QuickSortAnalysisTest
{
    [TestClass]
    public class AlgorithmTest
    {
        Program qs;

        [TestMethod]
        public void qsTest()
        {
            int[] a = { 10, 20, 30, 40 };
            int[] b = { 10, 40, 20, 30 };
            
            Assert.IsTrue(a==b);
        }
    }
}
