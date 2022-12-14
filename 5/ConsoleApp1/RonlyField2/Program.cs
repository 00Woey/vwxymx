//불변타입 클래스 - Point

using System;
public class Point
{
    int x, y;

    public int X { get { return x; } }
    public int Y { get { return y; } }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

namespace RonlyField2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Point pt = new Point(5, 10);
            Point pt2 = new Point(pt.X + 1, pt.Y + 1);
        }
    }
}