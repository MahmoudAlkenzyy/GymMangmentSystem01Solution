using Microsoft.AspNetCore.Mvc;

namespace GymMangmentSystem01.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index ( )
        {
            string content = "testawy";
            return View ( "index" , content );
        }
    }
}
