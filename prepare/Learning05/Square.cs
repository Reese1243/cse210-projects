class Square : Shape
{

    double _side = 0;

    public Square(string Color, double side) : base(Color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

    
}