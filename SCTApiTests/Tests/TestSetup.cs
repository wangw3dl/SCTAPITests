using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

public class TestSetup
{
    // Read the API endpoint from appsettings.json using IConfiguration
    public static string ApiEndpoint
    {
        get
        {
            IConfigurationRoot configuration = GetConfiguration();
            return configuration["ApiEndpoint"] ?? throw new InvalidOperationException("ApiEndpoint not found in appsettings.json");
        }
    }

    private static IConfigurationRoot GetConfiguration()
    {
        return new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
    }

    public static async Task<CategoryDetails> InitializeCategoryDetails()
    {
        using var httpClient = new HttpClient();

        var response = await httpClient.GetStringAsync(ApiEndpoint);

        if (response is not null)
        {
            return JsonConvert.DeserializeObject<CategoryDetails>(response);
        }
        else
        {
            // Handle the case where the response is null (optional)
            throw new InvalidOperationException("Response from the API is null.");
        }
    }
}