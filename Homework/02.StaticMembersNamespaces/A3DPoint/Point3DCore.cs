using System;

namespace Point3D
{
    class Point3DCore
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point(3, 4, 5);
            Point secondPoint = new Point(7, 8, 9);
            Point zeroPoint = Point.startingPoint;

            double distance = DistanceCalculator.Distance(firstPoint, secondPoint);
           
            

            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);
            Console.WriteLine(zeroPoint);
            Console.WriteLine("The distance between point {0} and point {1} is: {2:F}", firstPoint, secondPoint,distance);
        }
    }
}
