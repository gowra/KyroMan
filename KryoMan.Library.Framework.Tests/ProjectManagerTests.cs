using KyroMan.Library.Framework;
using KyroMan.Library.Framework.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KryoMan.Library.Framework.Tests
{
    [TestClass]
    public class ProjectManagerTests
    {
        [TestMethod]
        public void CheckFeasibility()
        {
            var project = ProjectManager.Default.CreateProject("Test", 30);
            var manager = project.Users.AddUser("Manager", Role.Any);

            var dev1 = project.Users.AddUser("Dev 1", Role.Developer);
            var dev2 = project.Users.AddUser("Dev 2", Role.Developer);
            var qa1 = project.Users.AddUser("QA 1", Role.Tester);
            var devops = project.Users.AddUser("Devops 1", Role.DevOps);

            var resource1 = project.Resources.AddResource("Resource 1");

            var feature1 = project.Tasks.CreateTask("Feature 1", "", manager);
            feature1.Estimate = 3;
            feature1.RequiredRole = Role.Developer;

            var feature2 = project.Tasks.CreateTask("Feature 2", "", manager);
            feature2.Estimate = 5;
            feature2.RequiredRole = Role.Developer;
            feature2.RequiredResource = resource1;

            var feature3 = project.Tasks.CreateTask("Feature 2 test", "", manager);
            feature3.Estimate = 5;
            feature3.RequiredRole = Role.Tester;
            feature3.RequiredResource = resource1;
            feature3.AddDependentTask(feature2);

            var installerTask = project.Tasks.CreateTask("Installer", "", manager);
            installerTask.Estimate = 3;
            installerTask.RequiredRole = Role.DevOps;

            project.Scheduler.AssignTask(feature1, dev1);
            
            project.Scheduler.AssignTask(feature2, dev2);
            project.Scheduler.AllocateResource(feature2, resource1);
            
            project.Scheduler.AssignTask(feature3, qa1);

            project.Scheduler.AssignTask(installerTask, devops);

            var estimate = project.Scheduler.GetEstimatedDuration();

            Assert.IsTrue(estimate <= project.DurationInDays);
        }
    }
}
