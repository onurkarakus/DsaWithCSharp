using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsCode.GenericListExamples.ListOfPeople;

public static class ListOfPeopleExample
{
    public static void RunSample()
    {
        List<Person> people = new();
        people.Add(new Person()
        {
            Name = "Marcin",
            Country = CountryEnum.PL,
            Age = 29
        });

        people.Add(new Person()
        {
            Name = "Sabine",
            Country = CountryEnum.DE,
            Age = 25
        });

        people.Add(new Person()
        {
            Name = "Ann",
            Country = CountryEnum.PL,
            Age = 31
        });

        List<Person> results = people.OrderBy(p => p.Name).ToList();

        foreach (Person person in results)
        {
            Console.WriteLine($"{person.Name} ({person.Age} years) from {person.Country}.");
        }

        List<string> names = people.Where(p => p.Age <= 30)
            .OrderBy(p => p.Name)
            .Select(p => p.Name)
            .ToList();

        foreach (var person in names)
        {
            Console.WriteLine($"{person}");
        }
    }
}
