using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public class InsertionSortAlgorithm : ISort
    {

        //O(n2) at worst case. O(n) at best case if the entire array is sorted
        public void Sort(int[] arr)
        {
            int key;

            int j = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                key = arr[i];

                while (i - j >= 0)
                {
                    if (key < arr[i - j])
                    {
                        int temp = arr[i - j];
                        arr[i - j] = key;
                        arr[i - j + 1] = temp;
                    }
                    j++;
                }

            }
        }
    }
}
