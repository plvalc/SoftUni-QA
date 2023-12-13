using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double _length;
    private double _width;
    private double _height;
    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double Length 
    { 
        get
        {
            return this._length;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException($"Length cannot be zero or negative.");
            this._length = value;
        }
    }
    public double Width
    {
        get
        {
            return this._width;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException($"Width cannot be zero or negative.");
            this._width = value;
        }
    }
    public double Height
    {
        get
        {
            return this._height;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException($"Height cannot be zero or negative.");
            this._height = value;
        }
    }
    
    public double SurfaceArea()
    {
        double area = 2 * Length * Width + 2 * Length * Width + 2 * Width * Height;
        return area;
    }
    public double Volume()
    {
        return this.Length * this.Width * this.Height;
    }
    public override string ToString()
    {
        return $"Surface Area – {this.SurfaceArea():F2}{Environment.NewLine}Volume – {Volume():F2}";
    }

}
