using LatestInstagramPostsWithToken.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LatestInstagramPostsWithToken.Services
{
    public class InstagramService
    {
        private readonly HttpClient _client = new HttpClient();
        private const string AccessToken = "IGQVJXdWFSNmNDTDN1NG5JWUMxSE5VM092MTRIb2d2MC1EX0pBcjEweUtHMnZALcXlNQ3BTVGczVHo5WXdmYm1aYkdDVlJPdUpRSnpsZAVU0a3lKLU9xRW0yYXhJRHlRSGZACM2g0VEQyV2dCTW5wSHJMSQZDZD"; // replace with your token

        public async Task<List<InstagramMedia>> FetchRecentMediaAsync()
        {
            try
            {
                var response = await _client.GetStringAsync($"https://graph.instagram.com/me/media?fields=id,caption,media_type,media_url&access_token={AccessToken}"); // Note: I've removed like_count and comments_count for now
                var jsonResponse = JsonConvert.DeserializeObject<InstagramResponse>(response);

                return jsonResponse.Data;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"An error occurred fetching media: {ex.Message}");
                return new List<InstagramMedia>(); // return an empty list or handle it as you see fit
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                return new List<InstagramMedia>();
            }
        }




    }
}
