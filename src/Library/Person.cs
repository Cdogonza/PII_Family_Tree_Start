using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    //Esta clase contiene los tipos que se afregan a family
    public class Person 
    {
        public string Name{get;set;}
        public int Age{get; set;}
       
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        
    }


}