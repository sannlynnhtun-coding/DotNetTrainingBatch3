using DotNetTrainingBatch3.LoginApp.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DotNetTrainingBatch3.LoginApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly AppDBContext _db;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
            _db = new AppDBContext();
        }

        [ActionName("Index")]
        public IActionResult login()
        {
            return View("LoginIndex");
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult Validatelogin(UsersModel User)
        {
            UsersModel? Checklogin = _db.Users.FirstOrDefault(x => 
                x.UserName == User.UserName && 
                x.Password == User.Password);

            if (Checklogin is null)
            {
                return View("Index");
            }

            string sessionId = Guid.NewGuid().ToString();
            DateTime SessionExpire = DateTime.Now.AddSeconds(30);

            CookieOptions cookie = new CookieOptions();
            cookie.Expires = SessionExpire;
            Response.Cookies.Append("UserId", Checklogin.UserId, cookie);
            Response.Cookies.Append("SessionId", sessionId, cookie);

            LoginModel Login = new LoginModel();

            Login.SessionId = sessionId;
            Login.UserId = Checklogin.UserId;
            Login.SessionExpired = SessionExpire;
            _db.Login.Add(Login);
            _db.SaveChanges();

            return Redirect("/Home");
        }
    }
}
