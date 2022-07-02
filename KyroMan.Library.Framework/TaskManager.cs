using System;
using System.Collections.Generic;

namespace KyroMan.Library.Framework
{
    public class TaskManager
    {
        private HashSet<Task> tasks;

        internal TaskManager()
        {
        }

        public IEnumerable<Task> Tasks => this.tasks;

        public Task FindTaskById(int id) => throw new NotImplementedException();

        public Task CreateTask(string title, string description, string createdBy) => throw new NotImplementedException();

        public void DeleteTask(int id) => throw new NotImplementedException();
    }
}
