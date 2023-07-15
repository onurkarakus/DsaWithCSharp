namespace SortingAlgorithmsCode;

public static class BubbleSort
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
            bool isAnyChange = false;

            for (int j = 0; j < array.Length -1; i++)
            {
                isAnyChange = true;
                Swap(array, j, j - 1);
            }

            if (!isAnyChange)
            {
                break;
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
