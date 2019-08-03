using FinancialPlanner.BusinessLogic.TaskManagements;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.TaskManagement;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers.TaskManagement
{
    public class TaskProjectController : ApiController
    {
        [Route("api/TaskProjectController/GetAll")]
        [HttpGet]
        public Result<IList<Project>> GetAll()
        {
            var result = new Result<IList<Project>>();
            TaskProjectService  taskProjectService = new TaskProjectService();

            var lstProject = taskProjectService.GetAll();
            result.Value = (IList<Project>)lstProject;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/TaskProjectController/Get")]
        [HttpGet]
        public Result<Project> Get(int id)
        {
            var result = new Result<Project>();
            TaskProjectService taskProjectService = new TaskProjectService();

            result.Value = taskProjectService.GetById(id);
            result.IsSuccess = true;
            return result;
        }

        // POST: api/TaskProject
        [Route("api/TaskProjectController/Add")]
        [HttpPost]
        public Result Add(Project project)
        {
            var result = new Result();
            try
            {
                TaskProjectService projectService = new TaskProjectService();
                projectService.Add(project);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/TaskProjectController/Update")]
        [HttpPost]
        public Result Update(Project project)
        {
            var result = new Result();
            try
            {
                TaskProjectService projectService = new TaskProjectService();
                projectService.Update(project);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/TaskProjectController/Delete")]
        [HttpPost]
        public Result Delete(Project project)
        {
            var result = new Result();
            try
            {
                TaskProjectService projectService = new TaskProjectService();
                projectService.Delete(project);
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
