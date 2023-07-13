namespace FactoryPattern
{
    public class ShapeFactory
    {
        public Shape GetShape(string input)
        {
            switch (input)
            {
                case "Circle":
                    return new Circle();
                case "Rectangle":
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}
