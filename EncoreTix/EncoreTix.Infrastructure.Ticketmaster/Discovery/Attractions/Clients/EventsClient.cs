using EncoreTix.Infrastructure.Ticketmaster.Configurations;
using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;
using EncoreTix.Infrastructure.Ticketmaster.Responses.Events;
using Newtonsoft.Json;
using System.Web;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Clients;

public class EventsClient(HttpClient httpClient, TicketmasterConfig ticketmasterConfig) : IEventsClient
{
    public async Task<IEnumerable<EventDto>> SearchEvents(string attractionId, string? keyword = null, int size = 20, int page = 0)
    {
        var uriBuilder = new UriBuilder(httpClient.BaseAddress);

        var query = HttpUtility.ParseQueryString(uriBuilder.Query);

        query["apikey"] = ticketmasterConfig.Apikey;
        query["attractionId"] = attractionId;
        query["size"] = size.ToString();
        query["page"] = page.ToString();

        if (!string.IsNullOrEmpty(keyword))
        {
            query["keyword"] = keyword;
        }

        uriBuilder.Query = query.ToString();

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = uriBuilder.Uri
        };

        using var response = await httpClient.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var eventsResponse = JsonConvert.DeserializeObject<EventsResponse>(content);

        return eventsResponse?.Embedded?.Events ?? new List<EventDto>();
    }
}
