//Write a static class DistanceCalculator with a static method to calculate the distance between two points in the 3D space
using System;

namespace Point3D
{
    class DistanceCalculator
    {
        public static double Distance(Point pointA, Point pointB)
        {
            double deltaX = pointA.CoordinateX - pointB.CoordinateX; 
            double deltaY = pointA.CoordinateY - pointB.CoordinateY;
            double deltaZ = pointA.CoordinateZ - pointB.CoordinateZ;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
                return distance;

        }
    }
}
