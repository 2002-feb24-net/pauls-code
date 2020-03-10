using System;
using System.Collections.Generic;

namespace PersonList
{
    class Person
    {
         private string name;
         public string Name => name;

         private int age;
         public string Age => name;

        public Person(string newName, int newAge) 
        { 
            name = newName;
            age = newAge;
        }



        public override string ToString()
        {
            return "Person: " + name;
        }

        
    }
}
