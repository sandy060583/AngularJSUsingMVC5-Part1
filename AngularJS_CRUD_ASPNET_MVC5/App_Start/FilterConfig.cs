using System.Web;
using System.Web.Mvc;

namespace AngularJS_CRUD_ASPNET_MVC5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
