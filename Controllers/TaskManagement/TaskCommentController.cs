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
    public class TaskCommentController : ApiController
    {
        [Route("api/TaskCommentController/GetAllComments")]
        [HttpGet]
        public Result<IList<TaskComment>> GetTaskComments(int taskId)
        {
            var result = new Result<IList<TaskComment>>();
            TaskCommentService taskCommentService = new TaskCommentService();
            result.Value = taskCommentService.GetTaskComments(taskId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskCommentController/GetTaskComment")]
        [HttpGet]
        public Result<TaskComment> GetTaskComment(int id)
        {
            var result = new Result<TaskComment>();
            TaskCommentService taskCommentService = new TaskCommentService();
            result.Value = taskCommentService.GetTaskComment(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskCommentController/Add")]
        [HttpPost]
        public Result Add(TaskComment taskComment)
        {
            var result = new Result();
            try
            {
                TaskCommentService taskCommentService = new TaskCommentService();
                taskCommentService.AddTaskComment(taskComment);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/TaskCommentController/Update")]
        [HttpPost]
        public Result Update(TaskComment taskComment)
        {
            var result = new Result();
            try
            {
                TaskCommentService taskCommentService = new TaskCommentService();
                taskCommentService.UpdateTaskComment(taskComment);
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
