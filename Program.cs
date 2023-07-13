using FactoryPattern;

public class Program
{
    public static void Main(string[] args)
    {
        ShapeFactory shapeFactoryObj = new ShapeFactory();
        Shape shapeObj = shapeFactoryObj.GetShape(input: "Rectangle");
        shapeObj.Draw();

        Console.ReadLine();
    }
}