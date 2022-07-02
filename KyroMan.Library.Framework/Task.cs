using System.Collections.Generic;

namespace KyroMan.Library.Framework
{
    public class Task : Entity
    {
        private HashSet<Task> dependentTasks;

        internal Task() : this(string.Empty, string.Empty, null)
        { 
        }

        internal Task(string title, string description, User createdBy) : base()
        {
            Title = title;
            Description = description;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public User CreatedBy { get; }

        public int Estimate { get; set; }

        public User AssignedTo { get; set; }

        public Role RequiredRole { get; set; }

        public Resource RequiredResource { get; set; }

        public IEnumerable<Task> DependentTasks => this.dependentTasks;
    }
}
