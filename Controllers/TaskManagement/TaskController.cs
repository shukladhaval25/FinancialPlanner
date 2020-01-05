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

        [Route("api/TaskController/GetAllTasks")]
        [HttpGet]
        public Result<IList<TaskCard>> GetAllTasks()
        {
            var result = new Result<IList<TaskCard>>();
            TaskService taskService = new TaskService();

            var taskCards = taskService.GetAllTasks();
            result.Value = (IList<TaskCard>)taskCards;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskController/GetAllByProjectName")]
        [HttpGet]
        public Result<IList<TaskCard>> GetAllByProjectName(string projectName)
        {
            var result = new Result<IList<TaskCard>>();
            TaskService taskService = new TaskService();

            var taskCards = taskService.GetAll(projectName);
            result.Value = (IList<TaskCard>)taskCards;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskController/NotifiedTasks")]
        [HttpGet]
        public Result<IList<TaskCard>> GetNotifiedTasks(int userId)
        {
            var result = new Result<IList<TaskCard>>();
            TaskService taskService = new TaskService();

            var taskCards = taskService.GetNotified(userId);
            result.Value = (IList<TaskCard>)taskCards;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskController/AssignTo")]
        [HttpGet]
        public Result<IList<TaskCard>> AssignTo(int userId)
        {
            var result = new Result<IList<TaskCard>>();
            TaskService taskService = new TaskService();

            var taskCards = taskService.GetByAssignTo(userId);
            result.Value = (IList<TaskCard>)taskCards;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskController/GetOverDueTask")]
        [HttpGet]
        public Result<IList<TaskCard>> GetOverDueTask(int userId)
        {
            var result = new Result<IList<TaskCard>>();
            TaskService taskService = new TaskService();

            var taskCards = taskService.GetOverDueTasks(userId);
            result.Value = (IList<TaskCard>)taskCards;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskController/GetUserPerformanceForYear")]
        [HttpGet]
        public Result<IList<UserPerformanceOnTask>> GetUserPerformanceForYear(int userId)
        {
            var result = new Result<IList<UserPerformanceOnTask>>();
            TaskService taskService = new TaskService();

            var taskCards = taskService.GetUserPerformanceForYear(userId);
            result.Value = (IList<UserPerformanceOnTask>)taskCards;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskController/GetCompanyTaskPerformanceForYear")]
        [HttpGet]
        public Result<IList<UserPerformanceOnTask>> GetCompanyTaskPerformanceForYear()
        {
            var result = new Result<IList<UserPerformanceOnTask>>();
            TaskService taskService = new TaskService();

            var taskCards = taskService.GetCompanyTaskPerformanceForYear();
            result.Value = (IList<UserPerformanceOnTask>)taskCards;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskController/GetTaskByProjectAndUser")]
        [HttpGet]
        public Result<IList<TaskCard>> GetTaskByProjectAndUser(string projetName, int userId)
        {
            var result = new Result<IList<TaskCard>>();
            TaskService taskService = new TaskService();

            var taskCards = taskService.GetOpenTaskByProjectForUser(projetName, userId);
            result.Value = (IList<TaskCard>)taskCards;
            result.IsSuccess = true;
            return result;
        }


        [Route("api/TaskController/GetAll")]
        [HttpGet]
        public Result<IList<TaskCard>> GetAll()
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
        public Result<int> Add(TaskCard taskCard)
        {
            var result = new Result<int>();
            try
            {
                TaskService taskService = new TaskService();
                result.Value =  taskService.Add(taskCard);
                result.IsSuccess = true;
                return result;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/TaskController/Update")]
        [HttpPost]
        public Result<int> Update(TaskCard taskCard)
        {
            var result = new Result<int>();
            try
            {
                TaskService taskService = new TaskService();
                result.Value = taskService.Update(taskCard);
                result.IsSuccess = true;
                return result;
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
