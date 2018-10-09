using FinancialPlanner.Common.Model;
using FinancialPlanner.BusinessLogic.CurrentStatus;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class MFTransactionsController : ApiController
    {
        [Route("api/MFTransactions/GetAll")]
        [HttpGet]
        public Result<IList<MFTransactions>> GetAll(int plannerId)
        {
            var result = new Result<IList<MFTransactions>>();
            MFTransactionsService MFTransactionsService = new MFTransactionsService();
            result.Value = MFTransactionsService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/MFTransactions/Get")]
        [HttpGet]
        public Result<MFTransactions> Get(int id)
        {
            var result = new Result<MFTransactions>();
            MFTransactionsService MFTransactionsService = new MFTransactionsService();
            result.Value = MFTransactionsService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/MFTransactions/Add")]
        [HttpPost]
        public Result Add(MFTransactions mf)
        {
            var result = new Result();
            try
            {
                MFTransactionsService MFTransactionsService = new MFTransactionsService();
                MFTransactionsService.Add(mf);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/MFTransactions/Update")]
        [HttpPost]
        public Result Update(MFTransactions mf)
        {
            var result = new Result();
            try
            {
                MFTransactionsService MFTransactionsService = new MFTransactionsService();
                MFTransactionsService.Update(mf);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/MFTransactions/Delete")]
        [HttpPost]
        public Result Delete(MFTransactions mf)
        {
            var result = new Result();
            try
            {
                MFTransactionsService MFTransactionsService = new MFTransactionsService();
                MFTransactionsService.Delete(mf);
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
