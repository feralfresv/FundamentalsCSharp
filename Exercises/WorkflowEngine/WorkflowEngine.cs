using System.Collections.Generic;
namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        private readonly IList<IActivity> _activity;
        public WorkflowEngine()
        {
            _activity = new List<IActivity>();
        }
        public void Run()
        {
            foreach (var item in _activity)
            {
                item.Execute();
            }
        }

        public void RegisterNotificationChannel(IActivity activity)
        {
            _activity.Add(activity);
        }
    }
}
