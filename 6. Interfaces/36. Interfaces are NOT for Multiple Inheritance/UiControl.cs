namespace Interfaces_are_NOT_for_Multiple_Inheritance
{
    public class UiControl
    {
        public int Id { get; set; }
        public Size Size { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }

        public virtual void Focus()
        {

        }
    }
}
