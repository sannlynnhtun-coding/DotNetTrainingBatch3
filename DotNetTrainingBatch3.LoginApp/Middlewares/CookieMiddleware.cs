using Microsoft.AspNetCore.Http;

namespace DotNetTrainingBatch3.LoginApp.Middlewares
{
    public class CookieMiddleware
    {
        private readonly RequestDelegate _next;

        public CookieMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string UserName = context.Request.Cookies["Username"]!;
            string Password = context.Request.Cookies["Password"]!;
            string URL = context.Request.Path.ToString().ToLower();
            if (URL == "/login" || URL == "/login/loginui")
                goto Results;

            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                context.Response.Redirect("/Login/LoginUI");
            }
        Results:
            await _next(context);
        }
    }
}
