using DotNetTrainingBatch3.LoginAppV2.EFDbContext;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.LoginAppV2.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public LoginController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UsersModel user)
        {
            var item = _appDbContext.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (item is null) return View();

            string sessionId = Guid.NewGuid().ToString();
            DateTime sessionExpire = DateTime.Now.AddSeconds(50);

            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Append("UserId", item.UserId, cookie);
            Response.Cookies.Append("SessionId", sessionId, cookie);

            await _appDbContext.Login.AddAsync(new LoginModel
            {
                SessionId = sessionId,
                UserId = item.UserId,
                SessionExpired = sessionExpire,
            });
            await _appDbContext.SaveChangesAsync();

            return Redirect("/Home");
        }
    }
}
