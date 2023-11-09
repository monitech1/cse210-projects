using System;
class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapeList = new();

       
        Square redSquare = new("Red", sideLength: 3);
        shapeList.Add(redSquare);

        
        Rectangle blueRectangle = new("Blue", width: 4, height: 5);
        shapeList.Add(blueRectangle);

      
        Circle greenCircle = new("Green", radius: 6);
        shapeList.Add(greenCircle);

        
        foreach (Shape shape in shapeList)
        {
            
            string shapeColor = shape.GetColor();

            
            double shapeArea = shape.GetArea();

            Console.WriteLine($"The {shapeColor} shape has an area of {shapeArea}.");
        }
    }
}
