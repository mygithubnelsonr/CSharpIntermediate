namespace WorkflowEngine
{
    public class ChangeStatus : ITask
    {
        public void Execute()
        {
            System.Console.WriteLine("Changing a status...");
        }
    }
}