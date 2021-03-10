using System.Web;
using System.Web.Mvc;

namespace BTL_LTQL_1721050522_Trinh_Thu_Huong
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
