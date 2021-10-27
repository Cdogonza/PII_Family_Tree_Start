using System;

namespace Library
{
    //EN ESTA CLASE VISITOR CALCULO LA SUMA DE LAS EDADES DE LOS INTEGRANTES DEL ARBOL GENIALOGICO
    public class Visitor : IVisitor
    {
        public string Name {get;set;}

        public Visitor(string name)
        {
            this.Name = name;
        }

        public void Visit(Node node)
        {
            int edades =0;
            edades = node.Age;
           foreach (Node hijo in node.children)
           {       
               foreach (Node nieto in hijo.children)
               {
                   foreach (Node bisnieto in nieto.children)
                    {               
                        edades +=bisnieto.Age;
                    }               
                    edades +=nieto.Age;
               } 
                edades +=hijo.Age;               
           }
           Console.WriteLine($"{this.Name} {edades} ");
              
        }
    }
}