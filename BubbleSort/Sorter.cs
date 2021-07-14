using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace BubbleSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int unsortedLength = array.Length; unsortedLength >= 0; unsortedLength--)
            {
                for (int i = 0; i < unsortedLength - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }

        public static void RBS(int[] array, int unsortedLength)
        {
            if (unsortedLength == 0)
            {
                return;
            }

            RBS(array, unsortedLength - 1);

            for (int i = 0; i <= array.Length - unsortedLength - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            RBS(array, array.Length);
        }
    }
}
