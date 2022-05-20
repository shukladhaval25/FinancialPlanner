using System;
using System.Collections.Generic;
using FinancialPlanner.BusinessLogic.CurrentStatus;
using System.Web.Http;
using FinancialPlanner.Common.Model.CurrentStatus;
using FinancialPlanner.Common.Model;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class FixedDepositController : ApiController
    {
        [Route("api/FixedDeposit/GetAll")]
        [HttpGet]
        public Result<IList<FixedDeposit>> GetAll(int plannerId)
        {
            var result = new Result<IList<FixedDeposit>>();
            FixedDepositService FixedDepositService = new FixedDepositService();
            result.Value = FixedDepositService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/FixedDeposit/Get")]
        [HttpGet]
        public Result<FixedDeposit> Get(int id)
        {
            var result = new Result<FixedDeposit>();
            FixedDepositService FixedDepositService = new FixedDepositService();
            result.Value = FixedDepositService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/FixedDeposit/GetMaturity")]
        [HttpGet]
        public Result<IList<FixedDeposit>> GetMaturity(DateTime from, DateTime to)
        {
            var result = new Result<IList<FixedDeposit>>();
            FixedDepositService PPFService = new FixedDepositService();
            result.Value = PPFService.GetFDMaturity(from, to);
            result.IsSuccess = true;
            return result;
        }


        [Route("api/FixedDeposit/Add")]
        [HttpPost]
        public Result Add(FixedDeposit FixedDeposit)
        {
            var result = new Result();
            try
            {
                FixedDepositService FixedDepositService = new FixedDepositService();
                FixedDepositService.Add(FixedDeposit);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/FixedDeposit/Update")]
        [HttpPost]
        public Result Update(FixedDeposit FixedDeposit)
        {
            var result = new Result();
            try
            {
                FixedDepositService FixedDepositService = new FixedDepositService();
                FixedDepositService.Update(FixedDeposit);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/FixedDeposit/Delete")]
        [HttpPost]
        public Result Delete(FixedDeposit FixedDeposit)
        {
            var result = new Result();
            try
            {
                FixedDepositService FixedDepositService = new FixedDepositService();
                FixedDepositService.Delete(FixedDeposit);
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
