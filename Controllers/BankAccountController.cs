using FinancialPlanner.BusinessLogic.Clients;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class BankAccountController : ApiController
    {
        [Route("api/BankAccount/GetAll")]
        [HttpGet]
        public Result<IList<BankAccountDetail>> GetAll(int clientId)
        {
            var result = new Result<IList<BankAccountDetail>>();
            BankAccountService BankAccountDetailService = new BankAccountService();

            var lstClient = BankAccountDetailService.Get(clientId);
            result.Value = (IList<BankAccountDetail>)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/BankAccount/GetById")]
        [HttpGet]
        public Result<BankAccountDetail> Get(int id, int clientId)
        {
            var result = new Result<BankAccountDetail>();
            BankAccountService BankAccountDetailService = new BankAccountService();

            var lstClient = BankAccountDetailService.Get(id,clientId);
            result.Value = (BankAccountDetail)lstClient;
            result.IsSuccess = true;
            return result;
        }

        [Route("api/BankAccount/Add")]
        [HttpPost]
        public Result Add(BankAccountDetail BankAccountDetail)
        {
            var result = new Result();
            try
            {
                BankAccountService BankAccountDetailService = new BankAccountService();
                BankAccountDetailService.Add(BankAccountDetail);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/BankAccount/Update")]
        [HttpPost]
        public Result Update(BankAccountDetail BankAccountDetail)
        {
            var result = new Result();
            try
            {
                BankAccountService BankAccountDetailService = new BankAccountService();
                BankAccountDetailService.Update(BankAccountDetail);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/BankAccount/Delete")]
        [HttpDelete]
        public Result Delete(BankAccountDetail BankAccountDetail)
        {
            var result = new Result();
            try
            {
                BankAccountService BankAccountDetailService = new BankAccountService();
                BankAccountDetailService.Delete(BankAccountDetail);
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
