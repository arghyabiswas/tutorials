using System;
using System.Data;
using ADO.NETTutorial.DataAccess;
using ADO.NETTutorial.DataAccess.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADO.NETTutorialTest
{
    [TestClass]
    public class ProjectDataHandlerTest
    {
        [TestMethod]
        public void IsConnected_Test()
        {
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            bool isConnected = dataHandler.IsConnected();

            Assert.IsTrue(isConnected);
        }

        [TestMethod]
        public void LoadAllProjects_Test()
        {
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            DataTable dtProject = dataHandler.LoadAllProjects();

            Assert.IsNotNull(dtProject);
        }

        [TestMethod]
        public void AddProjects_Test()
        {
            ProjectDataHandler dataHandler = new ProjectDataHandler();
            Project project = new Project();

            project.Name = "ADO.NET Tutorial - " + DateTime.Now.ToString();
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now.AddDays(3);

            bool isSuccess = dataHandler.AddEditProject(project);

            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void LoadProjectById_Test()
        {
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            Project project = dataHandler.LoadProjectById(1);

            Assert.IsNotNull(project);
        }
    }
}
