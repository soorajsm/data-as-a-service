using Daas.Domain.Entities;

namespace Daas.Application.Common.Interfaces;

public interface IAppDbContext
{
    IQueryable<User> Users { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
