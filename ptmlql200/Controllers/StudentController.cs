using Microsoft.AspNetCore.Mvc; 
namespace ptmlql200.Controllers 
{
    public class StudentController : Controller {
        public IActionResult Index()
        {
            return View();
        }
    }
}
