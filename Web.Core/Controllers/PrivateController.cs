using Microsoft.AspNetCore.Mvc;

using Auth;

namespace Web.Framework.Controllers
{
    [CustomAuthorize]
    public class PrivateController : Controller
    {
        // GET: Private
        public ActionResult Index()
        {
            return View();
        }
    }
}