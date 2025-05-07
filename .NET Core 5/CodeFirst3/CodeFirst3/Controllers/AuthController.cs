using CodeFirst3.Models;
using CodeFirst3.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CodeFirst3.Controllers
{
    public class AuthController : Controller
    {
        IRepository<AppUser> _repoUser;
        public AuthController(IRepository<AppUser> repoUser)
        {
            _repoUser = repoUser;   
        }

        public IActionResult Login()
        {
            return View();
        }

        // veritabanında ilgili kullanıcı var mı
        //Kullanıcı bilgilerini çekme
        //kullanıcının şifresi kriptolu veriyle eşleşiyor mu
        //kullanıcı rolüne göre sayfa yönlendirmesi

        [HttpPost]
        public async Task<IActionResult> Login(AppUser user)
        {
            if (_repoUser.Any(x=> x.UserName == user.UserName && x.Status != Enums.DataStatus.Deleted))
            {
                AppUser selectedUser = _repoUser.Default(x => x.UserName == user.UserName && x.Status != Enums.DataStatus.Deleted);

                bool isValid = BCrypt.Net.BCrypt.Verify(user.Password, selectedUser.Password);

                    if (isValid)
                    {

                        List<Claim> claim = new List<Claim>()
                        {

                            new Claim("userName",selectedUser.UserName),
                            new Claim ("UserId",selectedUser.ID.ToString()),
                            new Claim("role",selectedUser.Role.ToString())
                        };

                     ClaimsIdentity  identity = new ClaimsIdentity(claim,CookieAuthenticationDefaults.AuthenticationScheme);
                        ClaimsPrincipal principal =     new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync(principal);
                        if (selectedUser.Role ==Enums.Role.admin) { 

                            return RedirectToAction("Index", "Home", new { area ="Management" });
                    }
                        else if (selectedUser.Role == Enums.Role.user)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SingOutAsync();            return RedirectToAction("Login");
        }
    }
}
