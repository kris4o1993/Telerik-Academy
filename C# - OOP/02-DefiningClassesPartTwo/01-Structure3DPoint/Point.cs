namespace _01_Structure3DPoint
{
    public struct Point
    {
        public double pointX { get; set; }
        public double pointY { get; set; }
        public double pointZ { get; set; }

        private static readonly Point startCoord = new Point(0, 0, 0);

        public Point(double x, double y, double z):this()
        {
            this.pointX = x;
            this.pointY = y;
            this.pointZ = z;
        }

        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Z = {2}", this.pointX, this.pointY, this.pointZ);
        }

        public static Point ZeroCoord()
        {
            return startCoord;
        }

        
    }
}
