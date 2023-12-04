using Microsoft.AspNetCore.Mvc;
using Milestone1.Models;
using Milestone1.Services;


namespace Milestone1.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ProcessLogin(UserModel user)
		{
			SecurityDAO securityDAO = new SecurityDAO();
            if (securityDAO.InsertUser(user))
                securityDAO.InsertUser(user);
			return View(user);
		}
	}
}

