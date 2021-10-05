using Microsoft.AspNetCore.Mvc;

namespace cd_c_portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        } // END INDEX ROUTE

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        } // END PROJECTS ROUTE

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        } // END CONTACT ROUTE
    }

}