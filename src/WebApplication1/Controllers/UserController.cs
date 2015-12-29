using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using WebApplication1.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            List<string> friendNames = new List<string>
            {
                "Sveta",
                "Dima",
                "Dima",
                "Vova"
            };

            UserViewModel model = new UserViewModel()
            {
                Name = "Alex",
                Birthday = DateTime.UtcNow,
                FriendNames = friendNames.ToArray(),
            };

            return this.View();
        }
    }
}
