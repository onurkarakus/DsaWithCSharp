namespace ListsCode.SortedListExamples.AddressBook;

public static class AddressBookExample
{
    public static void RunSample()
    {
        SortedList<string, Person> people = new()
        {
            {
                "Marcin",
                new Person()
                {
                    Name = "Marcin",
                    Country = CountryEnum.PL,
                    Age = 29
                }
            },

            {
                "Sabine",
                new Person()
                {
                    Name = "Sabine",
                    Country = CountryEnum.DE,
                    Age = 25
                }
            },

            {
                "Ann",
                new Person()
                {
                    Name = "Ann",
                    Country = CountryEnum.PL,
                    Age = 31
                }
            }
        };

        foreach (KeyValuePair<string, Person> person in people)
        {
            Console.WriteLine($"{person.Value.Name} ({person.Value.Age} years) from {person.Value.Country}.");
        }
    }
}
