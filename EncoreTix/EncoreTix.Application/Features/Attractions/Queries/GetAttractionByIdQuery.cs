using EncoreTix.Core.Models;
using MediatR;

namespace EncoreTix.Application.Features.Attractions.Queries;

public record GetAttractionByIdQuery(string Id) : IRequest<Attraction>;