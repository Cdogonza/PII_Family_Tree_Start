using System;

namespace Library
{
    //ESTA CLASE VISITOR COMPARA CADA NOMBRE DEL ARBOL GENIALOGICO E IMPRIME EL NOMBRE MAS LARFO 
    public class Visitor3 : IVisitor
    {
        public string Name {get;set;}

        public Visitor3(string name)
        {
            this.Name = name;
        }
        public void Visit(Node node)
        {          
            int nameLengh = node.Name.Length;
            string finalName =node.Name;
            foreach (Node hijo in node.children)
            {     
                if(nameLengh<hijo.Name.Length)
                {
                    nameLengh = hijo.Name.Length;
                    finalName =hijo.Name;
                }               
                foreach (Node nieto in hijo.children)
                    {
                        if(nameLengh<nieto.Name.Length)
                        {
                            nameLengh =nieto.Name.Length;
                            finalName =nieto.Name;
                        }
                        foreach (Node bisnieto in nieto.children)
                    {               
                        if(nameLengh<bisnieto.Name.Length)
                        {
                            nameLengh =bisnieto.Name.Length;
                            finalName =bisnieto.Name;
                        }
                    }               
                    
               } 
                               
            }
            Console.WriteLine($"{this.Name} {finalName} ");
              
        }




    }




}