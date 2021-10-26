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

            Node Abuelo = new Node(abuelo);
            Node Hijo1 = new Node(hijo1);
            Node Hijo2 = new Node(hijo2);
            Node Hija = new Node(hija);
            Node Nieta = new Node(nieta);
            Node Nieto = new Node(nieto);
            Node Bisnieto = new Node(bisnieto);
            Node Bisnieta = new Node(bisnieta);

            Abuelo.AddChildren(Hijo1);
            Abuelo.AddChildren(Hijo2);
            Abuelo.AddChildren(Hija);

            Hijo1.AddChildren(Nieta);
            Hijo1.AddChildren(Nieto);

            Nieto.AddChildren(Bisnieto);

            Hija.AddChildren(Bisnieta);


            Visitador visitor1 = new Visitador("Suma Edades");
            //Visitado2 visitor2 = new Visitado2("Edad del Hijo mas grande");
            //Visitador3 visitor3 = new Visitador3("El Nombre mas largo");

            Abuelo.Accept(visitor1);
       ;
            


        
        }
    }
}
