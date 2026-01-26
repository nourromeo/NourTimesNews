using NourTimesNews.Models;
using System.Net.Http.Json;

namespace NourTimesNews.Services
{
    public class NewsService
    {
        private readonly HttpClient httpClient;

        public NewsService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("NourTimesNewsApp");
        }

        public async Task<List<Article>> GetTopHeadlinesAsync(string category)
        {
            var url = $"https://newsapi.org/v2/top-headlines?language=en&category={category}" +
                      $"&pageSize=5&apiKey=5c96e16a58e0424294a29dcfc63ed01a";

            var response = await httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                System.Diagnostics.Debug.WriteLine("API request failed");
                return new List<Article>();
            }

            var result = await response.Content.ReadFromJsonAsync<NewsResponse>();
            return result?.Articles ?? new List<Article>();
        }

    }
}


