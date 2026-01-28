using System.Reflection.Metadata;
using Daas.Domain.Entities;
using MediatR;
namespace Daas.Application.Users.Queries;


public class GetDummyQueryHandler : IRequestHandler<GetDummyQuery,Dummy>
{
    public GetDummyQueryHandler(){}
    public Dummy givedummydata()
    {
        var dummy = new Dummy();
        dummy.name = "aakash";
        dummy.address = "123";
        return dummy;
    }

    public Task<Dummy> Handle(GetDummyQuery request,CancellationToken cancellation)
    {
        var dummy = givedummydata();
        return Task.FromResult(dummy);
    }
    
}