public class Square : Shape
{
    private double _side;

    public Square(string color, int sideLength) : base(color)
    {
        SideLength = sideLength;
    }

    public Square(string color, double side, int sideLength) : base (color)
    {
        _side = side;
    }

    public int SideLength { get; }

    public override double GetArea()
    {
        return _side * _side;
    }
}