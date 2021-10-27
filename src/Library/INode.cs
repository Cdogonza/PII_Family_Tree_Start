

namespace Library
{
// PUEDO CREAR OTRO TIPO DE NODO PERO AL HEREDAD ESTA INTERFACE SI O SI TIENE QUE TENER LOS METODOS ABAJO DETALLADOS PARA 
//QUE FUNCIONE COMO UN NODO ESPERADO
    public interface INode
    {
      void Accept(IVisitor visitor);
      void AddChildren(Node person);
      
    }
}