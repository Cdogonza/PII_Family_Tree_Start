using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            Person abuelo = new Person("Jorge", 82); //Abuelo
            Person hijo1 = new Person("Juan Carlos", 44); //Hijo-Hermano
            Person hijo2 = new Person("Pedro", 25); //Hijo-padre
            Person hija = new Person("Carla", 33); //Hijo-padr
            Person nieta = new Person("Barbara", 13);//hija-nieta
            Person nieto = new Person("Christian", 22);//hijo-Nieto
            Person bisnieto = new Person("David", 4);//hijo-bisNieto
            Person bisnieta = new Person("Natalia", 2);//hijo-bisNieto
            //CREO LOS DIFERENTES NODOS ADMINTIENDO EL TIPO PERSON CREADO ARRIBA
            Node Abuelo = new Node(abuelo);
            Node Hijo1 = new Node(hijo1);
            Node Hijo2 = new Node(hijo2);
            Node Hija = new Node(hija);
            Node Nieta = new Node(nieta);
            Node Nieto = new Node(nieto);
            Node Bisnieto = new Node(bisnieto);
            Node Bisnieta = new Node(bisnieta);
            //A CADA NODO LE AGREGO LOS HIJOS QUE TIENEN, PARA AGREGARLOS A LA LISTA 
            Abuelo.AddChildren(Hijo1);
            Abuelo.AddChildren(Hijo2);
            Abuelo.AddChildren(Hija);

            Hijo1.AddChildren(Nieta);
            Hijo1.AddChildren(Nieto);

            Nieto.AddChildren(Bisnieto);

            Nieta.AddChildren(Bisnieta);

            // CREO 3 VISITANTES QUE REALIZAN LAS DIFERENTES COSAS QUE TIENEN COMO NOMBRE
            Visitor visitor1 = new Visitor("Suma Edades");
            Visitor2 visitor2 = new Visitor2("Edad del Hijo mas grande");
            Visitor3 visitor3 = new Visitor3("El Nombre mas largo");
            
            Abuelo.Accept(visitor1);
            Abuelo.Accept(visitor2);  
            Abuelo.Accept(visitor3);


         


        
        }
    }
}
