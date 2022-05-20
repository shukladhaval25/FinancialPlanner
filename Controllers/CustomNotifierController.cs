using FinancialPlanner.BusinessLogic.ApplicationMaster;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CustomNotifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class CustomNotifierController : ApiController
    {
        [Route("api/CustomNotifier/Client")]
        [HttpGet]
        //[CustomAuthorization]
        public Result<IList<ClientDOB>> Get(DateTime fromDate,DateTime toDate)
        {
            var result = new Result<IList<ClientDOB>>();
            CustomNotificationService customNotification = new CustomNotificationService();

            var lstClient = customNotification.ClientDOB(fromDate,toDate);
            result.Value = (IList<ClientDOB>)lstClient;
            result.IsSuccess = true;
            return result;
        }
    }
}
