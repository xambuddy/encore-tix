using EncoreTix.Core.Models;
using MediatR;

namespace EncoreTix.Application.Features.Events.Queries;

public record GetEventsQuery(string AttractionId, int Size = 20, int Page = 0, string? Keyword = null) : IRequest<IEnumerable<Event>>;