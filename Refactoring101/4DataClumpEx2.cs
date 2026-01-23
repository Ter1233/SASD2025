using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.DataClump2;

// 4.2
public class DataClump2
{
    public Point AddPoint(Point a,Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }
}

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}