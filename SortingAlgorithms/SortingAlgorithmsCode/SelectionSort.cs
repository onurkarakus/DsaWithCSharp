namespace SortingAlgorithmsCode;

public static class SelectionSort
{
    public static void RunSample()
    {
        int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        Sort(integerValues);
        Console.WriteLine(string.Join(" | ", integerValues));
    }

    public static void Sort<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            T minValue = array[i];

            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j].CompareTo(minValue) < 0)
                {
                    minIndex = j;
                    minValue = array[j];
                }

                Swap(array, i, minIndex);
            }
        }
    }

    private static void Swap<T>(T[] array, int first, int second)
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }
}
