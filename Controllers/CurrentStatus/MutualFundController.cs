using FinancialPlanner.BusinessLogic.CurrentStatus;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.CurrentStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinancialPlanner.Controllers.CurrentStatus
{
    public class MutualFundController : ApiController
    {
        [Route("api/MutualFund/GetAll")]
        [HttpGet]
        public Result<IList<MutualFund>> GetAll(int plannerId)
        {
            var result = new Result<IList<MutualFund>>();
            MutualFundService mutualFundService = new MutualFundService();
            result.Value =  mutualFundService.GetAll(plannerId);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/MutualFund/Get")]
        [HttpGet]
        public Result<MutualFund> Get(int id)
        {
            var result = new Result<MutualFund>();
            MutualFundService mutualFundService = new MutualFundService();
            result.Value = mutualFundService.Get(id);
            result.IsSuccess = true;
            return result;
        }

        [Route("api/MutualFund/Add")]
        [HttpPost]
        public Result Add(MutualFund mf)
        {
            var result = new Result();
            try
            {
                MutualFundService mutualFundService = new MutualFundService();
                mutualFundService.Add(mf);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/MutualFund/Update")]
        [HttpPost]
        public Result Update(MutualFund mf)
        {
            var result = new Result();
            try
            {
                MutualFundService mutualFundService = new MutualFundService();
                mutualFundService.Update(mf);
                result.IsSuccess = true;
            }
            catch (Exception exception)
            {
                result.IsSuccess = false;
                result.ExceptionInfo = exception;
            }
            return result;
        }

        [Route("api/MutualFund/Delete")]
        [HttpPost]
        public Result Delete(MutualFund mf)
        {
            var result = new Result();
            try
            {
                MutualFundService mutualFundService = new MutualFundService();
                mutualFundService.Delete(mf);
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
