using System.Globalization;

namespace ListsCode.GenericListExamples.AverageValue;

public static class AverageValueCode
{
    public static void RunSample()
    {
        List<double> numbers = new();

        do
        {
            Console.Write("Enter the number: ");
            string numberString = Console.ReadLine();

            if (!double.TryParse(numberString, NumberStyles.Float,
            new NumberFormatInfo(), out double number))
            {
                break;
            }
            
            numbers.Add(number);
            
            Console.WriteLine($"The average value: {numbers.Average()}");
        }
        while (true);
    }
}
