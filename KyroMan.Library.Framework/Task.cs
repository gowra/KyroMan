namespace KyroMan.Library.Framework
{
    public class Task : Entity
    {
        internal Task() : this(string.Empty, string.Empty, string.Empty)
        { 
        }

        internal Task(string title, string description, string createdBy) : base()
        {
            Title = title;
            Description = description;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; }

        public int Estimate { get; set; }
    }
}
