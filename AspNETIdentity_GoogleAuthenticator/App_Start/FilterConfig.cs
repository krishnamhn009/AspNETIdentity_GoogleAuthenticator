using System.Web;
using System.Web.Mvc;

namespace AspNETIdentity_GoogleAuthenticator
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
