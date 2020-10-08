using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms_NET
{
    public static class Bubble<T> where T : IComparable
    {    
        public static T[] Sort(T[] array)
        {
            int numberChanges;
            do
            {
                numberChanges = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1].CompareTo(array[i]) > 0)
                    {
                        Swap(ref array[i - 1], ref array[i]);
                        numberChanges++;
                    }
                }
            } while (numberChanges > 0);
            
            return array;
        }

        private static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

    }
}
