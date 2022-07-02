namespace KyroMan.Library.Framework.Model
{
    public class Entity
    {
        private static int currentId = 1;

        internal Entity()
        {
            Id = ++currentId;
        }

        public int Id { get; }

        public string Name { get; set; }
    }
}
