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
    public class TaskReminderController : ApiController
    {
        [Route("api/TaskReminder/Reminders")]
        [HttpGet]
        public Result<IList<TaskReminder>> GetReminder(int userId)
        {
            var result = new Result<IList<TaskReminder>>();
            TaskReminderService taskReminderService = new TaskReminderService();

            var taskHistories = taskReminderService.GetReminders(userId);
            result.Value = (IList<TaskReminder>)taskHistories;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskReminder/TaskReminder")]
        [HttpGet]
        public Result<IList<TaskReminder>> GetTaskReminder(int taskId)
        {
            var result = new Result<IList<TaskReminder>>();
            TaskReminderService taskReminderService = new TaskReminderService();

            var taskHistories = taskReminderService.GetTaskReminders(taskId);
            result.Value = (IList<TaskReminder>)taskHistories;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskReminder/AddReminder")]
        [HttpPost]
        public Result<int> AddReminder(TaskReminder taskReminder)
        {
            var result = new Result<int>();
            TaskReminderService taskReminderService = new TaskReminderService();

            var taskReminderId = taskReminderService.AddReminder(taskReminder);
            result.Value = taskReminderId;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskReminder/UpdateReminder")]
        [HttpPost]
        public Result UpdateReminder(TaskReminder taskReminder)
        {
            var result = new Result();
            TaskReminderService taskReminderService = new TaskReminderService();
            taskReminderService.UpdateReminder(taskReminder);           
            result.IsSuccess = true;
            return result;
        }
    }
}
