using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiService
{
    private static readonly HttpClient client = new HttpClient();

    public async Task<string> AuthAsync(string token, string user)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(token), "token");
        formData.Add(new StringContent(user), "user");

        var response = await client.PostAsync("http://46.101.135.102:8004/auth", formData);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> RasumeAsync(string token, string user)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(token), "token");
        formData.Add(new StringContent(user), "user");

        var response = await client.PostAsync("http://46.101.135.102:8004/rasume", formData);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> StopAsync(string token, string user)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(token), "token");
        formData.Add(new StringContent(user), "user");

        var response = await client.PostAsync("http://46.101.135.102:8004/stop", formData);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> CancelAsync(string token, string user)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(token), "token");
        formData.Add(new StringContent(user), "user");

        var response = await client.PostAsync("http://46.101.135.102:8004/cancel", formData);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> SendAsync(string token, string user, string content, string contacts, bool isRandomCode, bool isFile, byte[] fileData = null)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(token), "token");
        formData.Add(new StringContent(user), "user");
        formData.Add(new StringContent(content), "content");
        formData.Add(new StringContent(contacts), "contacts");
        formData.Add(new StringContent(isRandomCode.ToString()), "is_random_code");
        formData.Add(new StringContent(isFile.ToString()), "is_file");
        
        if (fileData != null)
        {
            var fileContent = new ByteArrayContent(fileData);
            formData.Add(fileContent, "file", "filename");
        }

        var response = await client.PostAsync("http://46.101.135.102:8004/send", formData);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> ResetAsync(string token, string user)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(token), "token");
        formData.Add(new StringContent(user), "user");

        var response = await client.PostAsync("http://46.101.135.102:8004/reset", formData);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> NewQrAsync(string token, string user)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(token), "token");
        formData.Add(new StringContent(user), "user");

        var response = await client.PostAsync("http://46.101.135.102:8004/newqr", formData);
        return await response.Content.ReadAsStringAsync();
    }
}
