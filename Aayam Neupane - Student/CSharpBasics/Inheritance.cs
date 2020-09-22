using System;
public interface IShapeWithSides
{
    public double GetDiagonal();

}

public abstract class Shape
{
    //Define abstract members when you want derived classes 
    //to force implement their own logic
    public abstract double GetArea();
    public abstract double GetCircumference();

    public virtual void Display(Shape shape)
    {
        Console.WriteLine($"Displaying Result for: {shape}");
    }

    public override void Display()
    {
        Console.WriteLine($"Displaying results for Square with side {Side}:");
        Console.WriteLine($"Area: {this.GetArea()} square unit: ");
        Console.WriteLine($"Circumference: {this.GetCircumference()} unit: ");
    }

    public double GetDiagonal() => Math.Sqrt(2 *Sides*Sides)
}


public class Square : Shape
{
    public Square(double side)
    {
        Side = side;
    }
    public double Side { get; set; }
    public override double GetArea() => Side * Side;

    public override double GetCircumference() => 4 * Side;
}

public class Rectangle : Shape
{
    public Rectangle(double length,double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }
    public override double GetArea() => Length * Breadth;

    public override double GetCircumference() => 2 * (Length + Breadth);
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;

    public override double GetCircumference() => 2 * Math.PI * Radius;
}