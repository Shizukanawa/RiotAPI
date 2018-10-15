using System;
using System.Net.Http;
using System.Threading.Tasks;

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
        const string ocEndpoint = "oc1..api.riotgames.com";
        const string jpEndpoint = "jp1.api.riotgames.com";
        const string ruEndpoint = "ru.api.riotgames.com";

        public static async Task<string> GetSummonerAsync(Uri url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            string jsonData;
            if (response.IsSuccessStatusCode) return jsonData = await Task.Run(() => response.Content.ReadAsStringAsync());
            if ((int)response.StatusCode == (int)HttpStatusCodes.BadRequest) return "badrequest".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.Unauthorized) return "unauthorized".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.Forbidden) return "forbidden".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.DataNotFound) return "datanotfound".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.MethodNotAllowed) return "methodnotallowed".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.UnsupportedMediaType) return "unsupportedmediatype".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.PlayerExistNoMatch) return "playerexistnomatch".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.RateLimitExceeded) return "ratelimitexceeded".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.InternalServerError) return "internalservererror".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.BadGateway) return "badgateway".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.ServiceUnavailable) return "serviceunavailable".ToLower();
            if ((int)response.StatusCode == (int)HttpStatusCodes.GatewayTimeout) return "gatewaytimeout".ToLower();
            return "Unknown Error";
        }

        public static string GetRegion(string region)
        {
            if (region == "na".ToLower())
            {
                region = naEndpoint;
                return region;
            }
            else if (region == "euw".ToLower())
            {
                region = euwEndpoint;
                return region;
            }
            else if (region == "eune".ToLower())
            {
                region = euneEndpoint;
                return region;
            }
            else if (region == "br".ToLower())
            {
                region = brEndpoint;
                return region;
            }
            else if (region == "kr".ToLower())
            {
                region = krEndpoint;
                return region;
            }
            else if (region == "la1".ToLower())
            {
                region = la1Endpoint;
                return region;
            }
            else if (region == "la2".ToLower())
            {
                region = la2Endpoint;
                return region;
            }
            else if (region == "tr".ToLower())
            {
                region = trEndpoint;
                return region;
            }
            else if (region == "oc".ToLower())
            {
                region = ocEndpoint;
                return region;
            }
            else if (region == "jp".ToLower())
            {
                region = jpEndpoint;
                return region;
            }
            else if (region == "ru".ToLower())
            {
                region = ruEndpoint;
                return region;
            }
            else
            {
                return "Invalid Region";
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
