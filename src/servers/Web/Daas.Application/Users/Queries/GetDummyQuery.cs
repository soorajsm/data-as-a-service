
using Daas.Domain.Entities;
using MediatR;
namespace Daas.Application.Users.Queries;



    public record GetDummyQuery : IRequest<Dummy>;
