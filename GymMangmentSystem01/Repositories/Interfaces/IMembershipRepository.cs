using GymMangmentSystem01.Entities;
using System.Linq.Expressions;

namespace GymMangmentSystem01.Repositories.Interfaces
{
    public interface IMembershipRepository
    {
        Task<bool> AnyAsync ( Expression<Func<MemberShip , bool>> predicate , CancellationToken ct = default );
    }
}
