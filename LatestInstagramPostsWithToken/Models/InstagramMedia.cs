using Newtonsoft.Json;

namespace LatestInstagramPostsWithToken.Models
{
    public class InstagramResponse
    {
        [JsonProperty("data")]
        public List<InstagramMedia> Data { get; set; }
    }

    public class InstagramMedia
    {
        [JsonProperty(nameof(id))]
        public string id { get; set; }
        [JsonProperty(nameof(caption))]
        public string caption { get; set; }
        [JsonProperty(nameof(media_type))]
        public string media_type { get; set; }
        [JsonProperty(nameof(media_url))]
        public string media_url { get; set; }
        [JsonProperty(nameof(like_count))]
        public int like_count { get; set; }
        [JsonProperty(nameof(comments_count))]
        public int comments_count { get; set; }
    }

}
