using FinancialPlanner.BusinessLogic;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class IncomeController : ApiController
    {
        [Route("api/Income/GetAll")]
        [HttpGet]
        public Result<IList<Income>> GetAll(int plannerId)
        {
            var result = new Result<IList<Income>>();
            IncomeService incomeService = new IncomeService();
            result.Value = incomeService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Income/GetByID")]
        [HttpGet]
        public Result<Income> Get(int id, int plannerId)
        {
            var result = new Result<Income>();
            IncomeService IncomeService = new IncomeService();
            result.Value = IncomeService.GetById(id, plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Income/Add")]
        [HttpPost]
        public Result Add(Income Income)
        {
            var result = new Result();
            try
            {
                IncomeService IncomeService = new IncomeService();
                IncomeService.Add(Income);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Income/Update")]
        [HttpPost]
        public Result Update(Income Income)
        {
            var result = new Result();
            try
            {
                IncomeService IncomeService = new IncomeService();
                IncomeService.Update(Income);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Income/Delete")]
        [HttpPost]
        public Result Delete(Income Income)
        {
            var result = new Result();
            try
            {
                IncomeService IncomeService = new IncomeService();
                IncomeService.Delete(Income);
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
