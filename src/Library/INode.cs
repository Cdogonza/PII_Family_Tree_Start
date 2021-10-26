

namespace Library
{
  //Esta interface fue creada para garantizar lo que debe tener cada nodo family, en caso de crear otra family debera implementar
  //los metodos de aceptar visitor y agregar children a su nodo
    public interface INode
    {
      void Accept(IVisitor visitor);
      void AddChildren(Node person);
      
    }
}