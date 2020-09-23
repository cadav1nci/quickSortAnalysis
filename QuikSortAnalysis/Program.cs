using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikSortAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void quick_sort(int[] arr, int p, int r)
        {
            int j;
            if (p < r)
            {
                j = partition(arr, p, r);
                quick_sort(arr, p, j - 1);
                quick_sort(arr, j + 1, r);
            }
        }

        public static int partition(int[] A, int p, int r)
        {
            int x = A[r];
            int i = p - 1;

            for (int j = p; j < r-1; j++)
            {
                if (A[j]<= x)
                {
                    i += 1;

                    int aux = A[i];
                    A[i] = A[j];
                    A[j] = aux;
                }
            }
            return i+1;
        }

        public static int Rand_Parti(int[] A, int p, int r)
        {
            int i = Random(p, r);
            return 0;
        }
    }
}
