using exemplo2.Entities.Enums;

namespace exemplo2.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); //Método abstrato. Ele é automaticamente considerado como virtual
    }
}