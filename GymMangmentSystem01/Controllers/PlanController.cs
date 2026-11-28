using GymMangmentSystem01.Contexts;
using GymMangmentSystem01.Entities;
using GymMangmentSystem01.Repositories.Classes;
using GymMangmentSystem01.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymMangmentSystem01.Controllers
{
    public class PlanController : Controller
    {
        private IPlanRepository _PlanRepository;
        private IMembershipRepository _MembershipRepository;

        public PlanController ( IPlanRepository PlanRepository , IMembershipRepository Membership )
        {
            _PlanRepository = PlanRepository;
            _MembershipRepository = Membership;
        }
        public async Task<IActionResult> Index ( )
        {
            var Plans = await _PlanRepository.GetAllAsync();
            return View ( Plans );
        }

        [HttpGet]
        public async Task<IActionResult> Edit ( int id , CancellationToken ct )
        {
            var plan = await _PlanRepository.GetPlanByIdAsync ( id , ct );

            if ( plan is null || !plan.IsActive )
            {
                TempData [ "ErrorMessage" ] = "Plan can't be edited.";
                return RedirectToAction ( "Index" );
            }
            var hascurrentMemberships = await _MembershipRepository.AnyAsync ( m => m.PlanId == id&&m.EndDate > DateTime.Now , ct );

            if ( hascurrentMemberships )
            {
                TempData [ "ErrorMessage" ] = "Cannot edit plan with current memberships.";
                return RedirectToAction ( "Index" );
            }
            return View ( plan );
        }
    }
}
