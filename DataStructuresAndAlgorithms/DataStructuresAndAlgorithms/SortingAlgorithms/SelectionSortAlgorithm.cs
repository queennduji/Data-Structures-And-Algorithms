using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public class SelectionSortAlgorithm : ISort
    {
        public void Sort(int[] arr)
        {
            //int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int min = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        int temp = min;
                        min = arr[j];
                        arr[j] = temp;
                    }
                }

                arr[i] = min;
            }
        }
    }
}
