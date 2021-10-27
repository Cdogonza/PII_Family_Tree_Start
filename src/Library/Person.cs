using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    //ESTA CLASE CONTIENE LOS TIPO PERSON QUE VANA RECIBIR LOS NODOS
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