using GymMangmentSystem01.Entities;

namespace GymMangmentSystem01.Repositories.Interfaces
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> GetAllAsync ( CancellationToken ct = default );
        Task<Plan?> GetPlanByIdAsync ( int id , CancellationToken ct = default );
    }
}
