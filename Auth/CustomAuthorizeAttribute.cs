#if NET48
using System.Web.Mvc;
#elif NET8_0
using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
#endif

namespace Auth
{
#if NET48
    public class CustomAuthorizeAttribute : AuthorizeAttribute
#elif NET8_0
    public class CustomAuthorizeAttribute : Attribute, IAuthorizationFilter
#endif
    {
#if NET48
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }
#endif

#if NET8_0
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // 通常の認証を確認する
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new ChallengeResult();
                return;
            }
        }
#endif
    }
}
