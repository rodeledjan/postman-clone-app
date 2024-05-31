using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(
        string url
        , bool formatOutput = true
    )
    {
        var response = await client.GetAsync(url);

        if (response != null)
        {
            string json = await response.Content.ReadAsStringAsync();

            if (formatOutput)
            {

                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }

            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }

    }
}