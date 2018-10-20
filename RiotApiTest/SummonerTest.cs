using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shizukanawa.RiotAPI;
using System;

namespace RiotApiTest
{
    [TestClass]
    public class SummonerTest
    {
        const string naEndpoint = "na1.api.riotgames.com";
        const string euwEndpoint = "euw1.api.riotgames.com";
        const string euneEndpoint = "eun1.api.riotgames.com";
        const string brEndpoint = "br1.api.riotgames.com";
        const string krEndpoint = "kr.api.riotgames.com";
        const string la1Endpoint = "la1.api.riotgames.com";
        const string la2Endpoint = "la2.api.riotgames.com";
        const string trEndpoint = "tr1.api.riotgames.com";
        const string oceEndpoint = "oc1.api.riotgames.com";
        const string jpEndpoint = "jp1.api.riotgames.com";
        const string ruEndpoint = "ru.api.riotgames.com";
        const string pbeEndpoint = "pbe1.api.riotgames.com";

        [TestMethod]
        public void GetSummoner_ReturnsNotNull()
        {
            // Arrange
            Uri url = new Uri("https://euw1.api.riotgames.com/lol/summoner/v3/summoners/by-name/acewat");
            var summoner = new Summoner();

            //  Act
            var result = summoner.GetSummonerAsync(url);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetRegion_ReturnsNAEndpoint()
        {
            // Arrange
            var region = new Summoner();

            // Act
            var result = region.GetRegion("na");

            // Assert
            Assert.AreEqual(naEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsEUWEndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("euw");

            Assert.AreEqual(euwEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsEUNEEndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("eune");

            Assert.AreEqual(euneEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsBREndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("br");

            Assert.AreEqual(brEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsKREndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("kr");

            Assert.AreEqual(krEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsLANEndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("lan");

            Assert.AreEqual(la1Endpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsLASEndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("las");

            Assert.AreEqual(la2Endpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsTREndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("tr");

            Assert.AreEqual(trEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsOCEEndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("OCE");

            Assert.AreEqual(oceEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsJPEndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("jp");

            Assert.AreEqual(jpEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsRUEndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("ru");

            Assert.AreEqual(ruEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsPBEEndpoint()
        {
            var region = new Summoner();

            var result = region.GetRegion("PbE");

            Assert.AreEqual(pbeEndpoint, result);
        }

        [TestMethod]
        public void GetRegion_ReturnsInvalidRegion()
        {
            var region = new Summoner();

            var result = region.GetRegion("fakeregion");

            Assert.AreEqual("invalidregion", result);
        }
    }
}
