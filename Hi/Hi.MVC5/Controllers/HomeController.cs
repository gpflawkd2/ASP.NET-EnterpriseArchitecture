using Hi.BLL;
using System.Web.Mvc;

namespace Hi.MVC5.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserBll _userBll;

        public HomeController(UserBll useBll)
        {
            _userBll = useBll;
        }

        public ActionResult Index()
        {
            var list = _userBll.GetUserList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}