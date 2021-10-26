using System;

namespace Library
{
    public class Visitador : IVisitor
    {
        public string Name {get;set;}

        public Visitador(string name)
        {
            this.Name = name;
        }

        public void Visit(INode element)
        {
            int edades =0;
            Node persona = (Node) element;
            edades = persona.Age;
           foreach (Node item in persona.children)
           {
            
              edades +=item.Age;
           }
           Console.WriteLine($"{this.Name} {edades} ");
           
           
        }
    }
}