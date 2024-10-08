using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Services;

public interface IEventsService
{
    Task<IEnumerable<EventDto>> SearchEvents(string attractionId, string? keyword = null, int size = 20, int page = 0);
}
