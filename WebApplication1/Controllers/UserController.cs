using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var model = new UserModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            return View(model);
        }

        public string Test(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}