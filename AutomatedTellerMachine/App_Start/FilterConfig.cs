using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // for globally speifying the logging filter in the app
            filters.Add(new MyLoggingFilterAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
