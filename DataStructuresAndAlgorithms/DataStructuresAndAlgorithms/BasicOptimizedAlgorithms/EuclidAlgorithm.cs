using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BasicOptimizedAlgorithms
{
    /// <summary>
    /// Euclid's algorithm for finding the greatest common denominator
    /// GCD(A,B) = GCD(B, Remainder)
    /// </summary>
    public class EuclidAlgorithm
    {
        public static void EuclidAlgorithmFunction(long[] array)
        {
            long A = array[0];
            long B = array[1];
            long GCD = 0;
            long remainder = 0;

            while (B != 0)
            {
                remainder = A % B;
                A = B;
                B = remainder;

                GCD = A;
            }

            Console.WriteLine("The GCD of " + array[0] + " and " + array[1] + " is " + GCD);
        }
    }
}
