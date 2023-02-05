using System.Net.Http;
using Newtonsoft.Json;


// for comment code = cmd + /
public class UnsplashAPI
{
    private static readonly HttpClient _client = new HttpClient();

    public IConfiguration _configuration;

    public UnsplashAPI(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<string>> GetUnsplashImageByQuery(string query, int count)
    {

        var data = new List<string>();
        var accessKey = _configuration["UnsplashIntegration:AccessKey"];
        var secretKey = _configuration["UnsplashIntegration:SecretKey"];

        // 10 results per page

        var resultsPerPage = 10;
        var requestCount = count / resultsPerPage;

        // 10 times

        // 3 arguments to loop:
        // - starting point (where the loop starts)
        // - when the loops end
        // - what happen at every iteration

        for (int i = 0; i < requestCount; i++)
        {
            var url = $"https://api.unsplash.com/search/photos?client_id={accessKey}&page={i+1}&query={query}";

            var response = await _client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<UnsplashResponse>(json);
            data.AddRange(result.Results.Select(x => x.Urls.Regular).ToList());
        }

        return data;
    }
}

public class UnsplashResponse
{
    public List<Result> Results { get; set; }
}

public class Result
{
    public Urls Urls { get; set; }
}

public class Urls
{
    public string Regular { get; set; }
}