﻿using System.Collections.Concurrent;
using System.ComponentModel;

namespace SortingAlgorithmsCode;

public static class QuickSort
{
    public static void RunSample()
    {
        int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        Sort(integerValues);
        Console.WriteLine(string.Join(" | ", integerValues));
    }

    public static void Sort<T>(T[] array) where T : IComparable
    {
        Sort(array, 0, array.Length - 1);
    }

    private static T[] Sort<T>(T[] array, int lower, int upper) where T : IComparable
    {
        if (lower < upper)
        {
            int p = Partition(array, lower, upper);
            Sort(array, lower, p);
            Sort(array, p + 1, upper);
        }

        return array;
    }

    private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable
    {
        int i = lower;
        int j = upper;
        T pivot = array[lower];

        do
        {
            while (array[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (array[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i>= j)
            {
                break;
            }

            Swap(array,i, j);

        } while (i <= j);

        return j;
    }

    private static void Swap<T>(T[] array, int first, int second)
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }


}
