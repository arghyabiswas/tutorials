using System;
using System.Data;
using ADO.NETTutorial.DataAccess;
using ADO.NETTutorial.DataAccess.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 
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
        public void Delete_Test() {
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            bool isDeleted=dataHandler.Delete(47);

            Assert.IsTrue(isDeleted);
        }

        [TestMethod]
        public void AddEditProject_Test() {

            ProjectDataHandler dataHandler = new ProjectDataHandler();

            Project project = new Project();
            project.Id = 1;
            project.Name = "Ashirwad";
            project.Description = "Bhubaneswar to Chennai";
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now.AddDays(10);
            project.IsActive = true;

            bool isSuccess = dataHandler.AddEditProject(project);

            Assert.IsTrue(isSuccess);

        }

        [TestMethod]
        public void CountTotal_Test() {
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            int Count = dataHandler.CountTotal();
            bool isCount;
            if (Count >= 0)
                isCount = true;
            else
                isCount = false;
            Assert.IsTrue(isCount);

        }

        //[TestMethod]
        //public void LoadByID_Test() {

        //    ProjectDataHandler dataHandler = new ProjectDataHandler();

        //    var p = dataHandler.LoadProjectById(5);

        //    bool isFound;

        //    if (p.Name.is'Assem')
        //        isFound = true;
        //    else
        //        isFound = false;

        //    Assert.IsTrue(isFound);
        //}


    }
}
