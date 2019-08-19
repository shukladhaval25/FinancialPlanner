using FinancialPlanner.BusinessLogic.TaskManagements;
using FinancialPlanner.Common;
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
    public class TaskController : ApiController
    {
        [Route("api/TaskController/GetAll")]
        [HttpGet]
        public Result<IList<TaskCard>> GetAll(int projectId)
        {
            var result = new Result<IList<TaskCard>>();
            TaskService taskService = new TaskService();

            var taskCards = taskService.GetAll();
            result.Value = (IList<TaskCard>)taskCards;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskController/Add")]
        [HttpPost]
        public Result Add(TaskCard taskCard)
        {
            var result = new Result();
            try
            {
                TaskService taskService = new TaskService();
                taskService.Add(taskCard);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }
    }
}
