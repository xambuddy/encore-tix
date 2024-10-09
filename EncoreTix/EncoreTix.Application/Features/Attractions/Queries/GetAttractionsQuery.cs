using EncoreTix.Core.Models;
using MediatR;

namespace EncoreTix.Application.Features.Attractions.Queries;

public record GetAttractionsQuery(int Size = 20, int Page = 0, string? Keyword = null) : IRequest<IEnumerable<Attraction>>;