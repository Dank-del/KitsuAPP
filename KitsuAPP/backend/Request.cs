using Newtonsoft.Json;
using System.Net.Http;

namespace KitsuAPP.backend
{
    class Request
    {
        public static async System.Threading.Tasks.Task<Root> ApiRequestAsync(string param)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync(string.Format("https://kitsu.io/api/edge/anime?filter[text]={0}&page[limit]=1", param));
            var data = JsonConvert.DeserializeObject<Root>(json);
            return data;
        }
    }
}
