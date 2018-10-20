using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Shizukanawa.RiotAPI
{
    public class Summoner
    {
        public static HttpClient client = new HttpClient();
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

        public async Task<string> GetSummonerAsync(Uri url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            string jsonData;
            if (response.IsSuccessStatusCode) return jsonData = await Task.Run(() => response.Content.ReadAsStringAsync());
            if ((int)response.StatusCode == (int)HttpStatusCodes.BadRequest) return "badrequest";
            if ((int)response.StatusCode == (int)HttpStatusCodes.Unauthorized) return "unauthorized";
            if ((int)response.StatusCode == (int)HttpStatusCodes.Forbidden) return "forbidden";
            if ((int)response.StatusCode == (int)HttpStatusCodes.DataNotFound) return "datanotfound";
            if ((int)response.StatusCode == (int)HttpStatusCodes.MethodNotAllowed) return "methodnotallowed";
            if ((int)response.StatusCode == (int)HttpStatusCodes.UnsupportedMediaType) return "unsupportedmediatype";
            if ((int)response.StatusCode == (int)HttpStatusCodes.PlayerExistNoMatch) return "playerexistnomatch";
            if ((int)response.StatusCode == (int)HttpStatusCodes.RateLimitExceeded) return "ratelimitexceeded";
            if ((int)response.StatusCode == (int)HttpStatusCodes.InternalServerError) return "internalservererror";
            if ((int)response.StatusCode == (int)HttpStatusCodes.BadGateway) return "badgateway";
            if ((int)response.StatusCode == (int)HttpStatusCodes.ServiceUnavailable) return "serviceunavailable";
            if ((int)response.StatusCode == (int)HttpStatusCodes.GatewayTimeout) return "gatewaytimeout";
            return "Unknown Error";
        }

        public string GetRegion(string GiveRegion)
        {
            string region = GiveRegion.ToLower();
            var regions = new Dictionary<string, string>
            {
                { "na", naEndpoint },
                { "euw", euwEndpoint },
                { "eune", euneEndpoint },
                { "br", brEndpoint },
                { "kr", krEndpoint },
                { "lan", la1Endpoint },
                { "las", la2Endpoint },
                { "tr", trEndpoint },
                { "oce", oceEndpoint },
                { "jp", jpEndpoint },
                { "ru", ruEndpoint },
                { "pbe", pbeEndpoint }
            };

            if (regions.ContainsKey(region))
            {
                return regions[region];
            }
            else
            {
                return "invalidregion";
            }
        }

        public enum HttpStatusCodes
        {
            BadRequest = 400,
            Unauthorized = 401,
            Forbidden = 403,
            DataNotFound = 404,
            MethodNotAllowed = 405,
            UnsupportedMediaType = 415,
            PlayerExistNoMatch = 422,
            RateLimitExceeded = 429,
            InternalServerError = 500,
            BadGateway = 502,
            ServiceUnavailable = 503,
            GatewayTimeout = 504
        }

        public class SummonerData
        {
            public int profileIconId { get; set; }
            public string name { get; set; }
            public int summonerLevel { get; set; }
            public int accountId { get; set; }
            public int id { get; set; }
            public long revisionDate { get; set; }
        }
    }
}
