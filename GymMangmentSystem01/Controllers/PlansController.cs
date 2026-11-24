using GymMangmentSystem01.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymMangmentSystem01.Controllers
{
    public class PlansController : Controller
    {
        private GymDbContext DbContext = new GymDbContext( );
        public async Task<IActionResult> Index ( )
        {
            var Plans = await DbContext.Plans.ToListAsync ( );
            return View ( Plans );
        }
    }
}
