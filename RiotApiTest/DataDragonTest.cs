using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using Shizukanawa.RiotAPI;

namespace RiotApiTest
{
    [TestClass]
    public class DataDragonTest
    {
        [TestMethod]
        public void DDVersionAsync_ReturnsVersion()
        {
            // Arrange
            var dd = new DataDragon();
            Uri url = new Uri($"https://ddragon.leagueoflegends.com/realms/euw.json");
            HttpClient client = new HttpClient();

            //Act
            var jsondata = client.GetStringAsync(url).GetAwaiter().GetResult();
            var result = dd.GetDDVersionAsync("euw").GetAwaiter().GetResult();

            //Assert
            Assert.AreEqual(jsondata, result);
        }

        [TestMethod]
        public void DDVersionAsync_ReturnsInvalidRegion()
        {
            var dd = new DataDragon();

            var result = dd.GetDDVersionAsync("hi").GetAwaiter().GetResult();

            Assert.AreEqual("invalidregion", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsNA()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("na");

            Assert.AreEqual("na", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsEUW()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("euw");

            Assert.AreEqual("euw", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsEUNE()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("eune");

            Assert.AreEqual("eune", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsBR()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("br");

            Assert.AreEqual("br", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsKR()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("KR");

            Assert.AreEqual("kr", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsLAN()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("lan");

            Assert.AreEqual("lan", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsLAS()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("las");

            Assert.AreEqual("las", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsOCE()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("OCE");

            Assert.AreEqual("oce", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsJP()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("JP");

            Assert.AreEqual("jp", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsRU()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("Ru");

            Assert.AreEqual("ru", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsPBE()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("pbe");

            Assert.AreEqual("pbe", result);
        }

        [TestMethod]
        public void GetRegion_ReturnsInvalidRegion()
        {
            var dd = new DataDragon();

            var result = dd.GetRegion("hi");

            Assert.AreEqual("invalidregion", result);
        }
    }
}
