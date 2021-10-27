using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    //ESTA CLASE TIENE POR FUNCION ALMACENAR AL NODO Y SUS HIJOS, ASI COMO ACEPTAR VISITORS
    public class Node : INode
    {
        public  List<Node> children = new List<Node>();
        public string Name{get;set;}
        public int Age{get;set;}
        public Node(Person persona)
        {
            this.Name = persona.Name;
            this.Age = persona.Age;
        }
  
        public void AddChildren(Node person)
        {
            children.Add(person);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}