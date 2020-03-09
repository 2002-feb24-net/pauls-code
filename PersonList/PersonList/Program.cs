using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<string>();
            var person1 = new Person("Paul");
            people.Add(person1.ToString);
            var person2 = new Person("Harold");
            var person3 = new Person("Diane");
            var person4 = new Person("Morgan");
            var person5 = new Person("Abe");

        }

        bool Duplicates(List<string> people)
        {
            var peoples = new HashSet<string>();
            foreach (var item in people)
            {
                if (!peoples.Add(item))
                    return true;
            }
            return false;
        }

        PeopleSort(List<string> people)
        {
            for (int i = 0; i < people.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (people[j - 1] > people[j])
                    {
                        int temp = people[j - 1];
                        people[j - 1] = people[j];
                        people[j] = temp;
                    }
                  }
            }
            return people;

        }

        static void Print(List<string> people)
        {
            foreach (var item in people)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
