using System.Web;
using System.Web.Mvc;

namespace _5951071067_NguyenThanhNhan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
