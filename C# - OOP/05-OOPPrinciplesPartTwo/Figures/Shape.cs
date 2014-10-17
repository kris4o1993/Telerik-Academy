namespace Figures
{
    public abstract class Shape
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public double Width { get; private set; }
        public double Height { get; private set; }


        /// <summary>
        /// Methods
        /// </summary>
        public abstract double CalculateSurface();
    }
}
