using Newtonsoft.Json;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

public class ImageDto
{
    [JsonProperty("ratio")]
    public string Ratio { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("width")]
    public int Width  { get; set; }

    [JsonProperty("height")]
    public int Height { get; set; }

    [JsonProperty("fallback")]
    public bool Fallback { get; set; }
}
