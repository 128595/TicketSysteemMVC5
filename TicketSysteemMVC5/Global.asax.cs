using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TicketSysteemMVC5.Config;
using TicketSysteemMVC5.Models;

namespace TicketSysteemMVC5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Strat de applicatie en roept de Initialisatie van Default Roles en Users aan
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Initialize users
            ApplicationDbContext db = new ApplicationDbContext();
            DefaultRolesAndUsers.Initialize(db);
        }
    }
}