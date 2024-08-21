using Microsoft.AspNetCore.Mvc;

namespace Web.Framework.Controllers
{
    public class AccountController : Controller
    {
        //// ログインフォームを表示
        //[HttpGet]
        //public ActionResult Login()
        //{
        //    return View();
        //}

        //// ログインフォームからPOSTされたデータを受け取る
        //[HttpPost]
        //public ActionResult Login(string username)
        //{
        //    if (!string.IsNullOrEmpty(username))
        //    {
        //        // ユーザー名でログインする（パスワードは省略）
        //        // TODO ASP.NET メンバーシップは ASP.NET Core Identity に置き換える必要があります。詳細については、https://docs.microsoft.com/aspnet/core/migration/proper-to-2x/membership-to-core-identity を参照してください。
        //                        FormsAuthentication.RedirectFromLoginPage(username, false);

        //        // この後、指定したリダイレクト先に転送される
        //    }
        //    else
        //    {
        //        // ユーザー名が空の場合のエラー処理
        //        ModelState.AddModelError("", "ユーザー名を入力してください。");
        //        return View();
        //    }

        //    // ここには到達しない
        //    return null;
        //}

        //// ログアウト処理
        //public ActionResult Logout()
        //{
        //    // TODO ASP.NET メンバーシップは ASP.NET Core Identity に置き換える必要があります。詳細については、https://docs.microsoft.com/aspnet/core/migration/proper-to-2x/membership-to-core-identity を参照してください。
        //    FormsAuthentication.SignOut();
        //    return RedirectToAction("Login", "Account");
        //}
    }
}