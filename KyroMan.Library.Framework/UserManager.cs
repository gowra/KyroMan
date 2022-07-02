using System;
using System.Collections.Generic;

namespace KyroMan.Library.Framework
{
    public class UserManager
    {
        private HashSet<User> users;

        internal UserManager()
        {
        }

        public IEnumerable<User> Users => users;

        public User FindUserByName(string name) => throw new NotImplementedException();

        public User AddUser(string name, Role role) => throw new NotImplementedException();

        public void RemoveUser(string name) => throw new NotImplementedException();
    }
}
