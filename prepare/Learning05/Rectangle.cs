public class Rectangle : Shape
{
    private double _length; 
    private double _width;  
    private int width;
    private int height;

    public Rectangle(string color, int width, int height) : base(color)
    {
        this.width = width;
        this.height = height;
    }

    public Rectangle(string color, double length, double width, int height) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}
