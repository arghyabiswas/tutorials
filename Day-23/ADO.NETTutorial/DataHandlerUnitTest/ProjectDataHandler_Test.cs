using System;
using System.Data;
using System.Data.SqlClient;
using ADO.NETTutorial.DataAccess;
using ADO.NETTutorial.DataAccess.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DataHandlerUnitTest
{
    [TestClass]
    public class ProjectDataHandler_Test
    {
        /// <summary>
        /// Test Cases for IsConnected Method
        /// </summary>
        [TestMethod]
        public void IsConnected_Test()
        {
            //Arragnge
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act

            bool isSuccess = dataHandler.IsConnected();

            //Assert

            Assert.IsTrue(isSuccess, "Connected to the Database");
        }



        /// <summary>
        /// Test Cases for LoadAllProjects Method
        /// </summary>
        [TestMethod]
        public void LoadAllProjects_Test()
        {

            //Arranger
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            DataTable dataTable = new DataTable();
            dataTable = dataHandler.LoadAllProjects();
            bool isComplete = true;

            foreach (DataRow data in dataTable.Rows)
            {

                if (Convert.ToBoolean(data["IsActive"]))
                {
                    isComplete = false;
                    break;
                }
            }


            //Assert

            //DataTable is Not Null
            Assert.IsNotNull(dataTable, "Object Is not NULL");

            //Atleast One Project is Active
            Assert.IsFalse(isComplete, "There is an Active Project");


        }


        /// <summary>
        /// Test Cases for AddEditProject() Method
        /// </summary>

        [TestMethod]
        public void AddEditProject_Test()
        {
            //Arrange

            ProjectDataHandler dataHandler = new ProjectDataHandler();
            Project project = new Project();
            project.Name = "Nikolash";
            project.IsActive = true;
            project.EndDate = DateTime.Now.AddDays(10);
            project.StartDate = DateTime.Now;
            project.Description = "Any";

            //Act
            bool isSuccess = dataHandler.AddEditProject(project);


            //Assert
            Assert.IsTrue(isSuccess, "One Item Inserted");
        }



        /// <summary>
        /// Test Cases for LoadProjectById() Method
        /// </summary>

        [TestMethod]
        public void LoadProjectById_Test()
        {
            //Arranger
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            Project project = dataHandler.LoadProjectById(12);

            //Assert
            Assert.IsNotNull(project,"One Item Selected");
        }


        /// <summary>
        /// Test Cases for CountTotal() Method
        /// </summary>

        [TestMethod]
        public void CountTotal_Test()
        {
            //Arranger
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            int totalProject = dataHandler.CountTotal();

            //Assert
            Assert.IsTrue(totalProject > 0, "There is Some Data Present in the Database");
        }


        /// <summary>
        /// Test Cases for Delete() Method
        /// </summary>

        [TestMethod]
        public void Delete_Test()
        {
            //Arranger
            ProjectDataHandler dataHandler = new ProjectDataHandler();

            //Act
            bool isDeleted = dataHandler.Delete(10);

            //Assert
            Assert.IsTrue(isDeleted, "Project Details is Deleted");
        }


    }
}
