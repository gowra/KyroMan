namespace KyroMan.Library.Framework.Model
{
    public class User : Entity
    {
        internal User()
        {
        }

        internal User(string name) : base()
        {
            Name = name;
        }
    }
}
