using FinancialPlanner.BusinessLogic;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FinancialPlanner.Controllers
{
    public class ExpensesController : ApiController
    {
        [Route("api/Expenses/GetAll")]
        [HttpGet]
        public Result<IList<Expenses>> GetAll(int plannerId)
        {
            var result = new Result<IList<Expenses>>();
            ExpensesService ExpensesService = new ExpensesService();
            result.Value = ExpensesService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Expenses/GetByID")]
        [HttpGet]
        public Result<Expenses> Get(int id, int plannerId)
        {
            var result = new Result<Expenses>();
            ExpensesService ExpensesService = new ExpensesService();
            result.Value = ExpensesService.GetById(id, plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/Expenses/Add")]
        [HttpPost]
        public Result Add(Expenses Expenses)
        {
            var result = new Result();
            try
            {
                ExpensesService ExpensesService = new ExpensesService();
                ExpensesService.Add(Expenses);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Expenses/Update")]
        [HttpPost]
        public Result Update(Expenses Expenses)
        {
            var result = new Result();
            try
            {
                ExpensesService ExpensesService = new ExpensesService();
                ExpensesService.Update(Expenses);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/Expenses/Delete")]
        [HttpPost]
        public Result Delete(Expenses Expenses)
        {
            var result = new Result();
            try
            {
                ExpensesService ExpensesService = new ExpensesService();
                ExpensesService.Delete(Expenses);
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
