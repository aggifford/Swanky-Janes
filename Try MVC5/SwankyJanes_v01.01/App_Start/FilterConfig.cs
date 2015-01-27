using System.Web;
using System.Web.Mvc;

namespace SwankyJanes_v01._01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
