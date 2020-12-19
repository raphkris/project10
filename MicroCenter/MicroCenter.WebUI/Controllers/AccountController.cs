using System.Web.Mvc;
using MicroCenter.WebUI.Models;
using MicroCenter.WebUI.Infrastructure.Abstract;

namespace MicroCenter.WebUI.Controllers
{
    public class AccountController : Controller
    {
        IAuthProvider authProvider;

        public AccountController(IAuthProvider auth)
		{
            authProvider = auth;
		}

        public ViewResult Login()
		{
            return View();
		}

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
		{
            if (ModelState.IsValid)
			{
                if(authProvider.Authenticate(model.UserName, model.Password))
				{
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
				}
				else
				{
					ModelState.AddModelError("", "Incorrect username or password.");
					return View();
				}
			}
			else
			{
				return View();
			}
		}
    }
}