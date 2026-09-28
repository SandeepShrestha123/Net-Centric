using System;
class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}
class Circle : Shape
{
    double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return 3.14 * radius * radius;
    }
}
class Rectangle : Shape
{
    double l, b;
    public Rectangle(double l, double b)
    {
        this.l = l;
        this.b = b;
    }
    public override double Area()
    {
        return l * b;
    }
}
class Program
{
    static void Main()
    {
        Circle circle = new Circle(30);
        double areaC = circle.Area();
        Rectangle rectangle = new Rectangle(10,25);
        double areaR = rectangle.Area();
        Console.WriteLine("Area of circle = " + areaC + "\nArea of Rectangle = " + areaR);
    }
}
