namespace Interfaces_are_NOT_for_Multiple_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var textbox = new TextBox();
            textbox.Id = 22;
            textbox.Position = new Position(2, 5);
            textbox.Text = "ewrtert";


        }
    }
}
