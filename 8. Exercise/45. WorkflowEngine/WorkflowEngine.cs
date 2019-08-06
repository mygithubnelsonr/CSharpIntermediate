using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (ITask task in workFlow.GetTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (Exception)
                {
                    // Logging
                    // terminate and persist the state of workflow
                    throw;
                }
            }
        }
    }
}