using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinancialPlanner.Common.Model;
using FinancialPlanner.BusinessLogic.ApplictionConfiguration;

namespace FinancialPlanner.Controllers
{
    public class ApplicationConfigurationController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public Result<IList<ApplicationConfiguration>> Get()
        {
            var result = new Result<IList<ApplicationConfiguration>>();
            ApplicationConfiService appConfigService = new ApplicationConfiService();
            
            var lstAppConfig = appConfigService.Get();
            result.Value = (IList<ApplicationConfiguration>) lstAppConfig;
            result.IsSuccess = true;
            return result;
        }

        // GET api/<controller>/5
        public Result<ApplicationConfiguration> Get(int id)
        {
            var result = new Result<ApplicationConfiguration>();
            ApplicationConfiService appConfigService = new ApplicationConfiService();

            result.Value = appConfigService.Get(id);
            result.IsSuccess = true;
            return result;           
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/ApplicationConfiguration/AddConfig")]        
        public Result AddConfig(ApplicationConfiguration appConfig)
        {
            var result = new Result();
            try
            {
                ApplicationConfiService appConfigService = new ApplicationConfiService();
                appConfigService.Add(appConfig);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }

        [HttpPost]
        [Route("api/ApplicationConfiguration/AddConfigs")]
        public Result AddConfigs(List<ApplicationConfiguration> appConfigs)
        {
            var result = new Result();
            try
            {
                ApplicationConfiService appConfigService = new ApplicationConfiService();
                appConfigService.Add(appConfigs);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }

            return result;
        }

        //PUT api/<controller>/5
        [HttpPost]
        [Route("api/ApplicationConfiguration/Updateconfig")]
        public Result Updateconfig(ApplicationConfiguration appConfig)
        {
            var result = new Result();
            try
            {
                ApplicationConfiService appConfigService = new ApplicationConfiService();
                appConfigService.Update(appConfig);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [HttpPost]
        [Route("api/ApplicationConfiguration/Updateconfigs")]
        public Result Updateconfig(List<ApplicationConfiguration> appConfigs)
        {
            var result = new Result();
            try
            {
                ApplicationConfiService appConfigService = new ApplicationConfiService();
                appConfigService.Update(appConfigs);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public Result Delete(int id)
        {
            var result = new Result();
            try
            {
                ApplicationConfiService appConfigService = new ApplicationConfiService();
                appConfigService.Delete(id);
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