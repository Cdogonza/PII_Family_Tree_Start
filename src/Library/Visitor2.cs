using System;

namespace Library
{
    //EN ESTA CLASE VISITOR CALCULA LA EDAD DEL NODO HIJO MAS GRANDE Y LA DEVUELVO
    public class Visitor2 : IVisitor
    {
        public string Name {get;set;}

        public Visitor2(string name)
        {
            this.Name = name;
        }
        public void Visit(Node node)
        {
            int edades =0;
           foreach (Node hijo in node.children)
           {
               if(edades<hijo.Age)    
               {
                edades =hijo.Age;
               }                 
                               
           }
           Console.WriteLine($"{this.Name} {edades} ");
              
        }
    }




}