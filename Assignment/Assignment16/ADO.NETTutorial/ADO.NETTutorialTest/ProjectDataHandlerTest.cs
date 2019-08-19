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
        /// <summary>
        /// Test Method For Check whether Connected Or Not
        /// </summary>
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

        /// <summary>
        /// Test Method For Check whether AllProjects Loaded Or Not
        /// </summary>

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

        /// <summary>
        /// Test Method For Check insert into database or not
        /// </summary>

        [TestMethod]
        public void AddEditProjects_Test()
        {
            //Arrange
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            Project project = new Project();

            project.Name = "dpak" ;
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now.AddDays(3);
            project.Description = "excellent";
            project.IsActive = true;

            bool isSuccess = dataHandler.AddEditProject(project);

            //Assert
            Assert.IsTrue(isSuccess,"Data Inserted Successfully.....");
        }


        /// <summary>
        /// Test Method For Checking data by id
        /// </summary>

        [TestMethod]
        public void LoadProjectById_Test()
        {
            //Arrange
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            Project project = dataHandler.LoadProjectById(2);

            //Assert
            Assert.IsNotNull(project);
        }

        /// <summary>
        /// Test Method For Checking total data in database
        /// </summary>

        [TestMethod]
        public void CountTotal_Test()
        {
            //Arrange
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            int x = dataHandler.CountTotal();

            //Assert
            Assert.IsTrue(Convert.ToBoolean(x));

        }

        /// <summary>
        /// Test Method For Check delete data by Id
        /// </summary>

        [TestMethod]
        public void Delete_Test()
        {
            //Arrange
            ProjectDataHandler projectHandler = new ProjectDataHandler();

            //Act
            bool isDelete = projectHandler.Delete(19);


            //Assert
            Assert.IsTrue(isDelete, "Data Deleted...");
            
        }
    }
}
