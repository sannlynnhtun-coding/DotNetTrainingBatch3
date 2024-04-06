﻿using DotNetTrainingBatch3.LoginApp.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
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
            string id = Guid.NewGuid().ToString();
            string userId = Ulid.NewUlid().ToString();

            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddSeconds(10);
            Response.Cookies.Append("UserName", reqModel.UserName, option);
            return Redirect("/Home");
        }

        // Tbl_User
        // UserId - guid / ulid
        // UserName
        // Password

        // Tbl_Login
        // UserId
        // SessionId
        // SessionExpired

        // Create Form 
        // User (UserName, Password) 

        // check user exist
        // UserId
        // New Session Id - guid / ulid
        // SessionExpired
        // Tbl_Login
    }
}
