using Microsoft.AspNetCore.Mvc;
using JPP.Web.Controllers;

namespace JPP.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerListController : BaseController
    {
        protected override bool RequireLogin => true;

        public IActionResult Index()
        {
            return View();
        }
    }
}