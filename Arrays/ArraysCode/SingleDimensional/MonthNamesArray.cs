using System.Globalization;

namespace ArraysCode.SingleDimensional;

public static class MonthNamesArray
{
    public static void RunSample()
    {
        string[] months = new string[12];

        for (int month = 1; month <= 12; month++)
        {
            DateTime firstDay = new(DateTime.Now.Year, month, 1);
            string monthName = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
            months[month - 1] = monthName;
        }

        foreach (string month in months)
        {
            Console.WriteLine($"-> {month}");
        }
    }
}
