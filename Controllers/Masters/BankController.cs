using FinancialPlanner.BusinessLogic.ApplicationMaster;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.Masters
{
    public class BankController : ApiController
    {
        [Route("api/Bank/GetAll")]
        [HttpGet]
        public Result<IList<Bank>> GetAll()
        {
            var result = new Result<IList<Bank>>();
            BankService bankService = new BankService();

            var lstClient = bankService.Get();
            result.Value = (IList<Bank>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Bank/Add")]
        [HttpPost]
        public Result Add(Bank bank)
        {
            var result = new Result();
            try
            {
                BankService bankService = new BankService();
                bankService.Add(bank);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Bank/Update")]
        [HttpPost]
        public Result Update(Bank bank)
        {
            var result = new Result();
            try
            {
                BankService bankService = new BankService();
                bankService.Update(bank);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Bank/Delete")]
        [HttpDelete]
        public Result Delete(Bank bank)
        {
            var result = new Result();
            try
            {
                BankService bankService = new BankService();
                bankService.Delete(bank);
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
