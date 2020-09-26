using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAnalysis
{
    public class QuickSort
    {
        public QuickSort()
        {

        }

        public void quick_sort(int[] arr, int p, int r)
        {
            int j;
            if (p < r)
            {
                j = partition(arr, p, r);
                quick_sort(arr, p, j - 1);
                quick_sort(arr, j + 1, r);
            }
        }

        public int partition(int[] A, int p, int r)
        {
            int x = A[r];
            int i = (p - 1);
            for (int j = p; j < r; j++)
            {
                if (A[j] <= x)
                {
                    i = i + 1;
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
            int temp2 = A[i + 1];
            A[i + 1] = A[r];
            A[r] = temp2;

            return i + 1;
        }

        public int Rand_Parti(int[] A, int p, int r)
        {
            Random rnd = new Random();

            int i = rnd.Next(p, r);
            int aux = A[r];
            A[r] = A[i];
            A[i] = aux;
            return partition(A, p, r);
        }

        public void Randomized_QuickSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = Rand_Parti(A, p, r);
                Randomized_QuickSort(A, p, q - 1);
                Randomized_QuickSort(A, q + 1, r);
            }
        }

        public int[] GenerateArray(int size)
        {
            Random r = new Random();
            int tam = (int)Math.Pow(10, size);
            int[] ar = new int[tam];

            for (int i = 0; i < tam; i++)
            {
                ar[i] = r.Next(1, (int)Math.Pow(10, 9));
            }
            return ar;

        }

        public bool compareElements(int[] a, int[] b)
        {
            bool isSame = true;

            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] != b[i])
                {
                    isSame = false;
                    break;
                }
                else
                {
                    
                }
            }
            return isSame;
        } 
    }
}
