using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch3.LoginApp.Middlewares
{
    public class CookieMiddleware
    {
        private readonly AppDBContext _dbContext;
        private readonly RequestDelegate _next;

        public CookieMiddleware(RequestDelegate next)
        {
            _next = next;
            _dbContext = new AppDBContext();
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //string UserName = context.Request.Cookies["Username"]!;
            //string Password = context.Request.Cookies["Password"]!;

            string url = context.Request.Path.ToString().ToLower();
            if (url.ToLower() == "/login" || url.ToLower() == "/login/index")
                goto result;

            string userId = context.Request.Cookies["UserId"]!;
            string sessionId = context.Request.Cookies["SessionId"]!;

            var login = await _dbContext.Login.FirstOrDefaultAsync(x => x.UserId == userId && x.SessionId == sessionId);
            if (login is null)
            {
                context.Response.Redirect("/Login");
                goto result;
            }

            if (DateTime.Now > login.SessionExpired)
            {
                context.Response.Redirect("/Login");
                goto result;
            }

        //if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
        //{
        //    context.Response.Redirect("/Login/LoginUI");
        //}

        result:
            await _next(context);
        }
    }
}
