using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSortAnalysis;

namespace QuickSortAnalysisTest
{
    [TestClass]
    public class QuickSortTest
    {
        private QuickSort qs;

        [TestInitialize]
        public void initialize()
        {
            qs = new QuickSort();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(qs);
        }

        [TestMethod]
        public void compareTest()
        {
            int[] a = { 5, 4, 3, 7 };

            int[] b = { 5, 7, 3, 4 };

            Assert.IsFalse(qs.compareElements(a, b));
        }


        [TestMethod]
        public void QuickSortSmall()
        {
            int[] a = { 5, 4, 3, 7 };

            int[] b = { 5, 7, 3, 4 };

            qs.quick_sort(a, 0, a.Length - 1);

            Array.Sort(b);

            Assert.IsTrue(qs.compareElements(a, b));

        }

        [TestMethod]

        public void QuickSortBigTest()
        {
            int tam = 1000;
            int[] a = new int[tam];
            Random r = new Random();

            for (int i = 0; i < tam - 1; i++)
            {
                int j = r.Next(1, 999) + 1;
                a[i] = j;
            }


            int[] b = a;
            Array.Sort(a);

            qs.quick_sort(b, 0, b.Length - 1);

            Assert.IsTrue(qs.compareElements(a, b));
        }

        [TestMethod]

        public void RandomizedQSSmallTest()
        {
            int[] a = { 5, 4, 3, 7 };

            int[] b = { 5, 4, 3, 7 };

            qs.Randomized_QuickSort(b, 0, b.Length - 1);

            Array.Sort(a);

            



            Assert.IsTrue(qs.compareElements(a, b));

        }

        [TestMethod]

        public void RandomizedQSBigTest()
        {
            int tam = 1000;
            int[] a = new int[tam];
            Random r = new Random();

            for (int i = 0; i < tam - 1; i++)
            {
                int j = r.Next(1, 999) + 1;
                a[i] = j;
            }


            int[] b = a;
            Array.Sort(a);

            qs.Randomized_QuickSort(b, 0, b.Length - 1);

            Assert.IsTrue(qs.compareElements(a, b));
        }

        // Pruebas del experimento

        [TestMethod]

        public void NoRandomizedQuickONDTest()
        {
            int[] a = {1,3,2,5};

            int[] b = {1,3,2,5};

            qs.quick_sort(a, 0, a.Length - 1);

            Array.Sort(b);

            Assert.IsTrue(qs.compareElements(a, b));
        }

        [TestMethod]

        public void RandomizedQuickONDTest()
        {
            int[] a = { 1, 3, 2, 5 };

            int[] b = { 1, 3, 2, 5 };

            Array.Sort(b);

            qs.Randomized_QuickSort(a, 0, a.Length - 1);

            

            Assert.IsTrue(qs.compareElements(a, b));
        }
        [TestMethod]
        public void NoRandomizedQuickONATest()
        {
            int[] a = { 5,3,2,1 };

            int[] b = { 5,3,2,1 };

            qs.quick_sort(a, 0, a.Length - 1);

            Array.Sort(b);

            Assert.IsTrue(qs.compareElements(a, b));
        }

        [TestMethod]

        public void RandomizedQuickONATest()
        {
            int[] a = { 5, 4, 3, 2 };

            int[] b = { 5, 4, 3, 2 };

            

            qs.Randomized_QuickSort(a, 0, a.Length - 1);
            Array.Sort(b);


            Assert.IsTrue(qs.compareElements(a, b));
        }

        [TestMethod]

        public void NoRandomizedQuickNOATest()
        {
            int[] a = qs.GenerateArray(3);

            int[] b = a;

            qs.quick_sort(a, 0, a.Length - 1);

            Array.Sort(b);

            Assert.IsTrue(qs.compareElements(a, b));
        }

        [TestMethod]

        public void RandomizedQuickNOATest()
        {
            int[] a = qs.GenerateArray(3);

            int[] b = a;

            qs.Randomized_QuickSort(a, 0, a.Length - 1);
            Array.Sort(b);

            Assert.IsTrue(qs.compareElements(a, b));
        }




    }
}
