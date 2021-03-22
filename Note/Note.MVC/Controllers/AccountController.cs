using Microsoft.AspNetCore.Mvc;
using Note.Model;
using Note.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Note.MVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 로그인 전송
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var id = model.UserId;
                var password = model.UserPassword;
            }

            return View();
        }

        #region Helper

        /// <summary>
        /// 페이지 전환(Secure Coding)
        /// </summary>
        /// <param name="returnurl"></param>
        /// <returns></returns>
        private IActionResult RedirctToLocal(string returnurl)
        {
            if (string.IsNullOrWhiteSpace(returnurl))   //문자열 검증 
            {
                return null;
            }

            if (Url.IsLocalUrl(returnurl))   //존재하는 URL인 경우
            {
                return Redirect(returnurl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}
