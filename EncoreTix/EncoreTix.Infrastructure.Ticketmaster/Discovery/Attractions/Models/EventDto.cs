using Newtonsoft.Json;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

public class EventDto
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("test")]
    public bool Test { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("locale")]
    public string Locale { get; set; }

    [JsonProperty("images")]
    public List<ImageDto> Images { get; set; }

    [JsonProperty("dates")]
    public DatesDto Dates { get; set; }

    [JsonProperty("_embedded")]
    public EmbeddedDto Embedded { get; set; }
}

public class DatesDto
{
    [JsonProperty("start")]
    public StartDateDto Start { get; set; }

    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    [JsonProperty("status")]
    public DateStatusDto Status { get; set; }
}

public class StartDateDto
{
    [JsonProperty("localDate")]
    public string LocalDate { get; set; }

    [JsonProperty("dateTBD")]
    public bool DateTBD { get; set; }

    [JsonProperty("dateTBA")]
    public bool DateTBA { get; set; }

    [JsonProperty("timeTBA")]
    public bool TimeTBA { get; set; }

    [JsonProperty("noSpecificTime")]
    public bool NoSpecificTime { get; set; }
}

public class DateStatusDto
{
    [JsonProperty("code")]
    public string Code { get; set; }
}
