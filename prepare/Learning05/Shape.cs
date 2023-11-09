public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // The GetArea method is declared as an abstract method. This means it's a method
    // that must be implemented in any class that inherits from Shape. It does not make
    // sense to provide a default implementation in the base class because each shape
    // has a different way to calculate its area.
    public abstract double GetArea();
}
