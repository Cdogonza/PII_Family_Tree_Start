using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    //Esta clase es el nodo family donde se agregan los hijos y acepta visitors
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