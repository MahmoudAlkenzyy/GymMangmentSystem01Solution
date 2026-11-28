using GymMangmentSystem01.Contexts;
using GymMangmentSystem01.Entities;
using GymMangmentSystem01.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymMangmentSystem01.Repositories.Classes
{
    public class PlanRepository : IPlanRepository
    {

        private GymDbContext _DbContext;
        public PlanRepository ( GymDbContext dbContext )
        {
            _DbContext = dbContext;
        }
        public async Task<IEnumerable<Plan>> GetAllAsync ( CancellationToken cn = default )
        {
            return await _DbContext.Plans.AsNoTracking ( ).ToListAsync ( cn );
        }

        public Task<Plan?> GetPlanByIdAsync ( int id , CancellationToken ct = default )
        {
            return _DbContext.Plans.FindAsync ( [ id ] , cancellationToken: ct );
        }
    }
}
