using System;

namespace SortAlgorithms_NET
{
    public static class Merge<T> where T : IComparable
    {
        public static T[] Sort(T[] arrayOriginal)
        {
            var array = new T[arrayOriginal.Length];
            Array.Copy(arrayOriginal, array, arrayOriginal.Length);

            return Sort(array, 0, array.Length-1);
        }

        private static T[] Sort(T[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                Sort(array, lowIndex, middleIndex);
                Sort(array, middleIndex + 1, highIndex);
                MergeAlg(array, lowIndex, middleIndex, highIndex);
            }
            return array;
        }

        private static void MergeAlg(T[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new T[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left].CompareTo(array[right]) < 0)
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
    }
}
