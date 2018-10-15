using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shizukanawa.RiotAPI
{
    public class DataDragon
    {
        public static HttpClient client = new HttpClient();

        public static async Task<string> GetDDVersionAsync()
        {
            Uri url = new Uri("https://ddragon.leagueoflegends.com/api/versions.json");
            var jsonData = await client.GetStringAsync(url);
            return jsonData;
        }
    }
}
