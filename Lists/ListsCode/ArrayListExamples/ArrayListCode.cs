using System.Collections;

namespace ListsCode.ArrayListExamples;

public static class ArrayListCode
{
    public static void RunSample()
    {
        ArrayList arrayList = new()
        {
            5
        };

        arrayList.AddRange(new int[] { 6, -7, 8 });
        arrayList.AddRange(new object[] { "Marcin", "Mary" });
        arrayList.Insert(5, 7.8);

        object first = arrayList[0];
        int third = (int)arrayList[2];

        Console.WriteLine($"First Item : {first}, Third Item: {third}");

        foreach (object element in arrayList)
        {
            Console.WriteLine(element);
        }

        int count = arrayList.Count;
        int capacity = arrayList.Capacity;

        Console.WriteLine($"Capacity : {capacity}, Count : {count}");

        bool containsMary = arrayList.Contains("Mary");

        Console.WriteLine($"ArrayList Contains 'Mary' {containsMary} ");

        int minusIndex = arrayList.IndexOf(-7);

        Console.WriteLine($"Index Of -7 Is {minusIndex}");
    }
}
