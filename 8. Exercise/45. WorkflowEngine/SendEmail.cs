namespace WorkflowEngine
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            System.Console.WriteLine("Sending a Email...");
        }
    }
}