using FinancialPlanner.BusinessLogic.Email;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class EmailSchedulerController : ApiController
    {
        [HttpGet]
        [Route("api/EmailScheduler/Get")]
        public Result<IList<EmailScheduler>> Get()
        {
            var result = new Result<IList<EmailScheduler>>();
            EmailScheduleService emailScheduleService = new EmailScheduleService();

            var lstEmailScheduler = emailScheduleService.Get();
            result.Value = (IList<EmailScheduler>)lstEmailScheduler;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/EmailScheduler/Add")]
        [HttpPost]
        public Result Add(EmailScheduler emailScheduler)
        {
            var result = new Result();
            try
            {
                EmailScheduleService emailScheduleService = new EmailScheduleService();
                emailScheduleService.Add(emailScheduler);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/EmailScheduler/Update")]
        [HttpPost]
        public Result Update(EmailScheduler emailScheduler)
        {
            var result = new Result();
            try
            {
                EmailScheduleService emailScheduleService = new EmailScheduleService();
                emailScheduleService.Update(emailScheduler);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/EmailScheduler/Delete")]
        [HttpPost]
        public Result Delete(EmailScheduler emailScheduler)
        {
            var result = new Result();
            try
            {
                EmailScheduleService emailScheduleService = new EmailScheduleService();
                emailScheduleService.Delete(emailScheduler);
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
