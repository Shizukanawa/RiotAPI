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
            string region = Region(strRegion);
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

        public static string Region(string region)
        {
            if (region == "na") return "na";
            if (region == "euw") return "euw";
            if (region == "eune") return "eune";
            if (region == "jp") return "jp";
            if (region == "kr") return "kr";
            if (region == "lan") return "lan";
            if (region == "las") return "las";
            if (region == "br") return "br";
            if (region == "oce") return "oce";
            if (region == "tr") return "tr";
            if (region == "ru") return "ru";
            if (region == "pbe") return "pbe";
            return "invalidregion";
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
