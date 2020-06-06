using System.Web;
using System.Web.Mvc;

namespace NCL.WebApi.PagoCuotas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
