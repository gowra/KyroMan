using System;
using System.Collections.Generic;

namespace KyroMan.Library.Framework
{
    public class ResourceManager
    {
        private HashSet<Resource> resources;

        internal ResourceManager()
        {
        }

        public IEnumerable<Resource> Resources => resources;

        public Resource FindResourceByName(string name) => throw new NotImplementedException();

        public Resource AddResource(string name) => throw new NotImplementedException();

        public void DeleteResource(string name) => throw new NotImplementedException();
    }
}
