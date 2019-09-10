using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.TaskManagement.MFTransactions;
using System;
using System.Collections.Generic;
using FinancialPlanner.BusinessLogic.ApplicationMaster;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Masters
{
    public class SchemeController : ApiController
    {
        [Route("api/Scheme/GetAll")]
        [HttpGet]
        public Result<IList<Scheme>> GetAll()
        {
            var result = new Result<IList<Scheme>>();
            SchemeService SchemeService = new SchemeService();

            var lstClient = SchemeService.Get();
            result.Value = (IList<Scheme>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Scheme/GetAll")]
        [HttpGet]
        public Result<IList<Scheme>> GetAll(int amcId)
        {
            var result = new Result<IList<Scheme>>();
            SchemeService SchemeService = new SchemeService();

            result.Value = SchemeService.GetAll(amcId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Scheme/GetSchemeCount")]
        [HttpGet]
        public Result<int> GetCount(int amcId)
        {
            var result = new Result<int>();
            SchemeService SchemeService = new SchemeService();
            result.Value = SchemeService.Get(amcId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Scheme/Add")]
        [HttpPost]
        public Result Add(Scheme Scheme)
        {
            var result = new Result();
            try
            {
                SchemeService SchemeService = new SchemeService();
                SchemeService.Add(Scheme);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Scheme/Update")]
        [HttpPost]
        public Result Update(Scheme Scheme)
        {
            var result = new Result();
            try
            {
                SchemeService SchemeService = new SchemeService();
                SchemeService.Update(Scheme);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Scheme/Delete")]
        [HttpDelete]
        public Result Delete(Scheme Scheme)
        {
            var result = new Result();
            try
            {
                SchemeService SchemeService = new SchemeService();
                SchemeService.Delete(Scheme);
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
