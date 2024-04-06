using DotNetTrainingBatch3.LoginApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.LoginApp.Controllers
{
    public class LoginController : Controller
    {
        [ActionName("Index")]
        public IActionResult LoginIndex()
        {
            return View("LoginIndex");
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult LoginIndex(LoginModel reqModel)
        {
            return Redirect("/Login");
        }
    }
}
