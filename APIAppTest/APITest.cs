using System;
using System.Configuration;
using ConsoleAPIApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APIAppTest
{
    [TestClass]
    public class APITest
    {
        public SettingsModel getCredentials()
        {
            SettingsModel settings = new SettingsModel();
            settings.url = "https://api.tfl.gov.uk/Road/";
            settings.appId = "";
            settings.developerKey = "";
            return settings;
        }

        [TestMethod]
        public void TestA2()
        {
            // Act
            bool result = new ConsoleAPIApp.Repositories.RoadRepository().roadStatus("A2", getCredentials());

            // Assert 
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestInvalidRoad()
        {
            // Act
            bool result = new ConsoleAPIApp.Repositories.RoadRepository().roadStatus("A23333", getCredentials());

            // Assert 
            Assert.AreEqual(result, false);
        }

    }
}
