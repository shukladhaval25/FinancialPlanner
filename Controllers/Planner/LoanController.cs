using FinancialPlanner.BusinessLogic.Plans;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class LoanController : ApiController
    {
       [Route("api/Loan/GetAll")]
       [HttpGet]
        public Result<IList<Loan>> GetAll(int plannerId)
        {
            var result = new Result<IList<Loan>>();
            LoanService loanService = new LoanService();
            result.Value = loanService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Loan/GetByID")]
        [HttpGet]
        public Result<Loan> Get(int id,int plannerId)
        {
            var result = new Result<Loan>();
            LoanService loanService = new LoanService();
            result.Value = loanService.GetById(id,plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Loan/Add")]
        [HttpPost]
        public Result Add(Loan loan)
        {
            var result = new Result();
            try
            {
                LoanService loanService = new LoanService();
                loanService.Add(loan);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Loan/Update")]
        [HttpPost]
        public Result Update(Loan loan)
        {
            var result = new Result();
            try
            {
                LoanService loanService = new LoanService();
                loanService.Update(loan);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Loan/Delete")]
        [HttpPost]
        public Result Delete(Loan loan)
        {
            var result = new Result();
            try
            {
                LoanService loanService = new LoanService();
                loanService.Delete(loan);
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
