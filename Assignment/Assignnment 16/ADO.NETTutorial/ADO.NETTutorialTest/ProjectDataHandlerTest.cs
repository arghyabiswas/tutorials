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
            //Arrange
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            bool isConnected = dataHandler.IsConnected();

            //Assert
            Assert.IsTrue(isConnected);
        }

        [TestMethod]
        public void LoadAllProjects_Test()
        {
            //Arrange
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            DataTable dtProject = dataHandler.LoadAllProjects();

            //Assert
            Assert.IsNotNull(dtProject);
        }

        [TestMethod]
        public void AddProjects_Test()
        {
            //Arrange
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            Project project = new Project();

            project.Name = "ADO.NET Tutorial - " + DateTime.Now.ToString();
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now.AddDays(3);
            project.Description = "Trainee";
            project.IsActive = true;
            bool isSuccess = dataHandler.AddProject(project);

            //Assert
            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void LoadProjectById_Test()
        {
            //Arrange
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            Project project = dataHandler.LoadProjectById(1002);

            //Assert
            Assert.IsNotNull(project);
        }

        [TestMethod]
        public void Delete_Test()
        {
            //Arrange
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            bool delete = dataHandler.Delete(1005);

            //Assert
            Assert.IsTrue(delete);
        }

        [TestMethod]
        public void CountTotal_Test()
        {
            //Arrange
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            bool IsSuccess = false;
            if(dataHandler.CountTotal()!=0)
            {
                IsSuccess = true;
            }

            //Assert
            Assert.IsTrue(IsSuccess);
        }
    }
}
