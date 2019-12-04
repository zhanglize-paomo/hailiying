using Nop.Services.Payments;
using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Payments.YunShanFu.Controllers
{
    public class YunShanFuController : BasePaymentController
    {
        public YunShanFuController()
        {
        }

        public override ProcessPaymentRequest GetPaymentInfo(FormCollection form)
        {
            throw new NotImplementedException();
        }

        public override IList<string> ValidatePaymentForm(FormCollection form)
        {
            throw new NotImplementedException();
        }
    }
}
