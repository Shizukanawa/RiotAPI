using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shizukanawa.RiotAPI
{
    public class DataDragon
    {
        public static HttpClient client = new HttpClient();

        public static async Task<string> GetDDVersionAsync(string strRegion)
        {
            string region = GetRegion(strRegion);
            if (region == "InvalidRegion".ToLower())
            {
                return "invalidregion";
            }
            else
            {
                Uri url = new Uri($"https://ddragon.leagueoflegends.com/realms/{region}.json");
                var jsonData = await client.GetStringAsync(url);
                return jsonData;
            }
        }

        public static string GetRegion(string region)
        {
            string[] regions = new string[] { "na", "euw", "eune", "br", "kr", "lan", "las", "tr", "oce", "jp", "ru", "pbe" };
            int position = Array.IndexOf(regions, region);
            if (position == -1)
            {
                return "invalidregion";
            }
            else
            {
                return regions[position];
            }
        }

        public class Realms
        {
            public N n { get; set; }
            public string v { get; set; }
            public string l { get; set; }
            public string cdn { get; set; }
            public string dd { get; set; }
            public string lg { get; set; }
            public string css { get; set; }
            public int profileiconmax { get; set; }
            public object store { get; set; }
        }

        public class N
        {
            public string item { get; set; }
            public string rune { get; set; }
            public string mastery { get; set; }
            public string summoner { get; set; }
            public string champion { get; set; }
            public string profileicon { get; set; }
            public string map { get; set; }
            public string language { get; set; }
            public string sticker { get; set; }
        }
    }
}
