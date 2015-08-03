using System;


namespace Point3D
{
    class Point
    {
        public static readonly Point startingPoint = new Point(0,0,0);

        private double coordinateX;
        private double coordinateY;
        private double coordinateZ;

        public Point(double coordinateX, double coordinateY, double coordinateZ)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.CoordinateZ = coordinateZ;
        }

        public double CoordinateX 
        {
            get { return this.coordinateX; }
            set { this.coordinateX = value; } 
        }
        public double CoordinateY
        {
            get { return this.coordinateY; }
            set { this.coordinateY = value; }
        }
        public double CoordinateZ
        {
            get { return this.coordinateZ; }
            set { this.coordinateZ = value; }
        }

        public override string ToString()
        {
            return string.Format("Point with coordinates: x = {0}, y = {1}, z = {2}", this.coordinateX, this.coordinateY, this.coordinateZ);
        }
    }
}
