using GymMangmentSystem01.Contexts;
using GymMangmentSystem01.Entities;
using GymMangmentSystem01.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GymMangmentSystem01.Repositories.Classes
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly  GymDbContext _dbContext;
        public MembershipRepository ( GymDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public GymDbContext DbContext { get; }

        public async Task<bool> AnyAsync ( Expression<Func<MemberShip , bool>> predicate , CancellationToken ct = default )
        {
            return await _dbContext.MemberShips.AnyAsync ( predicate , ct );
        }
    }
}
