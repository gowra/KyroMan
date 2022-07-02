using System;
using System.Collections.Generic;
using System.Text;

namespace KyroMan.Library.Framework
{
    public class Project : Entity
    {
        internal Project() : this(string.Empty, -1)
        {
        }

        internal Project(string name, int durationInDays) : base()
        {
            Name = name;
            DurationInDays = durationInDays;
        }

        public string Description { get; set; }

        public int DurationInDays { get; }

        public TaskManager Tasks { get; }

        public UserManager Users { get; }

        public ResourceManager Resources { get; }

        public Scheduler Scheduler { get; }
    }
}
