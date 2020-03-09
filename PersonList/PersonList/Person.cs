using System;
using System.Collections.Generic;

namespace PersonList
{
    class Person
    {
         private string name;

         private int age;

        public Person(string newName) 
        { 
            name = newName;
        }



        public override string ToString()
        {
            return "Person: " + name;
        }

        
    }
}
