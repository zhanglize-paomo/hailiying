using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugin.Payments.HygainsA
{
    public partial class RouteProvider : IRouteProvider
    {
        #region Methods

        public void RegisterRoutes(RouteCollection routes)
        {
            //Notify
            routes.MapRoute("Plugin.Payments.HygainsA.Notify",
                 "Plugins/PaymentHygainsA/Notify",
                 new { controller = "PaymentHygainsA", action = "Notify" },
                 new[] { "Nop.Plugin.Payments.HygainsA.Controllers" }
            );

            //Notify
            routes.MapRoute("Plugin.Payments.HygainsA.Return",
                 "Plugins/PaymentHygainsA/Return",
                 new { controller = "PaymentHygainsA", action = "Return" },
                 new[] { "Nop.Plugin.Payments.HygainsA.Controllers" }
            );
        }

        #endregion

        #region Properties

        public int Priority
        {
            get
            {
                return 0;
            }
        }

        #endregion
    }
}
