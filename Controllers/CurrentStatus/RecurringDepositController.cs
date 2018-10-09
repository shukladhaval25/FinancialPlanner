using System;
using System.Collections.Generic;
using FinancialPlanner.BusinessLogic.CurrentStatus;
using System.Web.Http;
using FinancialPlanner.Common.Model.CurrentStatus;
using FinancialPlanner.Common.Model;


namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class RecurringDepositController : ApiController
    {
        [Route("api/RecurringDeposit/GetAll")]
        [HttpGet]
        public Result<IList<RecurringDeposit>> GetAll(int plannerId)
        {
            var result = new Result<IList<RecurringDeposit>>();
            RecurringDepositService RecurringDepositService = new RecurringDepositService();
            result.Value = RecurringDepositService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/RecurringDeposit/Get")]
        [HttpGet]
        public Result<RecurringDeposit> Get(int id)
        {
            var result = new Result<RecurringDeposit>();
            RecurringDepositService RecurringDepositService = new RecurringDepositService();
            result.Value = RecurringDepositService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/RecurringDeposit/Add")]
        [HttpPost]
        public Result Add(RecurringDeposit RecurringDeposit)
        {
            var result = new Result();
            try
            {
                RecurringDepositService RecurringDepositService = new RecurringDepositService();
                RecurringDepositService.Add(RecurringDeposit);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RecurringDeposit/Update")]
        [HttpPost]
        public Result Update(RecurringDeposit RecurringDeposit)
        {
            var result = new Result();
            try
            {
                RecurringDepositService RecurringDepositService = new RecurringDepositService();
                RecurringDepositService.Update(RecurringDeposit);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/RecurringDeposit/Delete")]
        [HttpPost]
        public Result Delete(RecurringDeposit RecurringDeposit)
        {
            var result = new Result();
            try
            {
                RecurringDepositService RecurringDepositService = new RecurringDepositService();
                RecurringDepositService.Delete(RecurringDeposit);
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
