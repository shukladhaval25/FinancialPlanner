using FinancialPlanner.BusinessLogic.Activity;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class ActivitiesController : ApiController
    {

        public Result<IList<Activities>> Get()
        {            
            var result = new Result<IList<Activities>>();            
            var lstActivities = ActivitiesService.Get();
            result.Value = (IList<Activities>)lstActivities;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/ActivitiesController/GetByUserName")]
        [HttpGet]
        public Result<IList<Activities>> Get(string userName)
        {
            var result = new Result<IList<Activities>>();
            var lstActivities = ActivitiesService.Get(userName);
            result.Value = (IList<Activities>)lstActivities;
            result.IsSuccess = true;
            return result;
        }
              //// POST: api/Activities
        //[HttpPost]
        public Result Add(Activities activity)
        {
            var result = new Result();
            try
            {                
                ActivitiesService.Add(activity.ActivityTypeValue, activity.EntryType,activity.SourceType,
                    activity.UserName,string.Empty,activity.HostName);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                //result.ExceptionInfo = new ExceptionInfo(exception);
            }

            return result;
        }
      
    }
}
