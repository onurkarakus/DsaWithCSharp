namespace SortingAlgorithmsCode;

public static class InsertionSort
{
    public static void RunSample()
    {
        int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        Sort(integerValues);
        Console.WriteLine(string.Join(" | ", integerValues));
    }

    public static void Sort<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length; i++)
        {
            int j = i;

            while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
            {
                Swap(array, j, j - 1);
                j--;
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
