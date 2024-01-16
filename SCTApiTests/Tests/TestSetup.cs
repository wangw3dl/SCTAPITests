using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SCTApiTestProject.Tests
{
    public class TestSetup
    {
        public const string ApiEndpoint = "https://api.tmsandbox.co.nz/v1/Categories/6327/Details.json?catalogue=false";

        public static async Task<CategoryDetails> InitializeCategoryDetails()
        {
            using var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync(ApiEndpoint);
            return JsonConvert.DeserializeObject<CategoryDetails>(response);
        }
    }
}