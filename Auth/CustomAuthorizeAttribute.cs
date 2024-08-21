#if NET48
using System.Web.Mvc;
#endif

namespace Auth
{
#if NET48
    public class CustomAuthorizeAttribute : AuthorizeAttribute
#elif NET8_0
    public class CustomAuthorizeAttribute
#endif
    {
#if NET48
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }
#endif
    }
}
