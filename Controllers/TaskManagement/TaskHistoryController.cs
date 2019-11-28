using FinancialPlanner.BusinessLogic.TaskManagements;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.TaskManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.TaskManagement
{
    public class TaskHistoryController : ApiController
    {
        [Route("api/TaskHistory/GetAll")]
        [HttpGet]
        public Result<IList<TaskHistory>> GetAll(int taskId)
        {
            var result = new Result<IList<TaskHistory>>();
            TaskHistoryService taskHistoryService = new TaskHistoryService();

            var taskHistories = taskHistoryService.GetAll(taskId);
            result.Value = (IList<TaskHistory>)taskHistories;
            result.IsSuccess = true;
            return result;
        }
    }
}
