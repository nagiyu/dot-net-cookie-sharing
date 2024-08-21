using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Web.Framework.Controllers
{
    public class AccountController : Controller
    {
        // ログインフォームを表示
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // ログインフォームからPOSTされたデータを受け取る
        [HttpPost]
        public ActionResult Login(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                // ユーザー名でログインする（パスワードは省略）
                FormsAuthentication.RedirectFromLoginPage(username, false);

                // この後、指定したリダイレクト先に転送される
            }
            else
            {
                // ユーザー名が空の場合のエラー処理
                ModelState.AddModelError("", "ユーザー名を入力してください。");
                return View();
            }

            // ここには到達しない
            return null;
        }

        // ログアウト処理
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }
}