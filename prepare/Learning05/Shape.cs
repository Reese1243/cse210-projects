using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

abstract class Shape
{
    string _color = "";

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

    public abstract double GetArea();
   

}