using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Configuration;

public class ScaniiClient
{
    private readonly HttpClient _http;
    private readonly IConfiguration _config;

    public ScaniiClient(HttpClient http, IConfiguration config)
    {
        _http = http;
        _config = config;
    }

    private void AddBasicAuth(HttpRequestMessage req)
    {
        var key = _config["Scanii:Key"];
        var secret = _config["Scanii:Secret"];

        if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(secret))
            throw new InvalidOperationException("Missing Scanii:Key or Scanii:Secret in configuration.");

        var token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{key}:{secret}"));
        req.Headers.Authorization = new AuthenticationHeaderValue("Basic", token);
    }

    public async Task<string> ScanAsync(Stream fileStream, string fileName, string contentType, CancellationToken ct)
    {
        using var form = new MultipartFormDataContent();
        var fileContent = new StreamContent(fileStream);
        fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
        form.Add(fileContent, "file", fileName);

        var req = new HttpRequestMessage(HttpMethod.Post, "https://api.scanii.com/v2.1/files");
        AddBasicAuth(req);
        req.Content = form;

        var res = await _http.SendAsync(req, ct);
        res.EnsureSuccessStatusCode();
        return await res.Content.ReadAsStringAsync(ct);
    }
}