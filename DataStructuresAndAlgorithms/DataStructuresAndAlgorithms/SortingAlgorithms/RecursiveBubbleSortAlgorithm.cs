using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public class RecursiveBubbleSortAlgorithm
    {
        public void RecursiveBubbleSort(int[] arr, int n)
        {
            //base case
            if (n == 1)
            {
                return;
            }

            int temp = 0;
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[j - 1] > arr[j])
                {
                    temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                }
            }
            RecursiveBubbleSort(arr, n - 1);
        }
    }
}
}
