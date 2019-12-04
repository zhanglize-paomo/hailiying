using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugin.Payments.YunShanFu
{
    public partial class RouteProvider : IRouteProvider
    {
        #region Methods

        public void RegisterRoutes(RouteCollection routes)
        {
            //Notify
            routes.MapRoute("Plugin.Payments.YunShanFu.Notify",
                 "Plugins/PaymentHygainsA/Notify",
                 new { controller = "YunShanFu", action = "Notify" },
                 new[] { "Nop.Plugin.Payments.HygainsA.Controllers" }
            );

            //Notify
            routes.MapRoute("Plugin.Payments.YunShanFu.Return",
                 "Plugins/PaymentHygainsA/Return",
                 new { controller = "YunShanFu", action = "Return" },
                 new[] { "Nop.Plugin.Payments.YunShanFu.Controllers" }
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
