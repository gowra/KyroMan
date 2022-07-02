namespace KyroMan.Library.Framework.Model
{
    public class Resource : Entity
    {
        internal Resource() : this(string.Empty)
        {
        }

        internal Resource(string name) : base()
        {
            Name = name;
        }

        public User AllocatedUser { get; }
    }
}
