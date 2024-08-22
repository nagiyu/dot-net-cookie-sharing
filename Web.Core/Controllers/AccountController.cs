using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Web.Framework.Controllers
{
    public class AccountController : Controller
    {
        // ログインフォームの表示
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //// ログインフォームからPOSTされたデータを処理
        //[HttpPost]
        //public async Task<IActionResult> Login(string username)
        //{
        //    if (!string.IsNullOrEmpty(username))
        //    {
        //        // クレーム（認証情報）を作成
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, username)
        //        };

        //        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        //        var authProperties = new AuthenticationProperties
        //        {
        //            IsPersistent = true, // クッキーを永続化するかどうか
        //        };

        //        // 認証クッキーを設定
        //        await HttpContext.SignInAsync(
        //            CookieAuthenticationDefaults.AuthenticationScheme,
        //            new ClaimsPrincipal(claimsIdentity),
        //            authProperties);

        //        // ログイン後にリダイレクト
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "ユーザー名を入力してください。");
        //        return View();
        //    }
        //}

        //// ログアウト処理
        //public async Task<IActionResult> Logout()
        //{
        //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return RedirectToAction("Login", "Account");
        //}
    }
}