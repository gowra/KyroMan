using KyroMan.Library.Framework.Model;
using KyroMan.Library.Framework.Types;
using System;
using System.Collections.Generic;

namespace KyroMan.Library.Framework
{
    public class Scheduler
    {
        private readonly TaskManager taskManager;
        private readonly UserManager userManager;
        private readonly ResourceManager resourceManager;

        internal Scheduler(TaskManager taskManager, UserManager userManager, ResourceManager resourceManager)
        {
            this.taskManager = taskManager;
            this.userManager = userManager;
            this.resourceManager = resourceManager;
        }

        public void AssignTask(Task task, User user) => throw new NotImplementedException();

        public void AllocateResource(Task task, Resource resource) => throw new NotImplementedException();

        public IEnumerable<Task> GetTasks(User user) => throw new NotImplementedException();

        public IEnumerable<Task> GetTasks(Status status) => throw new NotImplementedException();

        public int GetEstimatedDuration() => throw new NotImplementedException();
    }
}
