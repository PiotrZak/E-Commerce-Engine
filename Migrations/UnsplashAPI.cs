//using System.Net.Http;
//using Newtonsoft.Json;


//// for comment code = cmd + /
//public class UnsplashAPI
//{
//    private static readonly HttpClient _client = new HttpClient();
//    private const string _apiKey = "YOUR_API_KEY";
//    private const string _baseUrl = "https://api.unsplash.com/search/photos?query=hotel";

//    public async Task<List<string>> GetHotelImages()
//    {
//        var requestUrl = $"{_baseUrl}&client_id={_apiKey}";
//        var response = await _client.GetAsync(requestUrl);
//        var json = await response.Content.ReadAsStringAsync();

//        var result = JsonConvert.DeserializeObject<UnsplashResponse>(json);

//        return result.Results.Select(x => x.Urls.Regular).ToList();
//    }
//}

//public class UnsplashResponse
//{
//    public List<Result> Results { get; set; }
//}

//public class Result
//{
//    public Urls Urls { get; set; }
//}

//public class Urls
//{
//    public string Regular { get; set; }
//}