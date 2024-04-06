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
            string url = context.Request.Path.ToString().ToLower();
            if (url == "/login" || url == "/login/index")
                goto result;

            string userName = context.Request.Cookies["UserName"]!;
            if (string.IsNullOrEmpty(userName))
            {
                context.Response.Redirect("/Login");
            }

        result:
            await _next(context);
        }
    }
}
