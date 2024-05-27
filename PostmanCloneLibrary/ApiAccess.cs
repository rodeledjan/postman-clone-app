﻿namespace PostmanCloneLibrary;

public class ApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url)
    {
        var response = await client.GetAsync(url);

        if (response != null)
        {
            string json = await response.Content.ReadAsStringAsync();

            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }

    }
}