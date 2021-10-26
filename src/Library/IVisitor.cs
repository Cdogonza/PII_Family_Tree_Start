using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    //Al crear un visitor debe de implementar el metodo visit a cualquier nodo creado, para eso es esta interface,
    //obligar a que las clases visitor contengan el metodo Visit para visitar un nodo family
    public interface IVisitor
    {
        void Visit(INode element);
    }

}
