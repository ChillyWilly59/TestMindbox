using System;

namespace TestMindbox
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle(double radius) : IShape
    {
        public double Radius { get; } = radius;

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle(double sideA, double sideB, double sideC) : IShape
    {
        public double SideA { get; } = sideA;
        public double SideB { get; } = sideB;
        public double SideC { get; } = sideC;

        public double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = [SideA, SideB, SideC];
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
