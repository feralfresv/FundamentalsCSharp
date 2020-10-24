using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            workflowEngine.RegisterNotificationChannel(new FirtActivity());
            workflowEngine.RegisterNotificationChannel(new SecondActivity());
            workflowEngine.Run();
            

        }
    }
}
