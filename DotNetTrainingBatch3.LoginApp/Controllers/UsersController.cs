using DotNetTrainingBatch3.LoginApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.LoginApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly AppDBContext _db;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
            _db = new AppDBContext();
        }

        [ActionName("CreateUser")]
        public IActionResult CreateUser()
        {
            return View("CreateUser");
        }

        [HttpPost]
        [ActionName("Save")]
        public IActionResult Save(UsersModel users)
        {
            users.UserId = Guid.NewGuid().ToString();
            _db.Users.Add(users);
            int result = _db.SaveChanges();

            return RedirectToAction("Index", "Login");
        }
    }
}

