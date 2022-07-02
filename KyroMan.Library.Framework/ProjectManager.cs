using System;
using System.Collections.Generic;
using KyroMan.Library.Framework.Model;

namespace KyroMan.Library.Framework
{
    public class ProjectManager
    {
        private readonly HashSet<Project> projects;

        public static ProjectManager Default = new ProjectManager();

        private ProjectManager()
        {
            this.projects = new HashSet<Project>();
        }

        public Project CreateProject(string name, int duration) => throw new NotImplementedException();

        public void RemoveProject(string name) => throw new NotImplementedException();
    }
}
