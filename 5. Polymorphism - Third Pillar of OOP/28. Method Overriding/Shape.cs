namespace Method_Overriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        // we don't need the ShapeType enumeration after 
        // we create the circle and the rectangle class
        // public ShapeType Type { get; set; }

        public virtual void Draw()
        {

        }

    }
}
