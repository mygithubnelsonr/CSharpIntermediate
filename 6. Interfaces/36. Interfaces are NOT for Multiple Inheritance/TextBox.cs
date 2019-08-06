namespace Interfaces_are_NOT_for_Multiple_Inheritance
{
    // you can not inherance from more then one class1
    // e.g TextBox : UiControl, Size forces an error
    // Error CS1721  Class 'TextBox' cannot have multiple base classes: 'UiControl' and 'Size'

    public class TextBox : UiControl, IDraggable, IDropable
    {
        public string Text { get; set; }

        public override void Draw()
        {
            base.Draw();
        }

        public override void Focus()
        {
            base.Focus();
        }

        public void Drag()
        {
            throw new System.NotImplementedException();
        }

        public void Drop()
        {
            throw new System.NotImplementedException();
        }

        Position position = new Position(2, 3);

    }
}
