using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialForms.ViewModels.Users;

namespace PartialForms.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Partial()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public ActionResult Partial(UserViewModel viewModel)
        {
            return View(viewModel);
        }

        public ActionResult EditorTemplate()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public ActionResult EditorTemplate(UserViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}