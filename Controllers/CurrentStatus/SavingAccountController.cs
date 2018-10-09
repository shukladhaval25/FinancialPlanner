using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Web.Http;
using FinancialPlanner.BusinessLogic.CurrentStatus;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class SavingAccountController : ApiController
    {
        [Route("api/SavingAccount/GetAll")]
        [HttpGet]
        public Result<IList<SavingAccount>> GetAll(int plannerId)
        {
            var result = new Result<IList<SavingAccount>>();
            SavingAccountService SavingAccountService = new SavingAccountService();
            result.Value = SavingAccountService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/SavingAccount/Get")]
        [HttpGet]
        public Result<SavingAccount> Get(int id)
        {
            var result = new Result<SavingAccount>();
            SavingAccountService SavingAccountService = new SavingAccountService();
            result.Value = SavingAccountService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/SavingAccount/Add")]
        [HttpPost]
        public Result Add(SavingAccount savingAccount)
        {
            var result = new Result();
            try
            {
                SavingAccountService SavingAccountService = new SavingAccountService();
                SavingAccountService.Add(savingAccount);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/SavingAccount/Update")]
        [HttpPost]
        public Result Update(SavingAccount savingAccount)
        {
            var result = new Result();
            try
            {
                SavingAccountService SavingAccountService = new SavingAccountService();
                SavingAccountService.Update(savingAccount);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/SavingAccount/Delete")]
        [HttpPost]
        public Result Delete(SavingAccount savingAccount)
        {
            var result = new Result();
            try
            {
                SavingAccountService SavingAccountService = new SavingAccountService();
                SavingAccountService.Delete(savingAccount);
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
