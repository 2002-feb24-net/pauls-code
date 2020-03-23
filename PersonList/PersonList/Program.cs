using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<string>();
            var ages = new List<string>();

            var person1 = new Person("Paul", 31);
            people.Add(person1.Name);
            ages.Add(person1.Age);
            var person2 = new Person("Harold", 23);
            people.Add(person2.Name);
            ages.Add(person2.Age);
            var person3 = new Person("Diane", 26);
            people.Add(person3.Name);
            ages.Add(person3.Age);
            var person4 = new Person("Morgan", 23);
            people.Add(person4.Name);
            ages.Add(person4.Age);
            var person5 = new Person("Abe", 35);
            people.Add(person5.Name);
            ages.Add(person5.Age);

            var sortedPeople = InsertionSort(people);
            // sortedPeople.Sort();

            Print(Duplicates(ages));
            Print(Duplicates(sortedPeople));

            Print(sortedPeople);

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

        static List<string> InsertionSort(List<string> people)
        {
            var sortedPeople = new List<string>{people[0]};
            for (int i = 1; i < people.Count - 1; i++)
            {
                for (int j = 0; j < sortedPeople.Count - 1;j++)
                {
                    if (String.Compare(people[i], sortedPeople[j]) < 0)
                    {
                        sortedPeople.Insert(j, people[i]);
                        continue;
                    }
                }   
                
            }
            return sortedPeople;

        }

        static void Print(List<string> people)
        {
            foreach (var item in people)
            {
                System.Console.Write(item + " ");
            }
        }
    }
}
