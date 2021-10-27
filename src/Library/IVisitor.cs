using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    //AL CREAR UN VISITOS NUEVO, DEBE HEREDAR ESTA INTERFACE PARA OBLGARLO A TENER METODO Visit PARA VISITAR UN NODO
    public interface IVisitor
    {
        void Visit(Node element);
    }

}
