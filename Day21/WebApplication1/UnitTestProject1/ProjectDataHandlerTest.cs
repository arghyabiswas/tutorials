using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.DataAccess;
using WebApplication1.DataAccess.Modules;

namespace UnitTestProject1
{
    [TestClass]
    public class ProjectDataHandlerTest
    {
        [TestMethod]
        public void IsConnected_Test()
        {
            // Arrange
            string dbConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(dbConnectionString);
            ProjectDataHandler projectDataHandler = new ProjectDataHandler(connection);

            // Act
            bool isConnected = projectDataHandler.IsConnected();

            //Assert
            Assert.IsTrue(isConnected, "IsConnected is true");
        }

        [TestMethod]
        public void LoadAllProjects_Test()
        {
            ProjectDataHandler projectDataHandler = new ProjectDataHandler();

            DataTable dtProjects = projectDataHandler.LoadAllProjects();

            bool hasRow = false;
            if (dtProjects != null && dtProjects.Rows.Count > 0)
            {
                hasRow = true;
            }

            Assert.IsTrue(hasRow);

            Assert.AreEqual(8, dtProjects.Rows.Count);
        }

        [TestMethod]
        public void LoadProjectById_Test()
        {
            ProjectDataHandler projectDataHandler = new ProjectDataHandler();
            Project project = projectDataHandler.LoadProjectById(1);

            Assert.IsNotNull(project);
            Assert.AreEqual("ADO.NET Tutorial", project.Name);
        }
    }
}
