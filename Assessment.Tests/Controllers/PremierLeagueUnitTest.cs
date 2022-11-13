using Assessment.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace Assessment.Tests.Controllers
{
    [TestClass]
    public class PremierLeagueUnitTest
    {
            [TestMethod]
            public void Test_Get_List_Of_Fixtures()
            {
                // Arrange
                PremiershipController obj = new PremiershipController();
                // Act
                ViewResult result = obj.PremierLeague() as ViewResult;
                // Assert
                Assert.IsNotNull(result);
            }
            [TestMethod]
            public void GetFixturesById()
            {
                // Arrange
                PremiershipController obj = new PremiershipController();
                // Act
                ViewResult result = obj.GetPremierLeagueByID(5) as ViewResult;
                // Assert
                Assert.IsNotNull(result);
            }
            [TestMethod]
            public void Test_Bottom5_Easy_Games()
            {
            // Arrange
            PremiershipController obj = new PremiershipController();
            // Act
            var result = obj.GetBottom5EasyGames(2) as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            }

            [TestMethod]
            public void Test_Games_Not_In_Bottom5()
            {
            // Arrange
            PremiershipController obj = new PremiershipController();
            // Act
            var result = obj.GetNotBottom5EasyGames(2) as ViewResult;
            //Assert
            Assert.IsNotNull(result);

        }
       
    }
}
