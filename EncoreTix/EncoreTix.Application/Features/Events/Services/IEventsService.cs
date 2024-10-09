using EncoreTix.Core.Models;

namespace EncoreTix.Application.Features.Events.Services;

public interface IEventsService
{
    Task<IEnumerable<Event>> GetEvents(string attractionId, string? keyword = null, int size = 20, int page = 0);
}
