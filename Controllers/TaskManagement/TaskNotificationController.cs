using FinancialPlanner.BusinessLogic.TaskManagements;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.TaskManagement
{
    public class TaskNotificationController : ApiController
    {
        [Route("api/TaskNotification/GetNotification")]
        [HttpGet]
        public Result<int> GetNotification(int userId)
        {
            var result = new Result<int>();
            TaskNotificationService taskNotificationService = new TaskNotificationService();

            result.Value = taskNotificationService.GetNotification(userId);
            result.IsSuccess = true;
            return result;
        }
    }
}
