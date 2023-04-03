using System.Web;
using System.Web.Mvc;

namespace Sami_Mikhail_WebApplication__Assignment_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
